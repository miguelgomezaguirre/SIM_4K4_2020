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

            this.momentoProximaLlegada = actual.momentoProximaLlegada;
        }
    }
}
