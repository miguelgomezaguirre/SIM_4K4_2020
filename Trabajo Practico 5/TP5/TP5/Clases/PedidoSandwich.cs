﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public class PedidoSandwich : Pedido
    {
        public PedidoSandwich(double media, double desvEstandar)
        {

        }

        public override TimeSpan calcularTiempoDemora()
        {
            throw new NotImplementedException();
        }
    }
}
