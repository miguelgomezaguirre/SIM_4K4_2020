﻿using System;
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

        VectorEstado resultadoSimulacionDiaria = new VectorEstado();
        /***************************************************** TABLA ******************************************************/
        DataTable simulacionDiariaDataTable = new DataTable();
        DataTable simulacionesResumenDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            reiniciarTabla(ref simulacionDiariaDataTable);
            reiniciarTablaResumen();
        }

        private void reiniciarTablaResumen()
        {
            simulacionesResumenDataTable = new DataTable();

            simulacionesResumenDataTable.Columns.Add("Numero Simulacion");

            simulacionesResumenDataTable.Columns.Add("Tiempo Promedio Libre Coccion");
            simulacionesResumenDataTable.Columns.Add("Tiempo Promedio Libre Delivery");
            simulacionesResumenDataTable.Columns.Add("Ventas Perdidas Promedio Por Dia");
            simulacionesResumenDataTable.Columns.Add("Ventas con Entrega Gratuita Por Dia");
            simulacionesResumenDataTable.Columns.Add("Valor de los Ingresos");
            simulacionesResumenDataTable.Columns.Add("Valor de las Ventas Perdidas");
            simulacionesResumenDataTable.Columns.Add("Ingreso Promedio Diario");
            simulacionesResumenDataTable.Columns.Add("Desvío Ingreso Diario");
            simulacionesResumenDataTable.Columns.Add("Numero Maximo de Ventas Perdidas");
            simulacionesResumenDataTable.Columns.Add("Tiempo Promedio en Cola");
            simulacionesResumenDataTable.Columns.Add("Tiempo de Entrega de Pedidos Promedio Desde Creacion");

            simulacionesResumenDataTable.Columns.Add("Probabilidad ingreso < 250");

            simulacionesResumenDataTable.Columns.Add("Probabilidad pedidos caidos o gratis");
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
            tabla.Columns.Add("Producto Pedido");
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

            tabla.Columns.Add("Tiempo Entre Llegadas Promedio");
            tabla.Columns.Add("Tiempo Entre Llegadas Desviacion");
            
            tabla.Columns.Add("Tiempo Preparación Sandwich Promedio");
            tabla.Columns.Add("Tiempo Preparación Sandwich Desviacion");

            tabla.Columns.Add("Tiempo Preparación Pizza Promedio");
            tabla.Columns.Add("Tiempo Preparación Pizza Desviacion");

            tabla.Columns.Add("Tiempo Cocción Empanadas Promedio");
            tabla.Columns.Add("Tiempo Cocción Empanadas Desviacion");

            tabla.Columns.Add("Tiempo de Entrega de Pedidos Promedio");
            tabla.Columns.Add("Tiempo de Entrega de Pedidos Desviacion");

            tabla.Columns.Add("Probabilidad ingreso < 250");

            tabla.Columns.Add("Probabilidad pedidos caidos o gratis");

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

            fila["Producto Pedido"] = actual.productoPedido;
            
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

            fila["Tiempo Entre Llegadas Promedio"] = actual.tiempoEntreLlegadasPromedio;
            fila["Tiempo Entre Llegadas Desviacion"] = actual.tiempoEntreLlegadasDesviacion;

            fila["Tiempo Preparación Sandwich Promedio"] = actual.tiempoPreparacionDeSandwichPromedio;
            fila["Tiempo Preparación Sandwich Desviacion"] = actual.tiempoSandwichPreparadosDesviacion;

            fila["Tiempo Preparación Pizza Promedio"] = actual.tiempoPreparacionDePizzaPromedio;
            fila["Tiempo Preparación Pizza Desviacion"] = actual.tiempoCoccionPizzaDesviacion;

            fila["Tiempo Cocción Empanadas Promedio"] = actual.tiempoCoccionEmpanadasPromedio;
            fila["Tiempo Cocción Empanadas Desviacion"] = actual.tiempoCoccionEmpanadasDesviacion;

            fila["Tiempo de Entrega de Pedidos Promedio"] = actual.tiempoEntregaPromedio;
            fila["Tiempo de Entrega de Pedidos Desviacion"] = actual.tiempoEntregaDesviacion;

            fila["Probabilidad ingreso < 250"] = actual.probabilidadIngresoMenosDe250;

            fila["Probabilidad pedidos caidos o gratis"] = actual.probabilidadPedidosCaidosOGratis;


            tabla.Rows.Add(fila);
        }

        private void agregarFilaResumen(VectorEstado simulacionFinal)
        {
            var fila = simulacionesResumenDataTable.NewRow();

            fila["Numero Simulacion"] = simulacionFinal.numeroEvento;

            fila["Tiempo Promedio Libre Coccion"] = simulacionFinal.tiempoPromedioLibreCocineros;
            fila["Tiempo Promedio Libre Delivery"] = simulacionFinal.tiempoPromedioLibreDelivery;
            fila["Ventas Perdidas Promedio Por Dia"] = "X";
            fila["Ventas con Entrega Gratuita Por Dia"] = simulacionFinal.cantidadPedidosCeroIngresos;
            fila["Valor de los Ingresos"] = simulacionFinal.ingresosGeneradosTotal;
            fila["Valor de las Ventas Perdidas"] = simulacionFinal.montoPedidosPerdidos;
            fila["Ingreso Promedio Diario"] = "X";
            fila["Desvío Ingreso Diario"] = "X";
            fila["Numero Maximo de Ventas Perdidas"] = simulacionFinal.maximoVentasPerdidas;
            fila["Tiempo Promedio en Cola"] = simulacionFinal.promedioTiempoClientesEnCola;
            fila["Tiempo de Entrega de Pedidos Promedio Desde Creacion"] = simulacionFinal.promedioTiempoEntregaDesdePedido;

            fila["Probabilidad ingreso < 250"] = simulacionFinal.probabilidadIngresoMenosDe250;

            fila["Probabilidad pedidos caidos o gratis"] = simulacionFinal.probabilidadPedidosCaidosOGratis;


            simulacionesResumenDataTable.Rows.Add(fila);
        }
        /***************************************************** TABLA ******************************************************/

        private void generarEventoInicial()
        {
            //Para iniciar la simulacion, generamos el primer evento y calculamos la primer llegada
            actual.evento = EVENTO_INICIO_DE_SIMULACION;
            actual.tiempoEntreLlegada = generarTiempoEntreLlegada();
            actual.momentoProximaLlegada = actual.reloj + actual.tiempoEntreLlegada;

            actual.numeroProximaLlegada = 1;
            actual.tiempoEntreLlegadasPromedio = actual.tiempoEntreLlegada;

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
                actual.productoPedido = "";
                evento = getProximoEvento(out tiempoProximoEvento, out pedidoAux);

                actual.numeroEvento = anterior.numeroEvento + 1;
                actual.reloj = tiempoProximoEvento;
                
                if(evento != EVENTO_FIN_DE_SIMULACION)
                    actualizarTiempoLibreServidores();

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

                getPromediosPuntoB();

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



            mostrarEstadisticas();
            


            //TODO: Consultar como generamos la distribucion poisson
            //actual.cantidadEmpandasPedidas = getCantidadEmpanadas();
            resultados.Add(actual);

            agregarSimulacion(actual);
        }

        private void getPromediosPuntoB()
        {
            actual.tiempoPromedioLibreCocineros = TimeSpan.FromMinutes(actual.cocineros.Sum(x => x.tiempoLibre.TotalMinutes) / (double)actual.cocineros.Count());
            actual.tiempoPromedioLibreDelivery = actual.delivery.tiempoLibre;
        }

        private void mostrarEstadisticas()
        {
            lstPedidosPorHora.Items.Clear();
            grdResultado.DataSource = simulacionDiariaDataTable;

            foreach (var pedidosPorHora in actual.cantidadPedidosPorHora)
            {
                lstPedidosPorHora.Items.Add("Hora: " + pedidosPorHora.Key + "   Cantidad de pedidos: " + pedidosPorHora.Value);
            }

            List<Servidor> cocineros = new List<Servidor>();
            
            cocineros.AddRange(actual.cocineros);

            cocineros = cocineros.OrderBy(x => x.tiempoLibre).ToList();

            foreach (var cocinero in cocineros)
            {
                TimeSpan tiempoOcupacion = actual.reloj - cocinero.tiempoLibre;
                lstRankingCocineros.Items.Add("Tiempo de uso cocinero " + cocinero.numeroServidor + ": " + tiempoOcupacion);
            }
            
            lblCantidadEmpanadas.Text = actual.empanadasPreparadas.ToString();
            lblCantidadHamburguesas.Text = actual.hamburguesasPreparados.ToString();
            lblCantidadLomitos.Text = actual.lomitosPreparados.ToString();
            lblCantidadPizzas.Text = actual.pizzasPreparadas.ToString();
            lblCantidadSandwich.Text = actual.sandwichPreparados.ToString();

            lblIngresoHamburguesas.Text = actual.ingresoPorHamburgesa.ToString();
            lblIngresoLomito.Text = actual.ingresoPorLomito.ToString();
        }

        private void agregarSimulacion(VectorEstado ultimaSimulacion)
        {
            ultimaSimulacion.numeroEvento = resultados.Count;
            ultimaSimulacion.maximoVentasPerdidas = ultimaSimulacion.cantidadPedidosPerdidos;
            calcularPromedioSimulacionDiaria();

            grdResultados.DataSource = null;

            int cantidadPedidosCaidosOAbandonados = ultimaSimulacion.pedidosAbandonados + ultimaSimulacion.cantidadPedidosCeroIngresos;

            if (cantidadPedidosCaidosOAbandonados >= 5)
            {
                ultimaSimulacion.probabilidadPedidosCaidosOGratis = 1;
            }

            agregarFilaResumen(ultimaSimulacion);

            grdResultados.DataSource = simulacionesResumenDataTable;

        }

        private void mostrarVectorResultado()
        {
            VectorEstado simulacionFinal = calcularPromedioSimulacionDiaria();

            agregarFilaResumen(simulacionFinal);

            grdResultados.DataSource = simulacionesResumenDataTable;
        }

       

        private VectorEstado calcularPromedioSimulacionDiaria()
        {
            double tiempoLibreCocineros = 0d;
            double tiempoLibreDelivery = 0d;
            int pedidosPerdidos = 0;
            int pedidosConCeroIngresos = 0;
            double montoPedidosPerdidos = 0;
            int maxVentasPerdidas = 0;
            double tiempoEnColas = 0d;
            double tiempoEntregaDesdePedido = 0d;
            double ingresoConMenosDe250 = 0;
            double valorIngresos = 0;
            double ventasConEntregaGratuita = 0;

            int cantidadSimulacionesCon5PedidosCaidosOAbandonados = 0;

            foreach (var simulacionIndividual in resultados)
            {
                
                tiempoLibreCocineros += simulacionIndividual.cocineros.Sum(x => x.tiempoLibre.TotalMinutes) / (double)simulacionIndividual.cocineros.Count;
                tiempoLibreDelivery += simulacionIndividual.delivery.tiempoLibre.TotalMinutes;
                pedidosPerdidos += simulacionIndividual.cantidadPedidosPerdidos;
                pedidosConCeroIngresos += simulacionIndividual.cantidadPedidosCeroIngresos;

                montoPedidosPerdidos += simulacionIndividual.montoPedidosPerdidos;
                
                if(simulacionIndividual.cantidadPedidosPerdidos > maxVentasPerdidas)
                {
                    maxVentasPerdidas = simulacionIndividual.cantidadPedidosPerdidos;
                }

                tiempoEnColas += simulacionIndividual.tiempoClientesEnCola.TotalMinutes;
                tiempoEntregaDesdePedido += simulacionIndividual.tiempoEntregaPromedio.TotalMinutes;
                ingresoConMenosDe250 += simulacionIndividual.probabilidadIngresoMenosDe250;

                int cantidadPedidosCaidosOAbandonados = simulacionIndividual.pedidosAbandonados + simulacionIndividual.cantidadPedidosCeroIngresos;

                if(cantidadPedidosCaidosOAbandonados >= 5)
                {
                    cantidadSimulacionesCon5PedidosCaidosOAbandonados++;
                }

                valorIngresos += simulacionIndividual.ingresosGeneradosTotal;

            }

            VectorEstado resultadoSimulacionTotal = new VectorEstado();

            resultadoSimulacionTotal.tiempoPromedioLibreCocineros = TimeSpan.FromMinutes(tiempoLibreCocineros / (double) resultados.Count);
            resultadoSimulacionTotal.tiempoPromedioLibreDelivery = TimeSpan.FromMinutes(tiempoLibreDelivery / (double)resultados.Count);
            resultadoSimulacionTotal.promedioPedidosPerdidos = pedidosPerdidos / (double)resultados.Count;
            resultadoSimulacionTotal.cantidadPedidosCeroIngresos = pedidosConCeroIngresos;

            resultadoSimulacionTotal.montoPedidosPerdidos = montoPedidosPerdidos;
            resultadoSimulacionTotal.maximoVentasPerdidas = maxVentasPerdidas;
            resultadoSimulacionTotal.promedioTiempoClientesEnCola = TimeSpan.FromMinutes(tiempoEnColas / (double)resultados.Count);
            resultadoSimulacionTotal.promedioTiempoEntregaDesdePedido = TimeSpan.FromMinutes(tiempoEntregaDesdePedido / (double)resultados.Count);


            resultadoSimulacionTotal.probabilidadIngresoMenosDe250 = ingresoConMenosDe250 / (double)resultados.Count;

            resultadoSimulacionTotal.probabilidadPedidosCaidosOGratis = cantidadSimulacionesCon5PedidosCaidosOAbandonados / (double)resultados.Count;

            resultadoSimulacionTotal.ingresosGeneradosTotal = valorIngresos;


            return resultadoSimulacionTotal;

            //if(resultados.Count == 2)
            //{


            //    resultadoSimulacionDiaria.tiempoPromedioLibreCocineros = TimeSpan.FromMinutes((resultados[0].cocineros.Sum(x => x.tiempoLibre.TotalMinutes) + resultados[1].cocineros.Sum(x => x.tiempoLibre.TotalMinutes)) / (double)2);
            //    resultadoSimulacionDiaria.tiempoPromedioLibreDelivery = TimeSpan.FromMinutes((resultados[0].delivery.tiempoLibre.TotalMinutes + resultados[1].delivery.tiempoLibre.TotalMinutes) / (double)2);
            //    resultadoSimulacionDiaria.promedioPedidosPerdidos = (resultados[0].cantidadPedidosPerdidos + resultados[1].cantidadPedidosPerdidos) / (double)2;
            //    resultadoSimulacionDiaria.promedioPedidosConCeroIngresos = (resultados[0].cantidadPedidosCeroIngresos + resultados[1].cantidadPedidosCeroIngresos) / (double)2;

            //    resultadoSimulacionDiaria.montoPedidosPerdidos = resultados[0].montoPedidosPerdidos + resultados[1].montoPedidosPerdidos;
            //    resultadoSimulacionDiaria.maximoVentasPerdidas = resultados[0].cantidadPedidosPerdidos > resultados[1].cantidadPedidosPerdidos ? resultados[0].cantidadPedidosPerdidos : resultados[1].cantidadPedidosPerdidos;
            //    resultadoSimulacionDiaria.promedioTiempoClientesEnCola = TimeSpan.FromMinutes((resultados[0].promedioTiempoClientesEnCola.TotalMinutes + resultados[1].promedioTiempoClientesEnCola.TotalMinutes) / (double)2);

            //    resultadoSimulacionDiaria.promedioTiempoEntregaDesdePedido = TimeSpan.FromMinutes((resultados[0].promedioTiempoEntregaDesdePedido.TotalMinutes + resultados[1].promedioTiempoEntregaDesdePedido.TotalMinutes) / (double) 2);

            //    resultadoSimulacionDiaria.probabilidadIngresoMenosDe250 = (resultados[0].probabilidadIngresoMenosDe250 + resultados[1].probabilidadIngresoMenosDe250) / (double) 2;
            //}


        }

        private void verificarPedidosExcedidos()
        {
            if(anterior.pedidos.Count > 0)
            {
                foreach (var pedido in anterior.pedidos)
                {
                    if((actual.reloj - pedido.momentoInicio) > new TimeSpan(1, 0, 0))
                    {
                        if(!pedido.abandonado)
                        {
                            actual.cantidadPedidosPerdidos++;
                            actual.montoPedidosPerdidos += pedido.getPrecio();

                            pedido.abandonado = true;
                        }
                        

                        if (pedido.cocinero == null)
                        {
                            actual.pedidos.Remove(pedido);

                            if(anterior.longitudColaPedido > 0)
                                actual.longitudColaPedido--;
                        }
                    }
                }
            }
        }


        private void actualizarTiempoLibreServidores()
        {
            TimeSpan tiempoLibreASumar = actual.reloj - anterior.reloj;

            foreach (var cocinero in anterior.cocineros)
            {
                if(cocinero.estadoServidor == EstadoServidor.ocupado)
                {
                    continue;
                }
                
                actual.cocineros.Where(x => x.numeroServidor == cocinero.numeroServidor).FirstOrDefault().tiempoLibre += tiempoLibreASumar;
            }

            if(anterior.delivery.estadoServidor == EstadoServidor.libre)
            {
                actual.delivery.tiempoLibre += tiempoLibreASumar;
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

            if(actual.reloj.Hours < 6 || anterior.cantidadLlegadas < 6)
            {
                if(anterior.momentoProximaLlegada.Hours < 6 || anterior.cantidadLlegadas < 6)
                {
                    if (anterior.momentoProximaLlegada < proximoReloj || proximoReloj.TotalMinutes == 0)
                    {
                        proximoReloj = anterior.momentoProximaLlegada;
                        proximoEvento = EVENTO_LLEGADA_DE_PEDIDO;
                    }
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

            actual.productoPedido = pedido.nombrePedido;

            if(pedido.GetType() == typeof(PedidoSandwich))
            {
                //actual.tiempoPreparacionDeSandwichPromedio = TimeSpan.FromMinutes((double)(anterior.tiempoPreparacionDeSandwichPromedio.TotalMinutes * anterior.sandwichPreparados + actual.sandwichPreparados) / (double)cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                actual.tiempoPreparacionDeSandwichPromedio = TimeSpan.FromMinutes(calcularPromedio(actual.sandwichPreparados, anterior.tiempoPreparacionDeSandwichPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes));
                
                if (actual.sandwichPreparados > 1)
                {
                    actual.tiempoSandwichPreparadosDesviacion = calcularVarianza(actual.sandwichPreparados, anterior.tiempoSandwichPreparadosDesviacion, actual.tiempoPreparacionDeSandwichPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                }
            }
            else if(pedido.GetType() == typeof(PedidoPizza))
            {
                //actual.tiempoPreparacionDePizzaPromedio = TimeSpan.FromMinutes((double)(anterior.tiempoPreparacionDePizzaPromedio.TotalMinutes * anterior.pizzasPreparadas + actual.pizzasPreparadas) / (double)cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                actual.tiempoPreparacionDePizzaPromedio = TimeSpan.FromMinutes(calcularPromedio(actual.pizzasPreparadas, anterior.tiempoPreparacionDePizzaPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes));

                if (actual.pizzasPreparadas > 1)
                {
                    actual.tiempoCoccionPizzaDesviacion = calcularVarianza(actual.pizzasPreparadas, anterior.tiempoCoccionPizzaDesviacion, actual.tiempoPreparacionDePizzaPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                }
            }
            else if(pedido.GetType() == typeof(PedidoEmpanadas))
            {
                //actual.tiempoCoccionEmpanadasPromedio = TimeSpan.FromMinutes((double)(anterior.tiempoCoccionEmpanadasPromedio.TotalMinutes * anterior.empanadasPreparadas + actual.empanadasPreparadas) / (double)cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes);
                actual.tiempoCoccionEmpanadasPromedio = TimeSpan.FromMinutes(calcularPromedio(actual.empanadasPreparadas, anterior.tiempoCoccionEmpanadasPromedio.TotalMinutes, cocineroConMasTiempoLibre.tiempoProceso.TotalMinutes));

                if (actual.empanadasPreparadas > 1)
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
            actual.cantidadLlegadas += 1;
            actual.numeroProximaLlegada += 1;

            actual.tiempoEntreLlegadasPromedio = TimeSpan.FromMinutes((double)(anterior.numeroProximaLlegada * anterior.tiempoEntreLlegadasPromedio.TotalMinutes + actual.tiempoEntreLlegada.TotalMinutes) / (double)actual.numeroProximaLlegada);

            //actual.tiempoEntregaPromedio = TimeSpan.FromMinutes(calcularPromedio(actual.cantidadLlegadas, anterior.tiempoEntreLlegadasPromedio.TotalMinutes, actual.tiempoEntreLlegada.TotalMinutes));

            if(actual.cantidadLlegadas > 1)
                actual.tiempoEntreLlegadasDesviacion = TimeSpan.FromMinutes(Math.Sqrt(calcularVarianza(actual.numeroProximaLlegada, anterior.tiempoEntreLlegadasDesviacion.TotalMinutes, actual.tiempoEntreLlegadasPromedio.TotalMinutes, actual.tiempoEntreLlegada.TotalMinutes)));

            sumarPedidosPorHora();
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

        private void sumarPedidosPorHora()
        {
            //var pedidosPorHora = actual.cantidadPedidosPorHora[actual.reloj.Hours + 1];

            if(actual.cantidadPedidosPorHora.ContainsKey(actual.reloj.Hours + 1))
            {
                actual.cantidadPedidosPorHora[actual.reloj.Hours + 1] += 1;
            }
            else
            {
                actual.cantidadPedidosPorHora.Add(actual.reloj.Hours + 1, 1);
            }

               
        }

        public double calcularPromedio(int n, double promedioAnterior, double cantidadActual)
        {
            if(n > 0)
            {
                double promedio = (double)((n - 1) * promedioAnterior + cantidadActual) / (double)n;

                return promedio;
            }

            return cantidadActual;
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

                TimeSpan tiempoEntregaDesdePedido = actual.delivery.tiempoProceso + pedido.momentoFinProceso - pedido.momentoInicio;

                actual.promedioTiempoEntregaDesdePedido = TimeSpan.FromMinutes(calcularPromedio(actual.cantidadEntregas, anterior.promedioTiempoEntregaDesdePedido.TotalMinutes, tiempoEntregaDesdePedido.TotalMinutes));
            }
            else
            {
                actual.longitudColaDelivery++;
            }

            if(actual.longitudColaPedido > 0)
            {
                actual.longitudColaPedido--;

                var pedidoConMasTiempoEnCola = actual.pedidos.Where(x => x.cocinero == null).OrderBy(x => x.momentoInicio).FirstOrDefault();

                TimeSpan tiempoEnCola = actual.reloj - pedidoConMasTiempoEnCola.momentoInicio;

                actual.cantidadClientesEnCola++;
                actual.tiempoClientesEnCola += tiempoEnCola;
                actual.promedioTiempoClientesEnCola = TimeSpan.FromMinutes(calcularPromedio(actual.cantidadClientesEnCola, anterior.promedioTiempoClientesEnCola.TotalMinutes, tiempoEnCola.TotalMinutes));

                Pedido pedidoCola = generarPedido();
                prepararPedido(pedidoCola);
            }
        }

        
        private void simularEntregaDePedido()
        {
            actual.evento = EVENTO_ENTREGA_DE_PEDIDO;

            actual.cantidadEntregas++;

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
                        actual.cantidadPedidosCeroIngresos++;
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

                if(pedido.ingresoGenerado <= 250)
                {
                    actual.cantidadEntregasMenosDe250++;
                    actual.probabilidadIngresoMenosDe250 = actual.cantidadEntregasMenosDe250 / (double)actual.cantidadEntregas;
                }
            }

            

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

        private void btnSimularDia_Click(object sender, EventArgs e)
        {
            mostrarVectorResultado();
        }
    }
}
