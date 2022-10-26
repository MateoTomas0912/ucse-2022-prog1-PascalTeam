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

        public void EscrituraDespensa(List<Producto> despensa)
        {
            string pathEscritura ="despensa.txt";

            string serialProductos = JsonConvert.SerializeObject(despensa);

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
            List<Producto> despensa = LecturaDespensa();
            despensa.Remove(producto);
        }

        public void CrearActualizarDespensa(Producto producto)
        {
            List<Producto> despensa = LecturaDespensa();

            if (!despensa.Contains(producto)) // crear nuevo
            {
                despensa.Add(producto);
            }
            else
            {
                //edito la panaderia que tenga el codigo
                foreach (var item in despensa)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.Codigo = producto.Codigo;
                    }
                }
            }

            EscrituraDespensa(despensa);
        }
    }
}
