using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Producto> FiltrarSuperIngredientes(string ingrediente)
        {
            List<Producto> productos = LecturaSuper();

            switch (ingrediente)
            {
                case "Bebidas":
                    return productos.Where(x => x is Bebida).Select(x => x).ToList();
                    
                case "Panaderia":
                    return productos.Where(x => x is Panaderia).Select(x => x).ToList();
                    
                case "Carnes":
                    return productos.Where(x => x is Carne).Select(x => x).ToList();
                    
                case "Frutas":
                    return productos.Where(x => x is Fruta).Select(x => x).ToList();
                    
                case "Hortalizas y Verduras":
                    return productos.Where(x => x is HortalizaVerdura).Select(x => x).ToList();
                    
                case "Lacteos":
                    return productos.Where(x => x is Lacteo).Select(x => x).ToList();
                    
                case "Pescados":
                    return productos.Where(x => x is Pescado).Select(x => x).ToList();
                    
                case "Quesos":
                    return productos.Where(x => x is Queso).Select(x => x).ToList();
            }
            return productos;
        }

        public List<Producto> FiltrarSuperPrecio(string precio)
        {
            List<Producto> productos = LecturaSuper();

            return productos.Where(x => x.Precio <= Convert.ToDouble(precio)).ToList();
        }

        public List<Producto> FiltrarSuperCantidad(string cantidad)
        {
            List<Producto> productos = LecturaSuper();

            return productos.Where(x => x.Cantidad >= Convert.ToDouble(cantidad)).ToList();
        }

        public List<Producto> FiltrarSuperNombre(string nombre)
        {
            List<Producto> productos = LecturaSuper();

            return productos.Where(x => x.Nombre.StartsWith(nombre)).ToList();
        }

        //public void ComprarAlgo(object sender, DataGridViewCellEventArgs e, string costoTotal, DataGridView grillaSupermercado)
        //{
        //    int.Parse(costoTotal);
        //    int total = 0;
        //    foreach (DataGridViewRow row in grillaSupermercado.Rows)
        //    {
        //        bool celdacheck = (bool)grillaSupermercado.Rows[e.RowIndex].Cells[3].Value;
        //        if (celdacheck)
        //        {
        //            total = int.Parse(row.Cells[2].Value.ToString()) + total;
        //        }



        //    }
        //    costoTotal = total.ToString();
        //}
    }
}
