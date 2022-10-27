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
            string pathEscritura = "productos.txt";

            string serialProductos = JsonConvert.SerializeObject(despensa);

            Escritura(pathEscritura, serialProductos);
        }

        public List<Producto> LecturaDespensa()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "productos.txt";
            if (File.Exists(pathProducto))
            {
                using (StreamReader reader = new StreamReader(pathProducto))
                {

                    string json = reader.ReadToEnd();
                    List<Producto> despensa = JsonConvert.DeserializeObject<List<Producto>>(json);
                    if (despensa == null)
                    {
                        return new List<Producto>();
                    }
                    despensa = despensa.FindAll(x => x.Cantidad > 0);
                    return despensa;
                }
            }

            return new List<Producto>();
        }

        public void EliminarProducto(string codigo)
        {
            List<Producto> productosEnDespensa = LecturaDespensa();
            foreach (var prod in productosEnDespensa)
            {
                if (prod.Codigo == codigo)
                {
                    productosEnDespensa.Remove(prod);
                    EscrituraDespensa(productosEnDespensa);
                    break;
                }
            }
        }

        public void CrearActualizarDespensa(Producto producto)
        {
            List<Producto> despensa = LecturaDespensa();
            List<string> codigosEnDespensa = despensa.Select(x => x.Codigo).ToList();

            if (!codigosEnDespensa.Contains(producto.Codigo)) // crear nuevo
            {
                despensa.Add(producto);
            }
            else
            {
                foreach (var item in despensa)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.Codigo = producto.Codigo;
                        item.Cantidad = producto.Cantidad;
                        item.CantidadMinima = producto.CantidadMinima;

                        if(item.Cantidad < item.CantidadMinima)
                        {
                            LogicaSuper logicaSuper = new LogicaSuper();
                            logicaSuper.CargarLista(item);
                        }
                    }
                }
            }

            EscrituraDespensa(despensa);
        }

        public bool DescontarProductos(string codigoReceta)
        {
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            List<Receta> listaRecetas = logicaRecetas.ObtenerRecetas();
            Receta recetaElegida = listaRecetas.Find(rec => rec.Codigo == codigoReceta);

            int index = 0;
            foreach (var productoEnReceta in recetaElegida.ProductosNecesarios)
            {
                LogicaDespensa logicaDespensa = new LogicaDespensa();
                Producto productoReceta = logicaDespensa.LecturaDespensa().Find(x => x.Codigo == productoEnReceta.Codigo);
                if (productoReceta.Cantidad < recetaElegida.CantidadPorProducto[index])
                {
                    return false;
                }
                else
                {
                    productoReceta.Codigo = productoEnReceta.Codigo;
                    productoReceta.Nombre = productoEnReceta.Nombre;
                    productoReceta.Precio = productoEnReceta.Precio;
                    productoReceta.Cantidad = productoEnReceta.Cantidad - recetaElegida.CantidadPorProducto[index];
                    productoReceta.CantidadMinima = productoEnReceta.CantidadMinima;
                }
                index++;
                CrearActualizarDespensa(productoReceta);
            }
            return true;
        }
    }
}
