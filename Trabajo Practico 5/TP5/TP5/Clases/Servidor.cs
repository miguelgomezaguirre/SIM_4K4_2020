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
        public TimeSpan inicioProceso { get; set; }

        public TimeSpan tiempoProceso { get; set; }

        public EstadoServidor estadoServidor { get; set; }

        public TimeSpan tiempoLibre { get; set; }

        public TimeSpan finProceso()
        {
            return inicioProceso.Add(tiempoProceso);
        }

    }
}
