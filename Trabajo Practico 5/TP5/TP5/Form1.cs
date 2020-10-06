using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5.Clases;

namespace TP5
{
    public partial class Form1 : Form
    {
        //Constantes
        const string EVENTO_INICIO_DE_SIMULACION = "Inicio de simulación";
        const string EVENTO_FIN_DE_SIMULACION = "Fin de simulación";
        const string EVENTO_LLEGADA_DE_PEDIDO = "Llegada de pedido";
        const string EVENTO_PEDIDO_FINALIZADO = "Pedido Finalizado";
        const string EVENTO_ENTREGA_DE_PEDIDO = "Entrega de Pedido";

        //Creacion de Vectores de estado
        VectorEstado anterior = new VectorEstado();
        VectorEstado actual = new VectorEstado();

        //variables globales
        private int numeroPedido = 0;

        int pedidosPorHora = 5;
        int mediaEmpanadas = 3;
        double a_pizza = 15;
        double b_pizza = 18;
        double mediaDemoraPedido = 3;
        TimeSpan tiempoFinSimulacion = new TimeSpan(6,0,0); //6 horas
        int pedidosMaxDelivery = 3;


        /***************************************************** TABLA ******************************************************/
        DataTable resultadoFinal = new DataTable();
        public Form1()
        {
            InitializeComponent();
            resultadoFinal.Columns.Add("Numero Evento");
            resultadoFinal.Columns.Add("Evento");
            resultadoFinal.Columns.Add("Reloj");
            resultadoFinal.Columns.Add("Tiempo entre llegadas");
            resultadoFinal.Columns.Add("Proxima Llegada");
            resultadoFinal.Columns.Add("Cola Pedidos");
            resultadoFinal.Columns.Add("Tiempo de proceso servidor 1");
            resultadoFinal.Columns.Add("Momento Fin Proceso servidor 1");
            resultadoFinal.Columns.Add("Estado Servidor 1");
            resultadoFinal.Columns.Add("Tiempo de proceso servidor 2");
            resultadoFinal.Columns.Add("Momento Fin Proceso servidor 2");
            resultadoFinal.Columns.Add("Estado Servidor 2");
            resultadoFinal.Columns.Add("Tiempo de proceso servidor 3");
            resultadoFinal.Columns.Add("Momento Fin Proceso servidor 3");
            resultadoFinal.Columns.Add("Estado Servidor 3");
            resultadoFinal.Columns.Add("Cola Delivery");
            resultadoFinal.Columns.Add("Tiempo Entrega");
            resultadoFinal.Columns.Add("Momento Entrega");
            resultadoFinal.Columns.Add("Estado Delivery");
        }

        private void agregarFila(VectorEstado actual)
        {
            var fila = resultadoFinal.NewRow();
            fila["Numero Evento"] = actual.numeroEvento;
            fila["Evento"] = actual.evento;
            fila["Reloj"] = actual.reloj;
            fila["Tiempo entre llegadas"] = actual.tiempoEntreLlegada;
            fila["Proxima Llegada"] = actual.momentoProximaLlegada;
            fila["Cola Pedidos"] = actual.longitudColaPedido;
            fila["Tiempo de proceso servidor 1"] = actual.cocineros[2].tiempoProceso;
            fila["Momento Fin Proceso servidor 1"] = actual.cocineros[2].finProceso();
            fila["Estado Servidor 1"] = actual.cocineros[2].estadoServidor.ToString();
            fila["Tiempo de proceso servidor 2"] = actual.cocineros[1].tiempoProceso;
            fila["Momento Fin Proceso servidor 2"] = actual.cocineros[1].finProceso();
            fila["Estado Servidor 2"] = actual.cocineros[1].estadoServidor.ToString();
            fila["Tiempo de proceso servidor 3"] = actual.cocineros[0].tiempoProceso;
            fila["Momento Fin Proceso servidor 3"] = actual.cocineros[0].finProceso();
            fila["Estado Servidor 3"] = actual.cocineros[0].estadoServidor.ToString();
            fila["Cola Delivery"] = actual.longitudColaDelivery;
            fila["Tiempo Entrega"] = actual.delivery.tiempoProceso;
            fila["Momento Entrega"] = actual.delivery.finProceso();
            fila["Estado Delivery"] = actual.delivery.estadoServidor.ToString();

            resultadoFinal.Rows.Add(fila);
        }
        /***************************************************** TABLA ******************************************************/

