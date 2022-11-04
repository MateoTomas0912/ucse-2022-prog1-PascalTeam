using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Logicas
{
    public class LogicaComidas : Archivo
    {
        public void EscrituraComidas(List<Comida> comidas)
        {
            string pathEscritura = "comidas.txt";

            string serialProductos = JsonConvert.SerializeObject(comidas);

            Escritura(pathEscritura, serialProductos);
        }

        public List<Comida> ObtenerComidas()
        {
            List<Comida> comidas = new List<Comida>();
            List<ComidaArchivo> comidaArchivo = LecturaComidas();
            foreach (var comida in comidaArchivo)
            {
                comida.Receta = LogicaRecetas.ObtenerRecetaComidas(comida.CodigoReceta);
                comida.NombreReceta = comida.Receta.Nombre;
                if (comida.NombreReceta == null)
                {
                    comida.NombreReceta = "Receta eliminada";
                }
                comidas.Add(comida);
            }
            return comidas;
        }

        public List<Comida> ObtenerComidas(char letra)
        {
            List<Comida> comidas = new List<Comida>();
            List<ComidaArchivo> comidaArchivo = LecturaComidas();
            foreach (var comida in comidaArchivo)
            {
                comida.Receta = LogicaRecetas.ObtenerRecetaComidas(comida.CodigoReceta);
                comida.NombreReceta = comida.Receta.Nombre;
                if (comida.NombreReceta == null)
                {
                    comida.NombreReceta = "Receta eliminada";
                }
                comidas.Add(comida);
            }
            return comidas.FindAll(x => x.Codigo[0] == letra);
        }

        public List<Comida> ObtenerComidasPorNombre(string palabra)
        {
            List<Comida> comidas = new List<Comida>();
            List<ComidaArchivo> comidaArchivo = LecturaComidas();
            foreach (var comida in comidaArchivo)
            {
                comida.Receta = LogicaRecetas.ObtenerRecetaComidas(comida.CodigoReceta);
                comida.NombreReceta = comida.Receta.Nombre;
                if (comida.NombreReceta == null)
                {
                    comida.NombreReceta = "Receta eliminada";
                }
                comidas.Add(comida);
            }
            return comidas.FindAll(x => x.NombreReceta.ToLower().StartsWith(palabra.ToLower()));
        }


        public List<Comida> ObtenerComidasSaludables()
        {
            List<Comida> comidas = new List<Comida>();
            List<ComidaArchivo> comidaArchivo = LecturaComidas();
            foreach (var comida in comidaArchivo)
            {
                comida.Receta = LogicaRecetas.ObtenerRecetaComidas(comida.CodigoReceta);
                comida.NombreReceta = comida.Receta.Nombre;
                if (comida.NombreReceta == null)
                {
                    comida.NombreReceta = "Receta eliminada";
                }
                if (comida.Receta.Saludable == true)
                {
                    comidas.Add(comida);
                }
            }
            return comidas;
        }

        public List<Comida> ObtenerComidas(DateTime dateTime)
        {
            DateTime fecha = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            List<Comida> comidas = new List<Comida>();
            List<ComidaArchivo> comidaArchivo = LecturaComidas();
            foreach (var comida in comidaArchivo)
            {
                comida.Receta = LogicaRecetas.ObtenerRecetaComidas(comida.CodigoReceta);
                comida.NombreReceta = comida.Receta.Nombre;
                if (comida.NombreReceta == null)
                {
                    comida.NombreReceta = "Receta eliminada";
                }
                comidas.Add(comida);
            }
            return comidas.FindAll(x => x.RegistroDeComida.Year == dateTime.Year &&
            x.RegistroDeComida.Month == dateTime.Month &&
            x.RegistroDeComida.Day == dateTime.Day).ToList();
        }

        public List<ComidaArchivo> LecturaComidas()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "comidas.txt";
            if (File.Exists(pathProducto))
            {
                using (StreamReader reader = new StreamReader(pathProducto))
                {

                    string json = reader.ReadToEnd();
                    List<ComidaArchivo> comidas = JsonConvert.DeserializeObject<List<ComidaArchivo>>(json);
                    return comidas;
                }
            }

            return new List<ComidaArchivo> { };
        }

        public string CrearActualizarComida(DataGridView grillaProductos, DateTime fecha)
        {
            List<Comida> comidas = ObtenerComidas();
            foreach (DataGridViewRow row in grillaProductos.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Comida comida = new Comida();
                    comida.Codigo = RandomString(10);
                    LogicaRecetas logicaRecetas = new LogicaRecetas();
                    comida.Receta = logicaRecetas.ObtenerReceta(row.Cells[1].Value.ToString());
                    comida.CodigoReceta = comida.Receta.Codigo;
                    comida.RegistroDeComida = fecha;
                    comidas.Add(comida);

                    LogicaDespensa logicaDespensa = new LogicaDespensa();
                    bool hayProductos = logicaDespensa.DescontarProductos(comida.CodigoReceta);
                    if (!hayProductos || comida.Receta.CantidadPorProducto.Count != comida.Receta.ProductosNecesarios.Count)
                    {
                        return "No hay productos suficientes";
                    }

                    EscrituraComidas(comidas);
                    return "Carga correcta";
                }
            }

            return "No se han seleccionado recetas";
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        


        
    }
}
