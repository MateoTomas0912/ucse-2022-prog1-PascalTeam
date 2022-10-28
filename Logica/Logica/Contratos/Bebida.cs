using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Bebida : Producto
    {
        public TipoBebida TipoBebida { get; set; }

        List<Bebida> productosBebida = new List<Bebida>();

        public void CrearActualizarProducto(Bebida producto)
        {
            LeerBebida();
            List<string> codigos = productosBebida.Select(x => x.Codigo).ToList();

            if (!codigos.Contains(producto.Codigo)) // crear nuevo
            {
                //generar codigo
                productosBebida.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosBebida)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.CantidadMinima = producto.CantidadMinima;
                        item.TipoBebida = producto.TipoBebida;
                        item.Cantidad = producto.Cantidad;
                        if (item.Cantidad <= item.CantidadMinima) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper logicaSuper = new Logicas.LogicaSuper();
                            logicaSuper.CargarLista(item);
                        }
                    }
                }
            }
            EscrituraBebida();
        }
        public void EliminarProducto(Bebida producto)
        {
            productosBebida.RemoveAll(x => x == producto);
        }

        private void LeerBebida()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosBebida = productos.Where(x => x is Bebida && x.Cantidad >= 0).Select(x => x as Bebida).ToList();
        }

        private void EscrituraBebida()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "bebida.txt";

            string serialProductos = JsonConvert.SerializeObject(productosBebida);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
