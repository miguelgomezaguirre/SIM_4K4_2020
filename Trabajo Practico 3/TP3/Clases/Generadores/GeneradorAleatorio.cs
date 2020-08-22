using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Generadores
{
    class GeneradorAleatorio
    {
        /// <summary>
        /// Devuelve el siguiente numero a partir de los parametros recibidos con el metodo multiplicativo
        /// </summary>
        /// <param name="Xn"></param>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public double generarMultiplicativo(double Xn, double a, double m)
        {
            //Congruencial Multiplicativo
            //Xn+1 = (a * Xn) mod m (%)

            double resultado = (a * Xn) % m;

            return resultado;
        }

        /// <summary>
        /// Devuelve el siguiente numero a partir de los parametros recibidos con el metodo multiplicativo mixto
        /// </summary>
        /// <param name="Xn"></param>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double generarMixto(double Xn, double a, double m, double c)
        {
            //Congruencial Mixto
            //Xn+1 = (a*Xn + c) mod m (%)
            double resultado = (a * Xn + c) % m;

            return resultado;
        }
        
    }
}
