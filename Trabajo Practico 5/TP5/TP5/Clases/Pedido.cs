using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public abstract class Pedido
    {
        public int numeroPedido { get; set; }
        public TimeSpan momentoInicio { get; set; }
        public TimeSpan momentoFinProceso { get; set; }
        public TimeSpan momentoEntrega { get; set; }
        public TimeSpan momentoLimite { get { return momentoInicio.Add(new TimeSpan(1, 0, 0)); } }
        public Servidor cocinero { get; set; }

        public abstract TimeSpan calcularTiempoDemora();
    }
}
