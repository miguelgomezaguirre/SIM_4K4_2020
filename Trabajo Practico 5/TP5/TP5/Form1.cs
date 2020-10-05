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
        const string EVENTO_INICIO_DE_SIMULACION = "Inicio de simulación";
        const string EVENTO_FIN_DE_SIMULACION = "Fin de simulación";
        const string EVENTO_LLEGADA_DE_PEDIDO = "Llegada de pedido";
        const string EVENTO_PEDIDO_FINALIZADO = "Pedido Finalizado";
        const string EVENTO_ENTREGA_DE_PEDIDO = "Entrega de Pedido";

        VectorEstado anterior = new VectorEstado();
        VectorEstado actual = new VectorEstado();

        int pedidosPorHora = 5;
        int mediaEmpanadas = 3;
        double a_pizza = 15;
        double b_pizza = 18;
        double media_demora_pedido = 3;
        double tiempo_fin_simulacion = 6 * 60;//6 horas
        int pedidosMaxDelivery = 3;

        DataTable resultadoFinal = new DataTable();
        public Form1()
        {
            InitializeComponent();

            inicializarTabla();
        }

        private void inicializarTabla()
        {
            resultadoFinal = new DataTable();

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

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            inicializarTabla();
            generarEventoInicial();

            agregarFila(actual);

            string proximoEvento = EVENTO_LLEGADA_DE_PEDIDO;
            double tiempoProximoReloj = actual.tiempoEntreLlegada;

            int numeroPedido = 0;
            int numeroPedidoAux = 0;

            while (proximoEvento != EVENTO_FIN_DE_SIMULACION)
            {
                
                anterior = (VectorEstado)actual.Clone();

                //actual = (VectorEstado)anterior.Clone();

                //actual = new VectorEstado();
                //actual.cocineros = anterior.cocineros;
                //actual.delivery = anterior.delivery;
                //actual.pedidos = anterior.pedidos;
                //actual.longitudColaDelivery = anterior.longitudColaDelivery;
                //actual.longitudColaPedido = anterior.longitudColaPedido;
                //actual.cantidadEmpandasPedidas = anterior.cantidadEmpandasPedidas;
                //actual.empanadasPreparadas = anterior.empanadasPreparadas;
                //actual.pizzasPreparadas = anterior.pizzasPreparadas;
                //actual.lomitosPreparados = anterior.lomitosPreparados;
                //actual.hamburguesasPreparados = anterior.hamburguesasPreparados;
                //actual.sandwichPreparados = anterior.sandwichPreparados;
                

                actual.numeroEvento = anterior.numeroEvento + 1;
                actual.reloj = tiempoProximoReloj;

                switch (proximoEvento)
                {
                    case EVENTO_LLEGADA_DE_PEDIDO:
                        numeroPedido++;
                        simularLlegadaDePedido(numeroPedido);

                        break;

                    case EVENTO_PEDIDO_FINALIZADO:

                        simularPedidoFinalizado(numeroPedidoAux);

                        break;

                    case EVENTO_ENTREGA_DE_PEDIDO:

                        simularEntregaDePedido(numeroPedidoAux);

                        break;
                    default:
                        break;
                }

                
                proximoEvento = actual.getProximoEvento(out tiempoProximoReloj, out numeroPedidoAux);

                if(tiempoProximoReloj > tiempo_fin_simulacion)
                {
                    proximoEvento = EVENTO_FIN_DE_SIMULACION;
                }

                VectorEstado paraImprimir = (VectorEstado)actual.Clone();

                agregarFila(paraImprimir);

                //TODO: Hacer que terminen todos los eventos pendientes
            }

            
            grdResultado.DataSource = resultadoFinal;

            //TODO: Consultar como generamos la distribucion poisson
            //actual.cantidadEmpandasPedidas = getCantidadEmpanadas();

        }

        private void agregarFila(VectorEstado vector)
        {
            string formatoDecimal = "0.0000";

            var fila = resultadoFinal.NewRow();

            fila["Numero Evento"] = vector.numeroEvento;
            fila["Evento"] = vector.evento;
            fila["Reloj"] = vector.reloj.ToString(formatoDecimal);

            if(vector.evento.Contains(EVENTO_LLEGADA_DE_PEDIDO) || vector.evento.Contains(EVENTO_INICIO_DE_SIMULACION))
            {
                fila["Tiempo entre llegadas"] = vector.tiempoEntreLlegada.ToString(formatoDecimal);
            }
            
            fila["Proxima Llegada"] = vector.momentoProximaLlegada.ToString(formatoDecimal);
            fila["Cola Pedidos"] = vector.longitudColaPedido;

            if(vector.evento.Contains(EVENTO_LLEGADA_DE_PEDIDO))
            {
                fila["Tiempo de proceso servidor 1"] = vector.cocineros[2].tiempoProceso.ToString(formatoDecimal);
                fila["Tiempo de proceso servidor 2"] = vector.cocineros[1].tiempoProceso.ToString(formatoDecimal);
                fila["Tiempo de proceso servidor 3"] = vector.cocineros[0].tiempoProceso.ToString(formatoDecimal);
            }
            
            fila["Momento Fin Proceso servidor 1"] = vector.cocineros[2].finProceso().ToString(formatoDecimal);
            fila["Estado Servidor 1"] = vector.cocineros[2].estadoServidor.ToString();
            
            fila["Momento Fin Proceso servidor 2"] = vector.cocineros[1].finProceso().ToString(formatoDecimal);
            fila["Estado Servidor 2"] = vector.cocineros[1].estadoServidor.ToString();
            
            fila["Momento Fin Proceso servidor 3"] = vector.cocineros[0].finProceso().ToString(formatoDecimal);
            fila["Estado Servidor 3"] = vector.cocineros[0].estadoServidor.ToString();

            fila["Cola Delivery"] = vector.longitudColaDelivery;

            if(vector.evento.Contains(EVENTO_PEDIDO_FINALIZADO))
            {
                fila["Tiempo Entrega"] = vector.delivery.tiempoProceso.ToString(formatoDecimal);
            }
            
            fila["Momento Entrega"] = vector.delivery.finProceso().ToString(formatoDecimal);
            fila["Estado Delivery"] = vector.delivery.estadoServidor.ToString();

            resultadoFinal.Rows.Add(fila);
        }

        private void simularLlegadaDePedido(int numeroPedido)
        {
            actual.evento = EVENTO_LLEGADA_DE_PEDIDO + " " + numeroPedido;
            actual.tiempoEntreLlegada = getTiempoEntreLlegada();
            actual.momentoProximaLlegada = actual.reloj + actual.tiempoEntreLlegada;
            
            //actual.demoraPedido = actual.pedido.calcularTiempoDemora();

            int cantidadCocinerosLibres = anterior.getCantidadCocinerosLibres();

            if (cantidadCocinerosLibres > 0)
            {
                //Trabajamos con pizzas, despues agregamos los otros
                Pedido pedido = new PedidoPizza(a_pizza, b_pizza);

                pedido.numeroPedido = numeroPedido;

                actual.pedidos.Add(pedido);
                actual.pizzasPreparadas++;
                actual.asignarPedido(numeroPedido);
            }
            else
            {
                actual.longitudColaPedido++;
            }
        }

        private void simularPedidoFinalizado(int numeroPedido)
        {
            actual.evento = EVENTO_PEDIDO_FINALIZADO + " " + numeroPedido;

            if(anterior.delivery.estadoServidor == EstadoServidor.libre)
            {
                //Liberar servidor

                //Enviar Delivery
                actual.delivery.estadoServidor = EstadoServidor.ocupado;
                actual.delivery.inicioProceso = actual.reloj;
                actual.delivery.tiempoProceso = getTiempoProcesoDelivery();
            }
            else
            {
                actual.longitudColaDelivery++;
            }

            if(actual.longitudColaPedido > 0)
            {
                actual.pedidos.Add(new PedidoPizza(a_pizza, b_pizza));
                actual.pizzasPreparadas++;

                actual.asignarPedido(numeroPedido);

                actual.longitudColaPedido--;
            }
            else
            {
                actual.liberarCocinero(numeroPedido);
            }
        }

     

        private void simularEntregaDePedido(int numeroPedido)
        {
            actual.evento = EVENTO_ENTREGA_DE_PEDIDO + " " + numeroPedido;

            if (actual.longitudColaDelivery > 0)
            {
                actual.delivery.inicioProceso = actual.reloj;
                actual.delivery.tiempoProceso = getTiempoProcesoDelivery();
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

        private void generarEventoInicial()
        {
            //Los datos iniciales estan en el constructor
            actual = new VectorEstado();

            actual.evento = EVENTO_INICIO_DE_SIMULACION;
            actual.tiempoEntreLlegada = getTiempoEntreLlegada();
            actual.momentoProximaLlegada = actual.reloj + actual.tiempoEntreLlegada;
            
        }

        private double getTiempoEntreLlegada()
        {
            Random rnd = new Random();

            double lambda = pedidosPorHora / 60d;

            double tiempoEntreLlegada = -1 / lambda * Math.Log(1 - rnd.NextDouble());

            return tiempoEntreLlegada;
        }

        private double getTiempoProcesoDelivery()
        {
            Random rnd = new Random();

            return -media_demora_pedido * Math.Log(1 - rnd.NextDouble());

        }

        private int getCantidadEmpanadas()
        {
            throw new NotImplementedException();
        }

        
    }
}
