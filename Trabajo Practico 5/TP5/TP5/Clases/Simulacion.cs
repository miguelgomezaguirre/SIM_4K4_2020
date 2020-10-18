using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class Simulacion
    {
        private static Simulacion instancia;

        public TimeSpan tiempoAbandonoPedido { get; set; }
        public TimeSpan tiempoDemoraLomitoHamburguesa { get; set; }

        public static Simulacion getInstancia()
        {
            if(instancia == null)
            {
                instancia = new Simulacion();
            }

            return instancia;
        }
    }
}
