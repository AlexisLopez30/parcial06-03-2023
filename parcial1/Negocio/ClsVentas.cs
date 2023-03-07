using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocio
{
    public class ClsVentas
    {
        public String Cobro(Venta ven)
        {
            double ApliDesc = ven.PreProducto * ven.CantidadProducto;

            if (ApliDesc > 50)
            {
                ven.NuevoDescue = ApliDesc - 10;
                return $"hay una promocion y todas las compras mayores a 50 reciben un descuento de 10 su total es de ${ven.NuevoDescue}";
            }
            else
            {
                return $"No aplica descuento total a pagar ${ApliDesc}";
            }
        }
    }
}
