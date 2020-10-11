using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
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

        List<VectorEstado> resultados = new List<VectorEstado>();


        /***************************************************** TABLA ******************************************************/
        DataTable simulacionDiariaDataTable = new DataTable();
        DataTable simulacionesDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            reiniciarTabla(ref simulacionDiariaDataTable);
            reiniciarTabla(ref simulacionesDataTable);
        }

        private void reiniciarTabla(ref DataTable tabla)
        {
            //resultadoFinal = new DataTable();
            tabla = new DataTable();

            tabla.Columns.Add("Numero Evento");
            tabla.Columns.Add("Evento");
            tabla.Columns.Add("Reloj");
            tabla.Columns.Add("Tiempo entre llegadas");
            tabla.Columns.Add("Proxima Llegada");
            tabla.Columns.Add("Cola Pedidos");
            tabla.Columns.Add("Tiempo de proceso servidor 1");
            tabla.Columns.Add("Momento Fin Proceso servidor 1");
            tabla.Columns.Add("Estado Servidor 1");
            tabla.Columns.Add("Tiempo de proceso servidor 2");
            tabla.Columns.Add("Momento Fin Proceso servidor 2");
            tabla.Columns.Add("Estado Servidor 2");
            tabla.Columns.Add("Tiempo de proceso servidor 3");
            tabla.Columns.Add("Momento Fin Proceso servidor 3");
            tabla.Columns.Add("Estado Servidor 3");
            tabla.Columns.Add("Cola Delivery");
            tabla.Columns.Add("Tiempo Entrega");
            tabla.Columns.Add("Momento Entrega");
            tabla.Columns.Add("Estado Delivery");
            tabla.Columns.Add("Cantidad Sandwiches");
            tabla.Columns.Add("Cantidad Pizzas");
            tabla.Columns.Add("Cantidad Empanadas");
            tabla.Columns.Add("Cantidad Lomitos");
            tabla.Columns.Add("Cantidad Hamburguesas");

            tabla.Columns.Add("Tiempo Libre Cocinero 1");
            tabla.Columns.Add("Tiempo Libre Cocinero 2");
            tabla.Columns.Add("Tiempo Libre Cocinero 3");
        }

        private void agregarFila(VectorEstado actual,ref DataTable tabla)
        {
            var fila = tabla.NewRow();

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
            fila["Cantidad Sandwiches"] = actual.sandwichPreparados;
            fila["Cantidad Pizzas"] = actual.pizzasPreparadas;
            fila["Cantidad Empanadas"] = actual.empanadasPreparadas;
            fila["Cantidad Lomitos"] = actual.lomitosPreparados;
            fila["Cantidad Hamburguesas"] = actual.hamburguesasPreparados;

            fila["Tiempo Libre Cocinero 1"] = actual.cocineros[2].tiempoLibre;
            fila["Tiempo Libre Cocinero 2"] = actual.cocineros[1].tiempoLibre;
            fila["Tiempo Libre Cocinero 3"] = actual.cocineros[0].tiempoLibre;

            tabla.Rows.Add(fila);
        }
        /***************************************************** TABLA ******************************************************/

        private void generarEventoInicial()
        {
            //Para iniciar la simulacion, generamos el primer evento y calculamos la primer llegada
            actual.evento = EVENTO_INICIO_DE_SIMULACION;
            actual.tiempoEntreLlegada = generarTiempoEntreLlegada();
            actual.momentoProximaLlegada = actual.reloj + actual.tiempoEntreLlegada;
            anterior.clonar(actual);
            agregarFila(actual, ref simulacionDiariaDataTable);
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            reiniciarTabla(ref simulacionDiariaDataTable);
            actual = new VectorEstado();
            anterior = new VectorEstado();

            generarEventoInicial();

            TimeSpan tiempoProximoEvento;
            string evento = anterior.evento;
            Pedido pedidoAux;


            while (evento != EVENTO_FIN_DE_SIMULACION)
            {
                evento = getProximoEvento(out tiempoProximoEvento, out pedidoAux);

                actual.numeroEvento = anterior.numeroEvento + 1;
                actual.reloj = tiempoProximoEvento;

                actualizarTiempoLibreCocineros();

                verificarPedidosExcedidos();

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

                    case EVENTO_FIN_DE_SIMULACION:
                        actual.evento = evento;
                        actual.reloj = anterior.reloj;
                        break;

                    default:
                        break;
                }

                

                //if(esFinDeSimulacion(tiempoProximoEvento))
                //{
                //    evento = EVENTO_FIN_DE_SIMULACION;

                //    actual.evento = evento;
                //}

                // **NOTA: copio los datos de esta manera para trabajar con solo los 2 vectores en memoria y operar con el actual
                anterior.clonar(actual);

                //Thread.Sleep(0);
                agregarFila(actual, ref simulacionDiariaDataTable);
                //TODO: Hacer que terminen todos los eventos pendientes
            }




            grdResultado.DataSource = simulacionDiariaDataTable;

            //TODO: Consultar como generamos la distribucion poisson
            //actual.cantidadEmpandasPedidas = getCantidadEmpanadas();
            resultados.Add(actual);

            agregarSimulacion(actual);
        }

        private void agregarSimulacion(VectorEstado ultimaSimulacion)
        {
            grdResultados.DataSource = null;

            agregarFila(ultimaSimulacion, ref simulacionesDataTable);

            grdResultados.DataSource = simulacionesDataTable;
        }

        private void verificarPedidosExcedidos()
        {
            if(anterior.pedidos.Count > 0)
            {
                foreach (var pedido in anterior.pedidos)
                {
                    if((actual.reloj - pedido.momentoInicio) > new TimeSpan(1, 0, 0))
                    {
                        if(pedido.cocinero == null)
                        {
                            actual.pedidos.Remove(pedido);

                            if(anterior.longitudColaPedido > 0)
                                actual.longitudColaPedido--;
                        }
                    }
                }
            }
        }


        private void actualizarTiempoLibreCocineros()
        {
            foreach (var cocinero in anterior.cocineros)
            {
                if(cocinero.estadoServidor == EstadoServidor.ocupado)
                {
                    continue;
                }

                TimeSpan tiempoLibreASumar = actual.reloj - anterior.reloj;
                actual.cocineros.Where(x => x.numeroServidor == cocinero.numeroServidor).FirstOrDefault().tiempoLibre += tiempoLibreASumar;
            }
        }

        

        private bool esFinDeSimulacion(TimeSpan tiempoProximoEvento)
        {
            if(!(tiempoProximoEvento > tiempoFinSimulacion))
            {
                return false;
            }
            else
            {
                if (!(anterior.pedidos.Count() == 0))
                {
                    return false;
                }

                if (!(getCantidadCocinerosLibres() == anterior.cocineros.Count()))
                {
                    return false;
                }

                if (!(anterior.delivery.estadoServidor == EstadoServidor.libre))
                {
                    return false;
                }
            }
            

            return true;
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

            string proximoEvento = EVENTO_FIN_DE_SIMULACION;

            Servidor cocineroConMenorTiempoFinProceso = null;

            foreach (var cocinero in anterior.cocineros)
            {
                if (cocinero.estadoServidor == EstadoServidor.libre)
                {
                    continue;
                }

                proximoEvento = EVENTO_PEDIDO_FINALIZADO;

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

            if(actual.reloj <= new TimeSpan(6, 0, 0))
            {
                if (anterior.momentoProximaLlegada < proximoReloj || proximoReloj.TotalMinutes == 0)
                {
                    proximoReloj = anterior.momentoProximaLlegada;
                    proximoEvento = EVENTO_LLEGADA_DE_PEDIDO;
                }
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
            
            pedido.cocinero = cocineroConMasTiempoLibre;

            if(pedido.GetType() == typeof(PedidoSandwich))
            {
                actual.tiempoPreparacionDeSandwichPromedio = TimeSpan.FromMinutes((double)(anterior.tiempoPreparacionDeSandwichPromedio.TotalMinutes * anterior.sandwichPreparados + actual.sandwichPreparados) / (double)cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                
                if(actual.sandwichPreparados > 1)
                {
                    actual.tiempoSandwichPreparadosDesviacion = calcularVarianza(actual.sandwichPreparados, anterior.tiempoSandwichPreparadosDesviacion, actual.tiempoPreparacionDeSandwichPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                }
            }
            else if(pedido.GetType() == typeof(PedidoPizza))
            {
                actual.tiempoPreparacionDePizzaPromedio = TimeSpan.FromMinutes((double)(anterior.tiempoPreparacionDePizzaPromedio.TotalMinutes * anterior.pizzasPreparadas + actual.pizzasPreparadas) / (double)cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);

                if (actual.pizzasPreparadas > 1)
                {
                    actual.tiempoCoccionPizzaDesviacion = calcularVarianza(actual.pizzasPreparadas, anterior.tiempoCoccionPizzaDesviacion, actual.tiempoPreparacionDePizzaPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                }
            }
            else if(pedido.GetType() == typeof(PedidoEmpanadas))
            {
                actual.tiempoCoccionEmpanadasPromedio = TimeSpan.FromMinutes((double)(anterior.tiempoCoccionEmpanadasPromedio.TotalMinutes * anterior.empanadasPreparadas + actual.empanadasPreparadas) / (double)cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);

                if (actual.pizzasPreparadas > 1)
                {
                    actual.tiempoCoccionEmpanadasDesviacion = calcularVarianza(actual.empanadasPreparadas, anterior.tiempoCoccionEmpanadasDesviacion, actual.tiempoCoccionEmpanadasPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                }
            }
        }

        private Servidor obtenerCocineroMayorTiempoLibre()
        {
            //TimeSpan mayorTiempoLibre = new TimeSpan(0, 0, 0);
            bool primero = true;

            Servidor cocineroConMasTiempoLibre = null;

            List<Servidor> cocinerosLibres = anterior.cocineros.Where(x => x.estadoServidor == EstadoServidor.libre).ToList();

            TimeSpan mayorTiempoLibre;
            List<Servidor> servidoresConTiempoLibre;
            double aleatorio;

            switch (cocinerosLibres.Count)
            {
                case 1:
                    cocineroConMasTiempoLibre = cocinerosLibres.First();
                    break;

                case 2:

                    mayorTiempoLibre = cocinerosLibres.Max(x => x.tiempoLibre);

                    servidoresConTiempoLibre = cocinerosLibres.Where(x => x.tiempoLibre == mayorTiempoLibre).ToList();

                    if(servidoresConTiempoLibre.Count == 1)
                    {
                        cocineroConMasTiempoLibre = servidoresConTiempoLibre[0];
                    }
                    else
                    {
                        aleatorio = Aleatorio.getInstancia().NextDouble();

                        if (aleatorio < 0.5)
                        {
                            cocineroConMasTiempoLibre = cocinerosLibres[0];
                        }
                        else
                        {
                            cocineroConMasTiempoLibre = cocinerosLibres[1];
                        }
                    }
                   

                    break;

                case 3:

                    mayorTiempoLibre = cocinerosLibres.Max(x => x.tiempoLibre);

                    servidoresConTiempoLibre = cocinerosLibres.Where(x => x.tiempoLibre == mayorTiempoLibre).ToList();

                    if (servidoresConTiempoLibre.Count == 1)
                    {
                        cocineroConMasTiempoLibre = servidoresConTiempoLibre[0];
                    }
                    else
                    {
                        aleatorio = Aleatorio.getInstancia().NextDouble();

                        if (servidoresConTiempoLibre.Count == 2)
                        {
                            if (aleatorio < 0.5)
                            {
                                cocineroConMasTiempoLibre = cocinerosLibres[0];
                            }
                            else
                            {
                                cocineroConMasTiempoLibre = cocinerosLibres[1];
                            }
                        }
                        else
                        {
                            if (aleatorio < 0.3333)
                            {
                                cocineroConMasTiempoLibre = cocinerosLibres[0];
                            }
                            else if(aleatorio < 0.6666)
                            {
                                cocineroConMasTiempoLibre = cocinerosLibres[1];
                            }
                            else
                            {
                                cocineroConMasTiempoLibre = cocinerosLibres[2];
                            }
                        }
                    }

                    break;
                default:
                    break;
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
            Double random = Aleatorio.getInstancia().NextDouble();
            Pedido pedido;

            if (random < 0.2d)
            {
                pedido = buscarPedidoDisponible(typeof(PedidoSandwich), 1);

                if (pedido == null)
                {
                    //Genero una docena de sanguches
                    pedido = new PedidoSandwich(1, 1);
                    actual.sandwichPreparados++;
                }
                
            }
            else if (0.2d < random && random < 0.6d)
            {
                pedido = buscarPedidoDisponible(typeof(PedidoPizza), 1);

                if(pedido == null)
                {
                    //Genero un pedido pizza
                    pedido = new PedidoPizza(1, 1);
                    actual.pizzasPreparadas++;
                }
                
            }
            else if (0.6 < random && random < 0.9d)
            {
                pedido = new PedidoEmpanadas(3);

                Pedido pedidoAux = buscarPedidoDisponible(typeof(PedidoEmpanadas), pedido.getCantidad());

                //genero un pedido de empanadas
                

                if (pedidoAux == null)
                {
                    //TODO: ver como obtener la cantidad de empanadas, quiza pueda devolverla como parametro de salida
                    actual.empanadasPreparadas += pedido.getCantidad();
                }
                else
                {
                    pedido = pedidoAux;
                }

            }
            else if (0.9d < random && random < 0.95d)
            {
                pedido = buscarPedidoDisponible(typeof(PedidoHamburguesa), 1);

                if (pedido == null)
                {
                    //Genero un pedido de hamburguesas
                    pedido = new PedidoHamburguesa();
                    actual.hamburguesasPreparados++;
                }
            }
            else
            {
                pedido = buscarPedidoDisponible(typeof(PedidoLomito), 1);

                if (pedido == null)
                {
                    //Genero un pedido de lomito
                    pedido = new PedidoLomito();
                    actual.lomitosPreparados++;
                }
            }

            //asigno nro de pedido y agrego el pedido a la lista de pedidos
            pedido.numeroPedido = numeroPedido++;

            pedido.momentoInicio = actual.reloj;

            actual.pedidos.Add(pedido);

            return pedido;
        }

        private Pedido buscarPedidoDisponible(Type tipoPedido, int cantidadPedida)
        {
            foreach (var pedido in anterior.pedidos)
            {
                if(pedido.momentoLimite < actual.reloj &&  pedido.momentoFinProceso < actual.reloj)
                {
                    if(typeof(Pedido) == tipoPedido && pedido.getCantidad() == cantidadPedida)
                    {
                        return pedido;
                    }
                }
            }

            return null;
        }

        private void simularLlegadaDePedido()
        {
            actual.evento = EVENTO_LLEGADA_DE_PEDIDO;
            actual.tiempoEntreLlegada = generarTiempoEntreLlegada();
            actual.momentoProximaLlegada = actual.reloj + actual.tiempoEntreLlegada;

            Pedido pedido = generarPedido();            

            if (getCantidadCocinerosLibres() > 0)
            {
                prepararPedido(pedido);
            }
            else
            {
                actual.longitudColaPedido++;
            }

            //Estadisticas
            actual.cantidadLlegadas++;
            

            actual.tiempoEntreLlegadasPromedio = TimeSpan.FromMinutes((double)(anterior.cantidadLlegadas * anterior.tiempoEntreLlegadasPromedio.TotalMinutes + actual.tiempoEntreLlegada.TotalMinutes) / (double)actual.cantidadLlegadas);

            if(actual.cantidadLlegadas > 1)
                actual.tiempoEntreLlegadasDesviacion = TimeSpan.FromMinutes(Math.Sqrt(calcularVarianza(actual.cantidadLlegadas, anterior.tiempoEntreLlegadasDesviacion.TotalMinutes, actual.tiempoEntreLlegadasPromedio.TotalMinutes, actual.tiempoEntreLlegada.TotalMinutes)));
            //TODO:----
            //if (actual.reloj.Hours == actual.horaSimulacion)
            //{
            //    actual.cantidadPedidosPorHora++;

            //    //actual.promedioPedidosEnUnaHora = (double)(anterior.cantidadLlegadas * anterior.cantidadPedidosPorHora + actual.cantidadPedidosPorHora) / (double)actual.cantidadLlegadas;
            //}
            //else
            //{
                
            //    actual.horaSimulacion = actual.reloj.Hours;
            //    //actual.cantidadPedidosPorHora = 1;
            //    actual.promedioPedidosEnUnaHora = 1;

                
            //    //actual.promedioPedidosPorHora = anterior.horaSimulacion * anterior.promedioPedidosEnUnaHora + actual.
            //}

            
        }

        public double calcularPromedio(int n, double promedioAnterior, double cantidadActual)
        {
            double promedio = (double)((n - 1) * promedioAnterior + cantidadActual) / (double)n;

            return promedio;
        }

        public double calcularVarianza(int n, double varianzaAnterior, double promedioActual, double cantidadActual)
        {
            if(n == 1)
            {
                throw new ArgumentException();
            }

            double varianza = (n - 2) * varianzaAnterior;
            
            varianza += (((double)n / (double)(n - 1)) * Math.Pow(promedioActual - cantidadActual, 2));

            varianza = (double)varianza / (double)(n - 1);

            return varianza;
        }

        private void simularPedidoFinalizado(Pedido pedido)
        {
            actual.evento = EVENTO_PEDIDO_FINALIZADO + " " + pedido.numeroPedido.ToString();
            pedido.momentoFinProceso = actual.reloj;

            pedido.cocinero.estadoServidor = EstadoServidor.libre;

            if (anterior.delivery.estadoServidor == EstadoServidor.libre)
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
        }

        
        private void simularEntregaDePedido()
        {
            actual.evento = EVENTO_ENTREGA_DE_PEDIDO;

            //Aca puede haber entregado 1, 2 o 3 pedidos... hay que eliminarlos si no superaron la hora de espera
            foreach (var pedido in anterior.pedidos)
            {
                if(pedido.enProcesoDeEntrega && pedido.momentoLimite < actual.reloj)
                {
                    actual.pedidos.Remove(pedido);
                }
                else
                {
                    if(pedido.momentoInicio + new TimeSpan(0, 25, 0) < actual.reloj)
                    {
                        pedido.ingresoGenerado = pedido.getPrecio();
                    }
                    else
                    {
                        pedido.ingresoGenerado = 0;
                    }

                    actual.ingresosGeneradosTotal += pedido.ingresoGenerado;

                    if(typeof(PedidoHamburguesa) == pedido.GetType())
                    {
                        actual.ingresoPorHamburgesa += pedido.ingresoGenerado;
                    }
                    else if(typeof(PedidoLomito) == pedido.GetType())
                    {
                        actual.ingresoPorLomito += pedido.ingresoGenerado;
                    }

                    if (actual.pedidos.Where(x => x.numeroPedido == pedido.numeroPedido).FirstOrDefault() != null)
                        actual.pedidos.Where(x => x.numeroPedido == pedido.numeroPedido).FirstOrDefault().enProcesoDeEntrega = false;
                }
            }

            actual.cantidadEntregas++;
            actual.tiempoEntregaPromedio = TimeSpan.FromMinutes(calcularPromedio(actual.cantidadEntregas, anterior.tiempoEntregaPromedio.TotalMinutes, anterior.delivery.tiempoProceso.TotalMinutes));

            if(actual.cantidadEntregas > 1)
                actual.tiempoEntregaDesviacion = TimeSpan.FromMinutes(Math.Sqrt(calcularVarianza(actual.cantidadEntregas, Math.Pow(anterior.tiempoEntregaDesviacion.TotalMinutes,2), actual.tiempoEntregaPromedio.TotalMinutes, anterior.delivery.tiempoProceso.TotalMinutes )));

            if(anterior.longitudColaDelivery > 0)
            {
                actual.delivery.inicioProceso = actual.reloj;
                actual.delivery.tiempoProceso = obtenerTiempoEntregaDelivery();
                actual.delivery.estadoServidor = EstadoServidor.ocupado;

                if (anterior.longitudColaDelivery <= pedidosMaxDelivery)
                {                    
                    actual.longitudColaDelivery = 0;

                    for (int i = 0; i < anterior.longitudColaDelivery; i++)
                    {
                        if(actual.pedidos[i].momentoLimite > actual.reloj)
                        {
                            actual.pedidos[i].enProcesoDeEntrega = true;
                        }
                        
                    }
                }
                else
                {
                    for (int i = 0; i < actual.pedidos.Count; i++)
                    {
                        if (actual.pedidos[i].momentoLimite > actual.reloj)
                        {
                            actual.pedidos[i].enProcesoDeEntrega = true;
                        }
                    }

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
            double lambda = pedidosPorHora / 60d;

            double tiempoEntreLlegada = (-1/lambda) * Math.Log(1 - Aleatorio.getInstancia().NextDouble());

            return TimeSpan.FromMinutes(tiempoEntreLlegada);
        }

        private TimeSpan obtenerTiempoEntregaDelivery()
        {
            return TimeSpan.FromMinutes(-mediaDemoraPedido * Math.Log(1 - Aleatorio.getInstancia().NextDouble()));
        }

        private int getCantidadEmpanadas()
        {
            throw new NotImplementedException();
        }

        
    }
}
