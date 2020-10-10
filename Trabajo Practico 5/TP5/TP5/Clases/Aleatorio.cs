using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class Aleatorio
    {
        private static Random rndUnico;

        public static Random getInstancia()
        {
            if(rndUnico == null)
            {
                rndUnico = new Random();
            }

            return rndUnico;
        }
    }
}
