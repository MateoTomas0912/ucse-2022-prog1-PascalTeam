using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        item.TipoAlimento = producto.TipoAlimento;

                        if(item.Cantidad <= item.CantidadMinima)
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
            if (recetaElegida.ProductosNecesarios.Count == 0) return false;

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

        public List<Producto> ObtenerProductosReceta(List<string> productos)
        {
            List<Producto> productosReceta = LecturaDespensa();
            productosReceta = productosReceta.Where(x => productos.Contains(x.Codigo)).ToList();

            List<Producto> productosConCantidad = new List<Producto>();
            foreach (var producto in productosReceta)
            {
                Producto productoReceta = new Producto();
                productoReceta.Codigo = producto.Codigo;
                productoReceta.Nombre = producto.Nombre;
                productoReceta.Precio = producto.Precio;
                productoReceta.Cantidad = producto.Cantidad;
                productoReceta.CantidadMinima = producto.CantidadMinima;
                productoReceta.TipoAlimento = producto.TipoAlimento;
                productosConCantidad.Add(productoReceta);
            }

            return productosConCantidad;
        }

        public string ValidacionCargaIngredientes(string nombre, string cantidad, string stockMinimo, string precio, string CodigoProducto, ComboBox categoriaBox)
        {
            try
            {
                int Numero;
                //Validaciones 
                if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(cantidad) && String.IsNullOrEmpty(stockMinimo) && String.IsNullOrEmpty(precio) && categoriaBox.SelectedIndex == -1)
                {
                    return "No ingresó ningún dato";
                }
                else if (String.IsNullOrEmpty(nombre) || int.TryParse(nombre, out Numero) == true)
                {
                    return "Ingrese correctamente el nombre";
                }
                else if (String.IsNullOrEmpty(cantidad) || int.TryParse(cantidad, out Numero) == false)
                {
                    return "Ingrese correctamente la cantidad";
                }
                else if (String.IsNullOrEmpty(stockMinimo) || int.TryParse(stockMinimo, out Numero) == false)
                {
                    return "Ingrese correctamente el stock minimo";
                }
                else if (String.IsNullOrEmpty(precio) || int.TryParse(precio, out Numero) == false)
                {
                    return "Ingrese correctamente el precio";
                }
                else if (categoriaBox.SelectedIndex == -1)
                {
                    return "Debe seeleccionar al menos una categoria";
                }
                else if ((nombre) == null || int.Parse(cantidad) < 0 || int.Parse(stockMinimo) < 0 || int.Parse(precio) < 0)
                {
                    return "Los valores no pueden ser negativos";
                }
                else if (int.Parse(cantidad) <= int.Parse(stockMinimo))
                {
                    return "La cantidad no puede ser menor a la cantidad minima";
                }
                else
                {
                    Producto producto = new Producto();
                    producto.Nombre = nombre;
                    if (CodigoProducto == null)
                    {
                        producto.Codigo = RandomString(10);
                    }
                    else
                    {
                        producto.Codigo = CodigoProducto;
                    }

                    producto.Precio = Convert.ToInt32(precio);
                    producto.Cantidad = Convert.ToInt32(cantidad);
                    producto.CantidadMinima = Convert.ToInt32(stockMinimo);

                    switch (categoriaBox.SelectedItem)
                    {
                        case "Hortalizas y verduras":
                            HortalizaVerdura hortalizaVerdura = new HortalizaVerdura();
                            hortalizaVerdura.Codigo = producto.Codigo;
                            hortalizaVerdura.Nombre = producto.Nombre;
                            hortalizaVerdura.Precio = producto.Precio;
                            hortalizaVerdura.CantidadMinima = producto.CantidadMinima;
                            hortalizaVerdura.Cantidad = producto.Cantidad;
                            hortalizaVerdura.CrearActualizarProducto(hortalizaVerdura);
                            producto.TipoAlimento = TipoAlimento.HortalizasVerdura;
                            break;
                        case "Frutas":
                            Fruta fruta = new Fruta();
                            fruta.Codigo = producto.Codigo;
                            fruta.Nombre = producto.Nombre;
                            fruta.Precio = producto.Precio;
                            fruta.CantidadMinima = producto.CantidadMinima;
                            fruta.Cantidad = producto.Cantidad;
                            fruta.CrearActualizarProducto(fruta);
                            producto.TipoAlimento = TipoAlimento.Fruta;
                            break;
                        case "Lacteos":
                            Lacteo lacteo = new Lacteo();
                            lacteo.Codigo = producto.Codigo;
                            lacteo.Nombre = producto.Nombre;
                            lacteo.Precio = producto.Precio;
                            lacteo.LitrosMinimos = producto.CantidadMinima;
                            lacteo.Litros = producto.Cantidad;
                            lacteo.CrearActualizarProducto(lacteo);
                            producto.TipoAlimento = TipoAlimento.Lacteo;
                            break;
                        case "Quesos":
                            Queso queso = new Queso();
                            queso.Codigo = producto.Codigo;
                            queso.Nombre = producto.Nombre;
                            queso.Precio = producto.Precio;
                            queso.CantidadMinima = producto.CantidadMinima;
                            queso.Cantidad = producto.Cantidad;
                            queso.CrearActualizarProducto(queso);
                            producto.TipoAlimento = TipoAlimento.Queso;
                            break;
                        case "Carnes":
                            Carne carne = new Carne();
                            carne.Codigo = producto.Codigo;
                            carne.Nombre = producto.Nombre;
                            carne.Precio = producto.Precio;
                            carne.CantidadMinima = producto.CantidadMinima;
                            carne.Cantidad = producto.Cantidad;
                            carne.CrearActualizarProducto(carne);
                            producto.TipoAlimento = TipoAlimento.Carne;
                            break;
                        case "Panaderia":
                            Panaderia panaderia = new Panaderia();
                            panaderia.Codigo = producto.Codigo;
                            panaderia.Nombre = producto.Nombre;
                            panaderia.Precio = producto.Precio;
                            panaderia.CantidadMinima = producto.CantidadMinima;
                            panaderia.Cantidad = producto.Cantidad;
                            panaderia.CrearActualizarProducto(panaderia);
                            producto.TipoAlimento = TipoAlimento.Panaderia;
                            break;
                        case "Pescados":
                            Pescado pescado = new Pescado();
                            pescado.Codigo = producto.Codigo;
                            pescado.Nombre = producto.Nombre;
                            pescado.Precio = producto.Precio;
                            pescado.CantidadMinima = producto.CantidadMinima;
                            pescado.Cantidad = producto.Cantidad;
                            pescado.CrearActualizarProducto(pescado);
                            producto.TipoAlimento = TipoAlimento.Pescado;
                            break;
                        case "Bebida(Normal)":
                            Bebida bebida = new Bebida();
                            bebida.Codigo = producto.Codigo;
                            bebida.Nombre = producto.Nombre;
                            bebida.Precio = producto.Precio;
                            bebida.CantidadMinima = producto.CantidadMinima;
                            bebida.Cantidad = producto.Cantidad;
                            bebida.TipoBebida = TipoBebida.Normales;
                            bebida.CrearActualizarProducto(bebida);
                            producto.TipoAlimento = TipoAlimento.Bebida;
                            break;
                        case "Bebida (Alta en azucar)":
                            Bebida bebida2 = new Bebida();
                            bebida2.Codigo = producto.Codigo;
                            bebida2.Nombre = producto.Nombre;
                            bebida2.Precio = producto.Precio;
                            bebida2.CantidadMinima = producto.CantidadMinima;
                            bebida2.Cantidad = producto.Cantidad;
                            bebida2.TipoBebida = TipoBebida.AltaEnAzucar;
                            bebida2.CrearActualizarProducto(bebida2);
                            producto.TipoAlimento = TipoAlimento.Bebida;
                            break;
                        case "Bebida (Alcoholicas)":
                            Bebida bebida3 = new Bebida();
                            bebida3.Codigo = producto.Codigo;
                            bebida3.Nombre = producto.Nombre;
                            bebida3.Precio = producto.Precio;
                            bebida3.TipoBebida = TipoBebida.Alcoholicas;
                            bebida3.CantidadMinima = producto.CantidadMinima;
                            bebida3.Cantidad = producto.Cantidad;
                            bebida3.CrearActualizarProducto(bebida3);
                            producto.TipoAlimento = TipoAlimento.Bebida;
                            break;
                    }
                    CrearActualizarDespensa(producto);
                    return "El ingrediente se cargo correctamente";
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Datos mal ingresados");
            }

            return "Error en carga";
        }
        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
