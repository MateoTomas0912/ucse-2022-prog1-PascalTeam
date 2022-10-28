using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Panaderia : Producto
    {
        List<Panaderia> productosPanaderia = new List<Panaderia>();

        public void CrearActualizarProducto(Panaderia producto)
        {
            LeerPanaderia();
            List<string> codigos = productosPanaderia.Select(x => x.Codigo).ToList();
            if (!codigos.Contains(producto.Codigo)) // crear nuevo
            {
                //generar codigo
                productosPanaderia.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosPanaderia)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.CantidadMinima = producto.CantidadMinima;
                        item.Cantidad = producto.Cantidad;
                        if(item.Cantidad <= item.CantidadMinima) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper logicaSuper = new Logicas.LogicaSuper();
                            logicaSuper.CargarLista(item);
                        }
                    }
                }
            }

            EscrituraPanaderia();
        }

        public void EliminarProducto(Panaderia producto)
        {
            productosPanaderia.RemoveAll(x => x == producto);
            EscrituraPanaderia();
        }

        private void LeerPanaderia()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosPanaderia = productos.Where(x => x is Panaderia).Select(x => x as Panaderia).ToList();
        }

        private void EscrituraPanaderia()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "panaderia.txt";

            string serialProductos = JsonConvert.SerializeObject(productosPanaderia);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
