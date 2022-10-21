using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Pescado : PorPeso
    {
        List<Pescado> productosPescado = new List<Pescado>();

        public void CrearActualizarProducto(Pescado producto)
        {
            LeerPescado();
            if (!productosPescado.Contains(producto)) // crear nuevo
            {
                //generar codigo
                productosPescado.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosPescado)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                        item.PesoMinimo = producto.PesoMinimo;
                        item.Peso = producto.Peso;
                        if (item.Peso <= item.PesoMinimo) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper logicaSuper = new Logicas.LogicaSuper();
                            logicaSuper.CargarLista(item);
                        }
                    }
                }
            }
            EscrituraPescado();
        }
        public void EliminarProducto(Pescado producto)
        {
            productosPescado.RemoveAll(x => x == producto);
        }

        private void LeerPescado()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosPescado = productos.Where(x => x is Pescado).Select(x => x as Pescado).ToList();
        }

        private void EscrituraPescado()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "pescado.txt";

            string serialProductos = JsonConvert.SerializeObject(productosPescado);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
