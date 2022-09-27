using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class PorPeso : Producto
    {
        public int Peso { get; set; }
        public int PesoMinimo { get; set; }
    }
}
