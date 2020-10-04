using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public enum EstadoServidor
    {
        libre,
        ocupado
    }
    public class Servidor
    {
        public Servidor()
        {
            estadoServidor = EstadoServidor.libre;
        }

        public int numeroServidor { get; set; }
        public double inicioProceso { get; set; }

        public double tiempoProceso { get; set; }

        public EstadoServidor estadoServidor { get; set; }

        public double tiempoLibre { get; set; }
        public int numeroPedido { get; set; }

        public double finProceso()
        {
            return inicioProceso + tiempoProceso;
        }

    }
}
