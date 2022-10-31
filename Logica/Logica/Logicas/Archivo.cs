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

            List<Producto> productos = new List<Producto>();

            //Panaderia
            if (File.Exists(pathDirectorio + "panaderia.txt"))
            {
                List<Panaderia> panaderias = new List<Panaderia>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "panaderia.txt"))
                {
                    string panaderia = reader.ReadToEnd();
                    panaderias = JsonConvert.DeserializeObject<List<Panaderia>>(panaderia);
                    foreach (var producto in panaderias)
                    {
                        productos.Add(producto);
                    }
                }
            }

            //Carne
            if (File.Exists(pathDirectorio + "carne.txt"))
            {
                List<Carne> carnes = new List<Carne>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "carne.txt"))
                {
                    string carne = reader.ReadToEnd();
                    carnes = JsonConvert.DeserializeObject<List<Carne>>(carne);
                    foreach (var producto in carnes)
                    {
                        productos.Add(producto);
                    }
                }
            }


            //Bebida
            if (File.Exists(pathDirectorio + "bebida.txt"))
            {
                List<Bebida> bebidas = new List<Bebida>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "bebida.txt"))
                {
                    string bebida = reader.ReadToEnd();
                    bebidas = JsonConvert.DeserializeObject<List<Bebida>>(bebida);
                    foreach (var producto in bebidas)
                    {
                        productos.Add(producto);
                    }
                }
            }

            //Fruta
            if (File.Exists(pathDirectorio + "fruta.txt"))
            {
                List<Fruta> frutas = new List<Fruta>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "fruta.txt"))
                {

                    string fruta = reader.ReadToEnd();
                    frutas = JsonConvert.DeserializeObject<List<Fruta>>(fruta);
                    foreach (var producto in frutas)
                    {
                        productos.Add(producto);
                    }
                }
            }

            //HoratilzaVerdura
            if (File.Exists(pathDirectorio + "hortalizaverdura.txt"))
            {
                List<HortalizaVerdura> hortalizas = new List<HortalizaVerdura>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "hortalizaverdura.txt"))
                {

                    string hortaliza = reader.ReadToEnd();
                    hortalizas = JsonConvert.DeserializeObject<List<HortalizaVerdura>>(hortaliza);
                    foreach (var producto in hortalizas)
                    {
                        productos.Add(producto);
                    }
                }
            }

            //Lacteo
            if (File.Exists(pathDirectorio + "lacteo.txt"))
            {
                List<Lacteo> lacteos = new List<Lacteo>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "lacteo.txt"))
                {
                    if (File.Exists(pathDirectorio + "lacteo.txt"))
                    {
                        string lacteo = reader.ReadToEnd();
                        lacteos = JsonConvert.DeserializeObject<List<Lacteo>>(lacteo);
                        foreach (var producto in lacteos)
                        {
                            productos.Add(producto);
                        }
                    }
                }

            }

            if (File.Exists(pathDirectorio + "pescado.txt"))
            {
                //Pescado
                List<Pescado> pescados = new List<Pescado>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "pescado.txt"))
                {

                    string pescado = reader.ReadToEnd();
                    pescados = JsonConvert.DeserializeObject<List<Pescado>>(pescado);
                    foreach (var producto in pescados)
                    {
                        productos.Add(producto);
                    }
                }

            }

            //Queso
            if (File.Exists(pathDirectorio + "queso.txt"))
            {
                List<Queso> quesos = new List<Queso>();
                using (StreamReader reader = new StreamReader(pathDirectorio + "queso.txt"))
                {

                    string queso = reader.ReadToEnd();
                    quesos = JsonConvert.DeserializeObject<List<Queso>>(queso);
                    foreach (var producto in quesos)
                    {
                        productos.Add(producto);
                    }
                }

            }

            return productos;
        }

        public Producto ObtenerProducto(string codigoProducto)
        {
            List<Producto> productos = Lectura();
            return productos.Find(x => x.Codigo == codigoProducto);
        }
    }
}

