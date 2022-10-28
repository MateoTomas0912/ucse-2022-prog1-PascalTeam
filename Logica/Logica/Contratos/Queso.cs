using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Queso : Producto
    {
        List<Queso> productosQueso = new List<Queso>();

        public void CrearActualizarProducto(Queso producto)
        {
            LeerQueso();
            List<string> codigos = productosQueso.Select(x => x.Codigo).ToList();
            if (!codigos.Contains(producto.Codigo)) // crear nuevo
            {
                //generar codigo
                productosQueso.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosQueso)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.CantidadMinima = producto.CantidadMinima;
                        item.Cantidad = producto.Cantidad;
                        if (item.Cantidad <= item.CantidadMinima) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper logicaSuper = new Logicas.LogicaSuper();
                            logicaSuper.CargarLista(item);
                        }
                    }
                }
            }
            EscrituraQueso();
        }
        public void EliminarProducto(Queso producto)
        {
            productosQueso.RemoveAll(x => x == producto);
        }

        private void LeerQueso()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosQueso = productos.Where(x => x is Queso).Select(x => x as Queso).ToList();
        }

        private void EscrituraQueso()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "queso.txt";

            string serialProductos = JsonConvert.SerializeObject(productosQueso);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
