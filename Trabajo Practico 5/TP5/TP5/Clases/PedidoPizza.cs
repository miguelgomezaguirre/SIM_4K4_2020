using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class PedidoPizza : Pedido
    {
        double a;
        double b;

        public PedidoPizza(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override TimeSpan calcularTiempoDemora()
        {
            Random rnd = new Random();
            return TimeSpan.FromMinutes( a + rnd.NextDouble() * (b - a));
        }
    }
}
