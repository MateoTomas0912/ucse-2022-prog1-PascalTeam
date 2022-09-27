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
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<ProductoCantidad> Productos { get; set; }
        public bool Saludable { get; set; }
        public MomentosDelDia Momento { get; set; }

        //ABM de recetas

        //Descontar productos utilizados de la lista despensa si se carga como comida 
    }
}
