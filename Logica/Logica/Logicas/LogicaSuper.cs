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
        public void VaciarLista(DataGridView grillaProductos) //Método para vaciar la lista del super
        {
            List<Producto> Supermercado = LecturaSuper();

            foreach (DataGridViewRow row in grillaProductos.Rows)
            {
                if(row.Cells[3].Value != null) //Esta chequeado
                {
                    LogicaDespensa logicaDespensa = new LogicaDespensa();
                    Producto prod = logicaDespensa.ObtenerProducto(row.Cells[0].Value.ToString());
                    prod.Cantidad = prod.Cantidad + (prod.CantidadMinima * 2);
                    logicaDespensa.CrearActualizarDespensa(prod);
                    Supermercado.RemoveAll(x => x.Codigo == prod.Codigo);
                }
            }

            //Vacio la lista
            EscribirSuper(Supermercado);
        }

        public List<Producto> FiltrarSuperIngredientes(string ingrediente)
        {
            List<Producto> productos = LecturaSuper();

            switch (ingrediente)
            {
                case "Bebidas":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Bebida).ToList();
                    
                case "Panaderia":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Panaderia).ToList();
                    
                case "Carnes":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Carne).ToList();
                    
                case "Frutas":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Fruta).ToList();
                    
                case "Hortalizas y verduras":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.HortalizasVerdura).ToList();
                    
                case "Lacteos":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Lacteo).ToList();
                    
                case "Pescados":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Pescado).ToList();
                    
                case "Quesos":
                    return productos.Where(x => x.TipoAlimento == TipoAlimento.Queso).ToList();
            }
            return productos;
        }

        public List<Producto> FiltrarSuperPrecio(string precio)
        {
            int Numero;
            List<Producto> productos = LecturaSuper();
            if (int.TryParse(precio, out Numero) == true)
            {
                return productos.Where(x => x.Precio <= Convert.ToDouble(precio)).ToList();
            }
            else
            {
                return productos;
            }
        }

        public List<Producto> FiltrarSuperCantidad(string cantidad)
        {
            int Numero;
            List<Producto> productos = LecturaSuper();
            if (int.TryParse(cantidad, out Numero) == true)
            {
                return productos.Where(x => x.Cantidad >= Convert.ToDouble(cantidad)).ToList();
            }
            else
            {
                return productos;
            }
        }

        public List<Producto> FiltrarSuperNombre(string nombre)
        {
            int Numero;
            List<Producto> productos = LecturaSuper();
            if (int.TryParse(nombre, out Numero) == false)
            {
                return productos.Where(x => x.Nombre.StartsWith(nombre)).ToList();
            }
            else
            {
                return productos;
            }
        }

        public string ObtenerCostoCompra(DataGridView grillaProductos)
        {
            int precio = 0;
            foreach (DataGridViewRow row in grillaProductos.Rows)
            {
                if(Convert.ToBoolean(row.Cells[3].Value) == true && row.Cells[3].Value != null) //Sumar
                {
                    precio = Convert.ToInt32(row.Cells[2].Value.ToString()) + precio;
                }
            }

            return precio.ToString();
        }
    }
}
