using Generadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class PedidoSandwich : Pedido
    {
        private double media { get; set; }
        private double desvEstandar { get; set; }
        public PedidoSandwich(double media, double desvEstandar)
        {
            this.media = media;
            this.desvEstandar = desvEstandar;
            this.nombrePedido = "Sandwich";
        }

        public override TimeSpan calcularTiempoDemora()
        {
            double demora = DistribucionesContinuas.generarNormal(2, media, desvEstandar)[0];

            if (demora <= 0) demora = 0.001;

            return TimeSpan.FromMinutes(demora);
        }

        public override double getPrecio()
        {
            return 500;
        }
    }
}
