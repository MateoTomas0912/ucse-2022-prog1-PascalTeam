using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class HortalizaVerdura: Producto
    {
        List<HortalizaVerdura> productosHortalizaVerdura = new List<HortalizaVerdura>();

        public void CrearActualizarProducto(HortalizaVerdura producto)
        {
            LeerHortalizaVerdura();
            if (!productosHortalizaVerdura.Contains(producto)) // crear nuevo
            {
                //generar codigo
                productosHortalizaVerdura.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosHortalizaVerdura)
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
            EscrituraHortalizaVerdura();
        }
        public void EliminarProducto(HortalizaVerdura producto)
        {
            productosHortalizaVerdura.RemoveAll(x => x == producto);
        }

        private void LeerHortalizaVerdura()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosHortalizaVerdura = productos.Where(x => x is HortalizaVerdura).Select(x => x as HortalizaVerdura).ToList();
        }

        private void EscrituraHortalizaVerdura()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "hortalizaverdura.txt";

            string serialProductos = JsonConvert.SerializeObject(productosHortalizaVerdura);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
