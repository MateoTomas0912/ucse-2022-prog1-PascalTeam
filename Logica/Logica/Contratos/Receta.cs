using Newtonsoft.Json;
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
        [JsonIgnore]
        public List<Producto> ProductosNecesarios = new List<Producto>();
        public List<int> CantidadPorProducto = new List<int>();
        public bool Saludable { get; set; }
        public MomentosDelDia Momento { get; set; }
    }
}
