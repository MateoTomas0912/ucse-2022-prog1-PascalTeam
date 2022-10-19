using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Contratos;
using Newtonsoft.Json;

namespace Logica.Logicas
{
    public class Archivo
    {
        public string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";

        public void Escritura(string path, string serial)
        {
            string pathEscritura = pathDirectorio + path;

            if (!Directory.Exists(pathDirectorio))
            {
                Directory.CreateDirectory(pathDirectorio);
            }
            using (StreamWriter writer = new StreamWriter(pathEscritura, false))
            {
                writer.Write(serial);
            }
        }

        public List<Producto> Lectura()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "productos.txt";
            using (StreamReader reader = new StreamReader(pathProducto))
            {
                if (!File.Exists(pathProducto))
                {
                    List<Producto> productosVacios = new List<Producto>();
                    return productosVacios;
                }
                string json = reader.ReadToEnd();
                List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json);
                return productos;
            }
        }
    }
}

    