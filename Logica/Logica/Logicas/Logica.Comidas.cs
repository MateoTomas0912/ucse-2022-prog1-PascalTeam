using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaComidas : Archivo
    {
        private static List<Comida> comidas = new List<Comida>();

        public void EscrituraComidas()
        {
            string pathEscritura = "comidas.txt";

            string serialProductos = JsonConvert.SerializeObject(comidas);

            Escritura(pathEscritura, serialProductos);
        }

        public static List<Comida> LecturaComidas()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "comidas.txt";
            using (StreamReader reader = new StreamReader(pathProducto))
            {
                if (!File.Exists(pathProducto))
                {
                    List<Comida> productosVacios = new List<Comida>();
                    return productosVacios;
                }
                string json = reader.ReadToEnd();
                List<Comida> comidas = JsonConvert.DeserializeObject<List<Comida>>(json);
                return comidas;
            }
        }

        internal static void CrearActualizarComida(Comida comida)
        {
            if (string.IsNullOrEmpty(comida.Codigo)) // crear nuevo
            {
                //generar codigo
                comidas.Add(comida);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var u in comidas)
                {
                    if (u.Codigo == comida.Codigo) //este quiero editar!
                    {
                        //Edicion reemplazando los datos
                        u.RecetaElegida = comida.RecetaElegida;
                        u.RegistroDeComida = comida.RegistroDeComida;
                    }
                }
            }
        }

        internal static void EliminarComida(Comida comida)
        {
            comidas.Remove(comida);
        }
    }
}
