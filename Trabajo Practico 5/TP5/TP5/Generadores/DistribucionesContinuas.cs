using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generadores
{
    public class DistribucionesContinuas
    {
        private static double[] vRND, vGen;
        private static Random RND = new Random();
        //private static Random rnd, r1, r2;
        private static double pi, variable, z;

        /// <summary>
        /// genera un valor aleatorio aplicando la distribucion uniforme
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static double generarUniforme(double min, double max)
        {
            return Math.Round(RND.NextDouble() * (max - min) + min, 4);
        }

        /// <summary>
        /// genera un valor aleatorio aplicando la distribucion exponencial
        /// </summary>
        /// <param name="lambda"></param>
        /// <param name="tamanioMuestra"></param>
        /// <returns></returns>
        public static double[] generarExponencial(double lambda, int tamanioMuestra)
        {
            double[] v;
            v = new double[tamanioMuestra];

            double media = 1 / lambda;

            for (int i = 0; i < v.Length; i++)
            {

                v[i] = Math.Round(-media * Math.Log(1 - RND.NextDouble()), 4);

            }

            return v;

        }

        /// <summary>
        /// genera dos valores aleatorios aplicando la distribucion normal
        /// </summary>
        /// <param name="n"></param>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        /// <returns></returns>
        public static double[] generarNormal(int n, double media, double desviacion)
        {
            pi = Math.PI;
            RND = new Random();


            double[] v;
            v = new double[n];

            int i = 0;

            while (i < v.Length)
            {
                double aux1 = RND.NextDouble() * 1;
                double aux2 = RND.NextDouble() * 1;

                double z1 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Sin(2 * pi * aux2));
                double z2 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Cos(2 * pi * aux2));

                double variable1 = media + desviacion * (z1);
                double variable2 = media + desviacion * (z2);

                v[i] = Math.Round(variable1, 4);
                v[i + 1] = Math.Round(variable2, 4);

                i = i + 2;
            }
            //for (int i = 0; i < v.Length; i + 2)
            //{
            //    double aux1 = r1.NextDouble() * 1;
            //    double aux2 = r2.NextDouble() * 1;

            //    double z1 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Sin(2 * pi * aux2));
            //    double z2 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Cos(2 * pi * aux2));

            //    double variable1 = media + desviacion * (z1);
            //    double variable2 = media + desviacion * (z2);

            //    v[i] = Math.Round(variable1, 4);
            //    v[i + 1] = Math.Round(variable2, 4);

            //}

            return v;
        }

        /// <summary>
        /// genera un valor aleatorio aplicando la distribucion Poisson
        /// </summary>
        /// <param name="lambda"></param>
        /// <param name="tamanioMuestra"></param>
        /// <returns></returns>
        public static double[] generarPoisson(double lambda, int tamanioMuestra)
        {
            double[] v;
            v = new double[tamanioMuestra];

            double p = 1;
            double x = -1;
            double u = 0;

            double a = Math.Exp(-lambda);

            for (int j = 0; j < v.Length; j++)
            {
                p = 1;
                x = 0;
                do
                {
                    u = RND.NextDouble();
                    p = p * u;

                    x++;
                } while (p >= a);

                v[j] = x;


            }
            return v;
        }

    }
}
