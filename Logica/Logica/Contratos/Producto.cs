using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Producto 
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        //ABM de producto

        //Agregar Producto a ListaSuper si se baja de la cantidad minima
    }
}
