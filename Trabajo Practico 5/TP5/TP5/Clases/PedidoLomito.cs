using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    class PedidoLomito : Pedido
    {
        public override TimeSpan calcularTiempoDemora()
        {
            return new TimeSpan(0, 8, 0);
        }

        public override double getPrecio()
        {
            return 450;
        }
    }
}
