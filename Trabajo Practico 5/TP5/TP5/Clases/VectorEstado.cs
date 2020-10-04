using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class VectorEstado : ICloneable
    {
        const string EVENTO_INICIO_DE_SIMULACION = "Inicio de simulación";
        const string EVENTO_FIN_DE_SIMULACION = "Fin de simulación";
        const string EVENTO_LLEGADA_DE_PEDIDO = "Llegada de pedido";
        const string EVENTO_PEDIDO_FINALIZADO = "Pedido Finalizado";
        const string EVENTO_ENTREGA_DE_PEDIDO = "Entrega de Pedido";
        public VectorEstado()
        {
            cocineros = new List<Servidor>();

            cocineros.Add(new Servidor { numeroServidor = 1 });
            cocineros.Add(new Servidor { numeroServidor = 2 });
            cocineros.Add(new Servidor { numeroServidor = 3 });

            delivery = new Servidor();

            pedidos = new List<Pedido>();

            numeroEvento = 0;
            evento = "";
            reloj = 0;
            tiempoEntreLlegada = 0;
            longitudColaPedido = 0;
            longitudColaDelivery = 0;
            cantidadEmpandasPedidas = 0;

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }



        public int numeroEvento { get; set; }
        public string evento { get; set; }
        public double reloj { get; set; }

        //Tiempo para la proxima llegada
        public double tiempoEntreLlegada { get; set; }
        public double momentoProximaLlegada 
        { 
            get 
            {
                return reloj + tiempoEntreLlegada;
            } 
        }

        
        public int cantidadEmpandasPedidas { get; set; }
        
        
        //Longitud de pedidos por preparar
        public int longitudColaPedido { get; set; }
        
        //Longitud de pedidos preparados sin entregar
        public int longitudColaDelivery { get; set; }

        public int pizzasPreparadas { get; set; }
        public int sandwichPreparados { get; set; }
        public int empanadasPreparadas { get; set; }
        public int lomitosPreparados { get; set; }
        public int hamburguesasPreparados { get; set; }

        public List<Servidor> cocineros { get; set; }
        public Servidor delivery { get; set; }
        public List<Pedido> pedidos { get; set; }

        
        public int getCantidadCocinerosLibres()
        {
            int contLibres = 0;

            foreach (var cocinero in cocineros)
            {
                if(cocinero.estadoServidor == EstadoServidor.libre)
                {
                    contLibres++;
                }
                
            }

            return contLibres;
        }

        

        /// <summary>
        /// Asigna el pedido de acuerdo a quien tiene mas tiempo libre o de lo contrario por igual probabilidad de los que estan libres
        /// </summary>
        internal void asignarPedido(int numeroPedido)
        {
            double maxTiempoLibre = 0;
            bool primero = true;

            Servidor cocineroConMasTiempoLibre = null;
                        
            foreach (var cocinero in cocineros)
            {
                if(cocinero.estadoServidor == EstadoServidor.ocupado)
                {
                    continue;
                }

                if(primero)
                {
                    maxTiempoLibre = cocinero.tiempoLibre;
                    cocineroConMasTiempoLibre = cocinero;
                    primero = false;
                }
                else
                {
                    if(cocinero.tiempoLibre >= maxTiempoLibre)
                    {
                        maxTiempoLibre = cocinero.tiempoLibre;
                        cocineroConMasTiempoLibre = cocinero;
                    }
                }
            }

            if(cocineroConMasTiempoLibre != null)
            {
                cocineroConMasTiempoLibre.estadoServidor = EstadoServidor.ocupado;                

                Pedido pedido = pedidos.Where(x => x.numeroPedido == numeroPedido).FirstOrDefault();

                pedido.momentoInicio = reloj;
                cocineroConMasTiempoLibre.tiempoProceso = pedido.calcularTiempoDemora();

                cocineroConMasTiempoLibre.inicioProceso = reloj;
                cocineroConMasTiempoLibre.numeroPedido = numeroPedido;
            }
        }

        /// <summary>
        /// Obtiene el proximo evento comparando los tiempos y viendo cual es el menor de ellos
        /// </summary>
        /// <returns></returns>
        internal string getProximoEvento(out double proximoReloj, out int numeroPedido)
        {
            proximoReloj = 0;
            bool primero = true;
            numeroPedido = 0;

            string proximoEvento = EVENTO_PEDIDO_FINALIZADO;

            Servidor cocineroConMenorTiempoFinProceso = null;

            foreach (var cocinero in cocineros)
            {
                if(cocinero.estadoServidor == EstadoServidor.libre)
                {
                    continue;
                }

                if(primero)
                {
                    proximoReloj = cocinero.finProceso();
                    cocineroConMenorTiempoFinProceso = cocinero;
                    numeroPedido = cocinero.numeroPedido;
                    primero = false;
                }
                else
                {
                    if(cocinero.finProceso() < proximoReloj)
                    {
                        proximoReloj = cocinero.finProceso();
                        cocineroConMenorTiempoFinProceso = cocinero;
                        numeroPedido = cocinero.numeroPedido;
                    }
                }
            }

            if(delivery != null && delivery.estadoServidor == EstadoServidor.ocupado)
            {
                if(cocineroConMenorTiempoFinProceso != null)
                {
                    if (delivery.finProceso() < proximoReloj)
                    {
                        proximoReloj = delivery.finProceso();
                        proximoEvento = EVENTO_ENTREGA_DE_PEDIDO;
                    }
                }
                else
                {
                    proximoReloj = delivery.finProceso();
                    proximoEvento = EVENTO_ENTREGA_DE_PEDIDO;
                }
                
            }

            if(momentoProximaLlegada < proximoReloj || proximoReloj == 0)
            {
                proximoReloj = momentoProximaLlegada;
                proximoEvento = EVENTO_LLEGADA_DE_PEDIDO;
            }

            return proximoEvento;
        }

        internal void liberarCocinero(int numeroPedido)
        {
            Servidor cocinero = cocineros.Where(x => x.numeroPedido == numeroPedido).FirstOrDefault();

            if(cocinero != null)
            {
                cocinero.estadoServidor = EstadoServidor.libre;
            }
        }
    }
}
