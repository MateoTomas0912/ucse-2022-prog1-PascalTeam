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
                if(comida.NombreReceta == null)
                {
                    comida.NombreReceta = "Receta eliminada";
                }
                comidas.Add(comida);
            }
            return comidas;
        }

        public List<Comida> ObtenerComidas(string dateTime)
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
            return comidas.FindAll(x => x.RegistroDeComida.ToString() == dateTime).ToList();
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

        public void CrearActualizarComida(ComidaArchivo comida)
        {
            List<Comida> comidas = ObtenerComidas();
            List<string> codigosComidas = comidas.Select(x => x.Codigo).ToList();
            if (!codigosComidas.Contains(comida.Codigo))
            {
                comidas.Add(comida);
            }
            else
            {
                foreach (var u in comidas)
                {
                    if (u.Codigo == comida.Codigo)
                    {
                        u.Receta = comida.Receta;
                        u.RegistroDeComida = comida.RegistroDeComida;
                    }
                }
            }

            EscrituraComidas(comidas);
        }
    }
}