        private void generarEventoInicial()
        {
            //Para iniciar la simulacion, generamos el primer evento y calculamos la primer llegada
            actual.evento = EVENTO_INICIO_DE_SIMULACION;
            actual.tiempoEntreLlegada = generarTiempoEntreLlegada();
            anterior.clonar(actual);
            agregarFila(actual);
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            generarEventoInicial();
            TimeSpan tiempoProximoEvento;
            string evento = anterior.evento;
            Pedido pedidoAux;


            while (evento != EVENTO_FIN_DE_SIMULACION)
            {
                evento = getProximoEvento(out tiempoProximoEvento, out pedidoAux);

                actual.numeroEvento = anterior.numeroEvento + 1;
                actual.reloj = tiempoProximoEvento;

                switch (evento)
                {
                    case EVENTO_LLEGADA_DE_PEDIDO:
                        simularLlegadaDePedido();
                        break;
                
                    case EVENTO_PEDIDO_FINALIZADO:
                        simularPedidoFinalizado(pedidoAux);
                        break;
                
                    case EVENTO_ENTREGA_DE_PEDIDO:
                        simularEntregaDePedido();
                        break;

                    default:
                        break;
                }

                if(tiempoProximoEvento > tiempoFinSimulacion)
                {
                    evento = EVENTO_FIN_DE_SIMULACION;
                }

                // **NOTA: copio los datos de esta manera para trabajar con solo los 2 vectores en memoria y operar con el actual
                anterior.clonar(actual);

                agregarFila(actual);
                //TODO: Hacer que terminen todos los eventos pendientes
            }


            grdResultado.DataSource = resultadoFinal;

            //TODO: Consultar como generamos la distribucion poisson
            //actual.cantidadEmpandasPedidas = getCantidadEmpanadas();

        }

        /// <summary>
        /// Obtiene el proximo evento comparando los tiempos del vector anterior y viendo cual es el menor de ellos
        /// </summary>
        /// <returns></returns>
        internal string getProximoEvento(out TimeSpan proximoReloj, out Pedido pedido)
        {
            pedido = null;
            proximoReloj = new TimeSpan(0, 0, 0);
            bool primero = true;

            string proximoEvento = EVENTO_PEDIDO_FINALIZADO;

            Servidor cocineroConMenorTiempoFinProceso = null;

            foreach (var cocinero in anterior.cocineros)
            {
                if (cocinero.estadoServidor == EstadoServidor.libre)
                {
                    continue;
                }

                if (primero)
                {
                    proximoReloj = cocinero.finProceso();
                    cocineroConMenorTiempoFinProceso = cocinero;
                    primero = false;
                }
                else
                {
                    if (cocinero.finProceso() < proximoReloj)
                    {
                        proximoReloj = cocinero.finProceso();
                        cocineroConMenorTiempoFinProceso = cocinero;
                    }
                }

                pedido = anterior.pedidos.Where(p => p.cocinero.numeroServidor == cocineroConMenorTiempoFinProceso.numeroServidor).FirstOrDefault();
            }

            if (anterior.delivery != null && anterior.delivery.estadoServidor == EstadoServidor.ocupado)
            {
                if (cocineroConMenorTiempoFinProceso != null)
                {
                    if (anterior.delivery.finProceso() < proximoReloj)
                    {
                        proximoReloj = anterior.delivery.finProceso();
                        proximoEvento = EVENTO_ENTREGA_DE_PEDIDO;
                    }
                }
                else
                {
                    proximoReloj = anterior.delivery.finProceso();
                    proximoEvento = EVENTO_ENTREGA_DE_PEDIDO;
                }

            }

            if (anterior.momentoProximaLlegada < proximoReloj || proximoReloj.TotalMinutes == 0)
            {
                proximoReloj = anterior.momentoProximaLlegada;
                proximoEvento = EVENTO_LLEGADA_DE_PEDIDO;
            }

            return proximoEvento;
        }

        public int getCantidadCocinerosLibres()
        {
            int contLibres = 0;

            foreach (var cocinero in anterior.cocineros)
            {
                if (cocinero.estadoServidor == EstadoServidor.libre)
                {
                    contLibres++;
                }

            }

            return contLibres;
        }



        /// <summary>
        /// Asigna el pedido de acuerdo a quien tiene mas tiempo libre o de lo contrario por igual probabilidad de los que estan libres
        /// </summary>
        internal void prepararPedido(Pedido pedido)
        {
            Servidor cocineroConMasTiempoLibre = obtenerCocineroMayorTiempoLibre();
            cocineroConMasTiempoLibre.estadoServidor = EstadoServidor.ocupado;
            cocineroConMasTiempoLibre.tiempoProceso = pedido.calcularTiempoDemora();
            cocineroConMasTiempoLibre.inicioProceso = actual.reloj;
            pedido.momentoInicio = actual.reloj;
            pedido.cocinero = cocineroConMasTiempoLibre;
        }

        private Servidor obtenerCocineroMayorTiempoLibre()
        {
            TimeSpan mayorTiempoLibre = new TimeSpan(0, 0, 0);
            bool primero = true;

            Servidor cocineroConMasTiempoLibre = null;

            foreach (var cocinero in anterior.cocineros)
            {
                if (cocinero.estadoServidor == EstadoServidor.libre)
                {
                    if (primero)
                    {
                        mayorTiempoLibre = cocinero.tiempoLibre;
                        cocineroConMasTiempoLibre = cocinero;
                        primero = false;
                    }
                    else
                    {
                        if (cocinero.tiempoLibre >= mayorTiempoLibre)
                        {
                            mayorTiempoLibre = cocinero.tiempoLibre;
                            cocineroConMasTiempoLibre = cocinero;
                        }
                    }
                }
            }
            return cocineroConMasTiempoLibre;
        }

