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

        public List<Comida> LecturaComidas()
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

        public void CrearActualizarComida(Comida comida)
        {
            List<Comida> comidas = LecturaComidas();
            List<string> codigosComidas = comidas.Select(x => x.Codigo).ToList();
            if (!codigosComidas.Contains(comida.Codigo)) // crear nuevo
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

        public void EliminarComida(string codigo)
        {
            List<Comida> comidas = LecturaComidas();
            foreach (var comida in comidas)
            {
                if (comida.Codigo == codigo)
                {
                    comidas.Remove(comida);
                    EscrituraComidas(comidas);
                    break;
                }
            }
        }
    }
}
