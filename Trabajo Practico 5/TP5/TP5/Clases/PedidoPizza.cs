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

        public int numeroPedido { get; set; }

        public double momentoInicio { get; set; }

        public double momentoLimite { get; set; }

        public override double calcularTiempoDemora()
        {
            //La pizza tiene desviacion uniforme entre 15 y 18
            Random rnd = new Random();

            return a + rnd.NextDouble() * (b - a);
        }
    }
}
