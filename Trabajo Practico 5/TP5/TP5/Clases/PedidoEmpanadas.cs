using Generadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    class PedidoEmpanadas : Pedido
    {       
        private int cantidadPedidas;
        private double lambda { get; set; }
        public PedidoEmpanadas(double lambda)
        {
            this.lambda = lambda;
        }
        public override TimeSpan calcularTiempoDemora()
        {
            int cantidadRestante = cantidadPedidas;

            TimeSpan demora = new TimeSpan(0, 0, 0);

            //Si son 3 empanadas la demora es 2,5 sino es 3,5
            while (cantidadRestante > 0)
            {
                if(cantidadRestante >= 3)
                {
                    demora += new TimeSpan(0, 3, 30);

                    cantidadRestante -= 3;
                }
                else
                {
                    demora += new TimeSpan(0, 2, 30);

                    cantidadRestante = 0;
                }
            }

            return demora;
        }

        public override int getCantidad()
        {
            cantidadPedidas = DistribucionesContinuas.generarRandomPoisson(lambda, 0);

            return cantidadPedidas;
        }
    }
}
