using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class PedidoSandwich : IPedido
    {
        public PedidoSandwich(double media, double desvEstandar)
        {

        }

        public int numeroPedido { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double calcularTiempoDemora()
        {
            throw new NotImplementedException();
        }
    }
}
