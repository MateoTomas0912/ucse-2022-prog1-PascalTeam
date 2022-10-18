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
        public Receta(string codigo, string nombre, List<Producto> productosNecesarios, bool saludable, MomentosDelDia momento)
        {
            Codigo = codigo;
            Nombre = nombre;
            ProductosNecesarios = productosNecesarios;
            Saludable = saludable;
            Momento = momento;
        } 

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Producto> ProductosNecesarios { get; set; }
        public bool Saludable { get; set; }
        public MomentosDelDia Momento { get; set; }
    }
}
