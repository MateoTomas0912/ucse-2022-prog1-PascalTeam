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
    public class LogicaSuper : Archivo
    {
        public static List<Producto> LecturaSuper()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "super.txt";
            if (File.Exists(pathProducto))
            {
                using (StreamReader reader = new StreamReader(pathProducto))
                {

                    string json = reader.ReadToEnd();
                    List<Producto> super = JsonConvert.DeserializeObject<List<Producto>>(json);
                    if (super == null)
                    {
                        return new List<Producto>();
                    }
                    return super;
                }
            }

            return new List<Producto>();
        }
        internal void EscribirSuper(List<Producto> listaSuper)
        {
            string pathSuper = "super.txt";

            string serialProductos = JsonConvert.SerializeObject(listaSuper);

            Escritura(pathSuper, serialProductos);
        }
        public void CargarLista(Producto producto) //Este metodo va a recibir los productos que se vayan agotando en despensa
        {
            List<Producto> Supermercado = LecturaSuper();

            Supermercado.Add(producto);
            EscribirSuper(Supermercado);
        }
        public void VaciarLista() //Método para vaciar la lista del super
        {
            List<Producto> Supermercado = LecturaSuper();

            Supermercado.Clear(); //Vacio la lista
            EscribirSuper(Supermercado);
        }
    }
}
