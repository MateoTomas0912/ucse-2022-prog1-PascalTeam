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

        public List<Receta> ObtenerRecetas()
        {
            List<Receta> recetas = new List<Receta>();
            List<RecetaArchivo> recetaArchivo = LecturaRecetas();
            foreach (var receta in recetaArchivo)
            {
                receta.ProductosNecesarios = ObtenerProductosReceta(receta.IngredientesCodigo);
                recetas.Add(receta);
            }
            return recetas;
        }

        public void CrearActualizarRecetas(Receta receta)
        {
            List<Receta> recetas = new List<Receta>();
            recetas = ObtenerRecetas();
            List<string> codigosRecetas = recetas.Select(x => x.Codigo).ToList();
            if (!codigosRecetas.Contains(receta.Codigo)) // crear nuevo
            {
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
            EscrituraRecetas(recetas);
        }

        public void EliminarReceta(string codigo)
        {
            List<Receta> recetasFiltradas = ObtenerRecetas();
            foreach (var receta in recetasFiltradas)
            {
                if(receta.Codigo == codigo)
                {
                    recetasFiltradas.Remove(receta);
                    EscrituraRecetas(recetasFiltradas);
                    break;
                }
            }
        }

        public void EscrituraRecetas(List<Receta> recetas)
        {
            string pathEscritura = "recetas.txt";

            string serialProductos = JsonConvert.SerializeObject(recetas);

            Escritura(pathEscritura, serialProductos);
        }

        public static List<RecetaArchivo> LecturaRecetas()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "recetas.txt";
            if (File.Exists(pathProducto))
            {
                using (StreamReader reader = new StreamReader(pathProducto))
                {

                    string json = reader.ReadToEnd();
                    List<RecetaArchivo> recetas = JsonConvert.DeserializeObject<List<RecetaArchivo>>(json);
                    if(recetas == null)
                    {
                        return new List<RecetaArchivo>();
                    }
                    return recetas;
                }
            }

            return new List<RecetaArchivo>();
        }

        public static Receta ObtenerRecetaComidas(string codigoReceta)
        {
            List<RecetaArchivo> recetas = LecturaRecetas();
            foreach (var receta in recetas)
            {
                if (receta.Codigo == codigoReceta)
                {
                    Receta recetaComida = receta;
                    return recetaComida;
                }
            }

            return new Receta();
        }
    }
}
