using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public enum EstadoPedido
    {
        pendientePreparacion,
        enPreparacion,
        enEntrega,
        disponible
    }
    public abstract class Pedido
    {
        public int numeroPedido { get; set; }
        public string nombrePedido { get; set; }

        private int cantidad = 1;

        public TimeSpan momentoInicio { get; set; }
        public TimeSpan momentoFinProceso { get; set; }
        public TimeSpan momentoEntrega { get; set; }
        public TimeSpan momentoLimite { get { return momentoInicio.Add(new TimeSpan(1, 0, 0)); } }
        public Servidor cocinero { get; set; }

        public bool abandonado { get; set; }

        public bool enProcesoDeEntrega { get; set; }

        public double ingresoGenerado { get; set; }


        public virtual int getCantidad()
        {
            return cantidad;
        }

        public abstract double getPrecio();

        public abstract TimeSpan calcularTiempoDemora();
    }
}
