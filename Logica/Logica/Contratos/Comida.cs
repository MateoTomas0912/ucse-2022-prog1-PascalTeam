using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comida
    {
        public string Codigo { get; set; }
        public string CodigoReceta { get; set; }
        [JsonIgnore]
        public Receta Receta { get; set; }
        [JsonIgnore]
        public string NombreReceta { get; set; }
        public DateTime RegistroDeComida { get; set; }
    }
}
