using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    public class Venta
    {
        public int IdProducto { get; set; }
        public String? NomProducto { get; set; }
        public String? DescripProducto { get; set; }
        public double PreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public double NuevoDescue { get; set; }
    }
}
