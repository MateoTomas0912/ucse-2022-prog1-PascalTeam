using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaRecetas : Archivo
    {
        private static List<Receta> recetas = null;

        internal static void CrearActualizarRecetas(Receta receta)
        {
            if (string.IsNullOrEmpty(receta.Codigo)) // crear nuevo
            {
                //generar codigo
                recetas.Add(receta);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var r in recetas)
                {
                    if (r.Codigo == receta.Codigo) //este quiero editar!
                    {
                        //Edicion reemplazando los datos
                        r.Codigo = receta.Codigo;
                        r.Nombre = receta.Nombre;
                        r.Saludable = receta.Saludable;
                        r.ProductosNecesarios = receta.ProductosNecesarios;
                        r.Momento = receta.Momento;
                    }
                }
            }

            string path = "recetas.txt";
            EscrituraRecetas();
        }

        internal static void EliminarReceta(Receta receta)
        {
            recetas.Remove(receta);
            EscrituraRecetas();
        }

        public static void EscrituraRecetas()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathEscritura = pathDirectorio + "recetas.txt";

            if (!Directory.Exists(pathDirectorio))
            {
                Directory.CreateDirectory(pathDirectorio);
            }

            string serialProductos = JsonConvert.SerializeObject(recetas);

            using (StreamWriter writer = new StreamWriter(pathEscritura, false))
            {
                writer.Write(serialProductos);
            }
        }

        public static List<Receta> LecturaRecetas()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "recetas.txt";
            using (StreamReader reader = new StreamReader(pathProducto))
            {
                if (!File.Exists(pathProducto))
                {
                    List<Receta> productosVacios = new List<Receta>();
                    return productosVacios;
                }
                string json = reader.ReadToEnd();
                List<Receta> recetas = JsonConvert.DeserializeObject<List<Receta>>(json);
                return recetas;
            }
        }
    }
}
