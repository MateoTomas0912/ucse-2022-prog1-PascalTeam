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
    public class LogicaDespensa : Archivo 
    {
        public static List<Producto> Despensa = new List<Producto>();

        public void EscrituraDespensa()
        {
            string pathEscritura ="despensa.txt";

            string serialProductos = JsonConvert.SerializeObject(Despensa);

            Escritura(pathEscritura, serialProductos);
        }

        public static List<Producto> LecturaDespensa()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "despensa.txt";
            using (StreamReader reader = new StreamReader(pathProducto))
            {
                if (!File.Exists(pathProducto))
                {
                    List<Producto> productosVacios = new List<Producto>();
                    return productosVacios;
                }
                string json = reader.ReadToEnd();
                List<Producto> despensa = JsonConvert.DeserializeObject<List<Producto>>(json);
                return despensa;
            }
        }

        public void EliminarProducto(Producto producto)
        {
            Despensa.Remove(producto);
        }

        public void CrearActualizarDespensa(Producto producto)
        {
            if (!Despensa.Contains(producto)) // crear nuevo
            {
                Despensa.Add(producto);
            }
            else
            {
                //edito la panaderia que tenga el codigo
                foreach (var item in Despensa)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.Codigo = producto.Codigo;
                    }
                }
            }
        }
    }
}
