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
        public double momentoInicio { get; set; }
        public double momentoLimite { get { return momentoInicio + 60; } }
        public double momentoEntrega { get; set; }

        public abstract double calcularTiempoDemora();
    }
}