        /*
        internal void liberarCocinero(int numeroPedido)
        {
            Servidor cocinero = anterior.cocineros.Where(x => x.numeroPedido == numeroPedido).FirstOrDefault();

            if (cocinero != null)
            {
                cocinero.estadoServidor = EstadoServidor.libre;
            }
        }
        */
        private Pedido generarPedido()
        {
            //generamos el random para saber a que pedido pertenece
            Double random = new Random().NextDouble();
            Pedido pedido;
            if (random < 0.2d)
            {
                //Genero una docena de sanguches
                pedido = new PedidoSandwich(1, 1);
                actual.sandwichPreparados++;
            }
            else if (0.2d < random && random < 0.6d)
            {
                //Genero un pedido pizza
                pedido = new PedidoPizza(1, 1);
                actual.pizzasPreparadas++;
            }
            else if (0.6 < random && random < 0.9d)
            {
                //genero un pedido de empanadas
                pedido = new PedidoEmpanadas();
                //TODO: ver como obtener la cantidad de empanadas, quiza pueda devolverla como parametro de salida
                actual.empanadasPreparadas++;
            }
            else if (0.9d < random && random < 0.95d)
            {
                //Genero un pedido de hamburguesas
                pedido = new PedidoHamburguesa();
                actual.hamburguesasPreparados++;
            }
            else
            {
                //Genero un pedido de lomito
                pedido = new PedidoLomito();
                actual.lomitosPreparados++;
            }

            //asigno nro de pedido y agrego el pedido a la lista de pedidos
            pedido.numeroPedido = numeroPedido++;
            actual.pedidos.Add(pedido);

            return pedido;
        }


        private void simularLlegadaDePedido()
        {
            actual.evento = EVENTO_LLEGADA_DE_PEDIDO;
            actual.tiempoEntreLlegada = generarTiempoEntreLlegada();

            if (getCantidadCocinerosLibres() > 0)
            {
                Pedido pedido = generarPedido();
                prepararPedido(pedido);
            }
            else
            {
                actual.longitudColaPedido++;
            }
        }

        private void simularPedidoFinalizado(Pedido pedido)
        {
            actual.evento = EVENTO_PEDIDO_FINALIZADO + " " + pedido.numeroPedido.ToString();
            pedido.momentoFinProceso = actual.reloj;

            if(anterior.delivery.estadoServidor == EstadoServidor.libre)
            {
                //Enviar Delivery
                actual.delivery.estadoServidor = EstadoServidor.ocupado;
                actual.delivery.inicioProceso = actual.reloj;
                actual.delivery.tiempoProceso = obtenerTiempoEntregaDelivery();
            }
            else
            {
                actual.longitudColaDelivery++;
            }

            if(actual.longitudColaPedido > 0)
            {
                actual.longitudColaPedido--;
                Pedido pedidoCola = generarPedido();
                prepararPedido(pedidoCola);
            }
            else
            {
                pedido.cocinero.estadoServidor = EstadoServidor.libre;
            }
        }

        
        private void simularEntregaDePedido()
        {
            actual.evento = EVENTO_ENTREGA_DE_PEDIDO;

            if(actual.longitudColaDelivery > 0)
            {
                actual.delivery.inicioProceso = actual.reloj;
                actual.delivery.tiempoProceso = obtenerTiempoEntregaDelivery();
                actual.delivery.estadoServidor = EstadoServidor.ocupado;

                if (actual.longitudColaDelivery <= pedidosMaxDelivery)
                {                    
                    actual.longitudColaDelivery = 0;
                }
                else
                {
                    actual.longitudColaDelivery = actual.longitudColaDelivery - pedidosMaxDelivery;
                }
                
            }
            else
            {
                actual.delivery.estadoServidor = EstadoServidor.libre;
            }
        }

        private TimeSpan generarTiempoEntreLlegada()
        {
            Random rnd = new Random();

            double lambda = pedidosPorHora / 60d;

            double tiempoEntreLlegada = (-1 / lambda) * Math.Log(1 - rnd.NextDouble());

            return TimeSpan.FromMinutes(tiempoEntreLlegada);
        }

        private TimeSpan obtenerTiempoEntregaDelivery()
        {
            Random rnd = new Random();
            return TimeSpan.FromMinutes(-mediaDemoraPedido * Math.Log(1 - rnd.NextDouble()));
        }

        private int getCantidadEmpanadas()
        {
            throw new NotImplementedException();
        }

        
    }
}
