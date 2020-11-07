using Generadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class PedidoPizza : Pedido
    {
        double a;
        double b;
        double crudezaInicial;
        double h;

        //public PedidoPizza(double a, double b)
        //{
        //    this.a = a;
        //    this.b = b;
        //    this.nombrePedido = "Pizza";
        //}

        public PedidoPizza(double crudezaInicial, double h)
        {
            this.crudezaInicial = crudezaInicial;
            this.h = h;
            this.nombrePedido = "Pizza";
        }

        public override TimeSpan calcularTiempoDemora()
        {
            //return TimeSpan.FromMinutes( a + Aleatorio.getInstancia().NextDouble() * (b - a));
            
            double K = DistribucionesContinuas.generarUniforme(0.3, 0.8);

            double t = 0;            

            double e = crudezaInicial;

            int cont = 1;

            while (e > 0)
            {
                double k1, k2, k3, k4;

                k1 = getK1(K, e, t);

                k2 = getK2(K, e, t, k1);

                k3 = getK3(K, e, t, k2);

                k4 = getK4(K, e, t, k3);

                e = getESiguiente(e, k1, k2, k3, k4);

                t = t + h;

                cont++;
            }

            return TimeSpan.FromMinutes((h / 0.05) * cont);

        }

        

        private double getK1(double K, double e, double t)
        {
            return h * getDerivada(K, e, t);
        }

      

        private double getK2(double K, double e, double t, double k1)
        {
            return h * getDerivada(K, e + 0.5 * k1, t + 0.5 * h);
        }


        private double getK3(double K, double e, double t, double k2)
        {
            return h * getDerivada(K, e + 0.5 * k2, t + 0.5 * h);
        }


        private double getK4(double K, double e, double t, double k3)
        {
            return h * getDerivada(K, e + k3, t + h);
        }

        private double getESiguiente(double e, double k1, double k2, double k3, double k4)
        {
            return e + (k1 + 2* k2 + 2*k3 + k4)/(double) 6;
        }

        private double getDerivada(double k, double e, double t)
        {
            return -k * e - 1.99 + 0.0001 * t;
        }

        public override double getPrecio()
        {
            return 250;
        }
    }
}
