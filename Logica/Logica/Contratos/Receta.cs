using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    //Clase para generar recetas / comidas
    public class Receta
    {
        public string CodReceta { get; set; }
        public string NombreReceta { get; set; }
        public List<ProductoCantidad> ProductosEnReceta { get; set; }
        public bool EsSaludable { get; set; }
        public MomentosDelDia MomentoReceta { get; set; }
    }
}
