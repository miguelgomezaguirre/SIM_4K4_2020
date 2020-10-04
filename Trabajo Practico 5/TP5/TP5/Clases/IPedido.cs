using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Clases
{
    public enum Producto
    {
        sandwich,
        pizza,
        empanadas,
        hamburguesa,
        lomito
    }
    public interface IPedido
    {
        double calcularTiempoDemora();
    }
}
