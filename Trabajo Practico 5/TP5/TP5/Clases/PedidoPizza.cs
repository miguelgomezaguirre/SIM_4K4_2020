﻿using System;
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

        public PedidoPizza(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.nombrePedido = "Pizza";
        }

        public override TimeSpan calcularTiempoDemora()
        {
            return TimeSpan.FromMinutes( a + Aleatorio.getInstancia().NextDouble() * (b - a));
        }

        public override double getPrecio()
        {
            return 250;
        }
    }
}
