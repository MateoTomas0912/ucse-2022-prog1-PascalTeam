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

        public void Escritura(string path, List<Producto> objeto)
        {
            string pathEscritura = pathDirectorio + path;
            string pathProductos = pathDirectorio + "productos.txt";

            if (!Directory.Exists(pathDirectorio))
            {
                Directory.CreateDirectory(pathDirectorio);
            }

            List<Panaderia> panaderia = new List<Panaderia>();

            foreach (var producto in objeto)
            {
                if (producto is Panaderia)
                {
                    panaderia.Add((Panaderia)producto);
                    string serial = JsonConvert.SerializeObject(panaderia);
                    Serializar(pathEscritura, serial);
                }
            }
            string serialProductos = JsonConvert.SerializeObject(objeto);
            Serializar(pathProductos, serialProductos);
        }

        private void Serializar(string path, string serial)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(serial);
            }
        }

        public List<Producto> Lectura()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathRenato = pathDirectorio + "productos.txt";
            using (StreamReader reader = new StreamReader(pathRenato))
            {
                if (!File.Exists(pathRenato))
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