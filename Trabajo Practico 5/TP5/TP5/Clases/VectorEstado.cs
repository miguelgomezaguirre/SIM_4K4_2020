using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class VectorEstado
    {

        public int numeroEvento { get; set; }
        public string evento { get; set; }
        public TimeSpan reloj { get; set; }
        //Tiempo para la proxima llegada
        public TimeSpan tiempoEntreLlegada { get; set; }

        public List<Servidor> cocineros { get; set; }
        public Servidor delivery { get; set; }
        public List<Pedido> pedidos { get; set; }


        public TimeSpan momentoProximaLlegada { get; set; }

        //**COLAS**
        //Longitud de pedidos por preparar
        public int longitudColaPedido { get; set; }
        //Longitud de pedidos preparados sin entregar
        public int longitudColaDelivery { get; set; }

        //acumuladores
        public int pizzasPreparadas { get; set; }
        public int sandwichPreparados { get; set; }
        public int empanadasPreparadas { get; set; }
        public int lomitosPreparados { get; set; }
        public int hamburguesasPreparados { get; set; }
        public int cantidadEmpandasPedidas { get; set; }

        public int pedidosAbandonados { get; set; }

        public double ingresosGeneradosTotal { get; set; }


        //ESTADISTICAS
        public int cantidadLlegadas { get; set; }
        public int numeroProximaLlegada { get; set; }
        public TimeSpan tiempoEntreLlegadasPromedio { get; set; }
        public TimeSpan tiempoEntreLlegadasDesviacion { get; set; }

        public int horaSimulacion { get; set; }
        
                
        public TimeSpan tiempoPreparacionDeSandwichPromedio { get; set; }

        public double tiempoSandwichPreparadosDesviacion { get; set; }

        public TimeSpan tiempoPreparacionDePizzaPromedio { get; set; }

        public double tiempoCoccionPizzaDesviacion { get; set; }

        public TimeSpan tiempoCoccionEmpanadasPromedio { get; set; }

        public double tiempoCoccionEmpanadasDesviacion { get; set; }

        public double ingresoPorHamburgesa { get; set; }
        public double ingresoPorLomito { get; set; }

        public int cantidadEntregas { get; set; }
        public TimeSpan tiempoEntregaPromedio { get; set; }
        public TimeSpan tiempoEntregaDesviacion { get; set; }

        public Dictionary<int, int> cantidadPedidosPorHora { get; set; }

        public string productoPedido { get; set; }

        public TimeSpan tiempoPromedioLibreCocineros { get; set; }
        public TimeSpan tiempoPromedioLibreDelivery { get; set; }

        public double montoPedidosPerdidos { get; set; }
        public int cantidadPedidosPerdidos { get; set; }
        public int cantidadPedidosCeroIngresos { get; set; }
        public double promedioPedidosPerdidos { get; set; }
        public double promedioPedidosConCeroIngresos { get; set; }

        public int maximoVentasPerdidas { get; set; }

        public TimeSpan tiempoClientesEnCola { get; set; }
        public int cantidadClientesEnCola { get; set; }
        public TimeSpan promedioTiempoClientesEnCola { get; set; }

        public TimeSpan promedioTiempoEntregaDesdePedido { get; set; }

        public int cantidadEntregasMenosDe250 { get; set; }

        public double probabilidadIngresoMenosDe250 { get; set; }

        public double probabilidadPedidosCaidosOGratis { get; set; }
        public VectorEstado()
        {
            reloj = new TimeSpan(0, 0, 0);
            tiempoEntreLlegada = new TimeSpan(0,0,0);
            cocineros = new List<Servidor>();
            cocineros.Add(new Servidor { numeroServidor = 1 });
            cocineros.Add(new Servidor { numeroServidor = 2 });
            cocineros.Add(new Servidor { numeroServidor = 3 });
            delivery = new Servidor();
            pedidos = new List<Pedido>();

            horaSimulacion = 0;

            cantidadPedidosPorHora = new Dictionary<int, int>();

            productoPedido = "";
        }


        public void clonar(VectorEstado actual)
        {
            this.numeroEvento = actual.numeroEvento;
            this.evento = actual.evento;
            this.reloj = actual.reloj;
            this.tiempoEntreLlegada = actual.tiempoEntreLlegada;
            this.longitudColaPedido = actual.longitudColaPedido;
            this.longitudColaDelivery = actual.longitudColaDelivery;
            this.pizzasPreparadas = actual.pizzasPreparadas;
            this.sandwichPreparados = actual.sandwichPreparados;
            this.empanadasPreparadas = actual.empanadasPreparadas;
            this.lomitosPreparados = actual.lomitosPreparados;
            this.hamburguesasPreparados = actual.hamburguesasPreparados;
            //this.pedidos = actual.pedidos;

            this.cocineros = actual.cocineros;
            this.delivery = actual.delivery;
            this.pedidos = new List<Pedido>();
            this.pedidos.AddRange(actual.pedidos);
            this.cantidadLlegadas = actual.cantidadLlegadas;

            this.momentoProximaLlegada = actual.momentoProximaLlegada;

            this.numeroProximaLlegada = actual.numeroProximaLlegada;
            this.cantidadLlegadas = actual.cantidadLlegadas;
            this.tiempoEntreLlegadasPromedio = actual.tiempoEntreLlegadasPromedio;
            this.tiempoEntreLlegadasDesviacion = actual.tiempoEntreLlegadasDesviacion;

            this.horaSimulacion = actual.horaSimulacion;

            this.tiempoPreparacionDeSandwichPromedio = actual.tiempoPreparacionDeSandwichPromedio;
            this.tiempoSandwichPreparadosDesviacion = actual.tiempoSandwichPreparadosDesviacion;
            this.tiempoPreparacionDePizzaPromedio = actual.tiempoPreparacionDePizzaPromedio;
            this.tiempoCoccionPizzaDesviacion = actual.tiempoCoccionPizzaDesviacion;
            this.tiempoCoccionEmpanadasPromedio = actual.tiempoCoccionEmpanadasPromedio;
            this.tiempoCoccionEmpanadasDesviacion = actual.tiempoCoccionEmpanadasDesviacion;
            this.ingresoPorHamburgesa = actual.ingresoPorHamburgesa;
            this.ingresoPorLomito = actual.ingresoPorLomito;
            this.cantidadEntregas = actual.cantidadEntregas;
            this.tiempoEntregaPromedio = actual.tiempoEntregaPromedio;
            this.tiempoEntregaDesviacion = actual.tiempoEntregaDesviacion;
            this.cantidadPedidosPorHora = actual.cantidadPedidosPorHora;
            this.cantidadPedidosPerdidos = actual.cantidadPedidosPerdidos;
            this.cantidadPedidosCeroIngresos = actual.cantidadPedidosCeroIngresos;

            this.cantidadClientesEnCola = actual.cantidadClientesEnCola;
            this.tiempoClientesEnCola = actual.tiempoClientesEnCola;
            this.promedioTiempoClientesEnCola = actual.promedioTiempoClientesEnCola;

            this.promedioTiempoEntregaDesdePedido = actual.promedioTiempoEntregaDesdePedido;

            this.cantidadEntregasMenosDe250 = actual.cantidadEntregasMenosDe250;
            this.probabilidadIngresoMenosDe250 = actual.probabilidadIngresoMenosDe250;

            this.probabilidadPedidosCaidosOGratis = actual.probabilidadPedidosCaidosOGratis;

            this.productoPedido = "";
    }
    }
}
