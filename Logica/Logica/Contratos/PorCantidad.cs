using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class PorCantidad : Producto
    {
        public int Cantidad { get; set; }
        public int CantidadMinima { get; set; }
    }
}
