using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Fruta : PorCantidad
    {
        List<Fruta> productosFruta = new List<Fruta>();

        public void CrearActualizarProducto(Fruta producto)
        {
            LeerFruta();
            if (!productosFruta.Contains(producto)) // crear nuevo
            {
                //generar codigo
                productosFruta.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosFruta)
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
                            logicaSuper.EscribirSuper();
                        }
                    }
                }
            }
            EscrituraFruta();
        }
        public void EliminarProducto(Fruta producto)
        {
            productosFruta.RemoveAll(x => x == producto);
        }

        private void LeerFruta()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosFruta = productos.Where(x => x is Fruta).Select(x => x as Fruta).ToList();
        }

        private void EscrituraFruta()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "fruta.txt";

            string serialProductos = JsonConvert.SerializeObject(productosFruta);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
