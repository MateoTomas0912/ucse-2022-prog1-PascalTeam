using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    //Productos con la cantidad necesaria por receta / comida
    public class ProductoCantidad : Producto
    {
        public double CantidadNecesaria { get; set; }
    }
}
