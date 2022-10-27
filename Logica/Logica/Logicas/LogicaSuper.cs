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
        public List<Producto> LecturaSuper()
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
            List<string> codigosProductos = Supermercado.Select(x => x.Codigo).ToList();
            if (codigosProductos.Contains(producto.Codigo))
            {
                int indice = Supermercado.FindIndex(x => x.Codigo == producto.Codigo);
                Supermercado[indice].Cantidad = producto.Cantidad;
                Supermercado[indice].Codigo = producto.Codigo;
                Supermercado[indice].Nombre = producto.Nombre;
                Supermercado[indice].CantidadMinima = producto.CantidadMinima;
                Supermercado[indice].Precio = producto.Precio;
            }
            else
            {
                Supermercado.Add(producto);
            }

            EscribirSuper(Supermercado);
        }
        public void VaciarLista() //Método para vaciar la lista del super
        {
            List<Producto> Supermercado = LecturaSuper();

            //Agregar Productos a despensa
            foreach (var prod in Supermercado)
            {
                prod.Cantidad = 10;
                LogicaDespensa logicaDespensa = new LogicaDespensa();
                logicaDespensa.CrearActualizarDespensa(prod);
            }

            //Vacio la lista
            Supermercado.Clear(); 
            EscribirSuper(Supermercado);
        }

        public List<Producto> FiltrarSuper(string ingrediente)
        {
            List<Producto> productos = LecturaSuper();

            switch (ingrediente)
            {
                case ("Bebidas Normales"):
                    return productos.Where(x => x is Bebida).Select(x => x).ToList();
            }


            return productos;
        }
    }
}
