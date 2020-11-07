using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Clases;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new PedidoPizza(100, 0.05);

            TimeSpan demora = pedido.calcularTiempoDemora();
        }
    }
}
