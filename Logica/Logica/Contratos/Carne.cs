using Logica.Logicas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Logica.Contratos
{
    public class Carne : PorPeso
    {
        List<Carne> productosCarne = new List<Carne>();

        public void CrearActualizarProducto(Carne producto)
        {
            LeerCarne();
            if (!productosCarne.Contains(producto)) // crear nuevo
            {
                //generar codigo
                productosCarne.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosCarne)
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
            EscrituraCarne();
        }
        public void EliminarProducto(Carne producto)
        {
            productosCarne.RemoveAll(x => x == producto);
        }

        private void LeerCarne()
        {
            Archivo archivo = new Archivo();
            List<Producto> productos = archivo.Lectura();
            productosCarne = productos.Where(x => x is Carne).Select(x => x as Carne).ToList();
        }

        private void EscrituraCarne()
        {
            Archivo archivo = new Archivo();

            string pathEscritura = "carne.txt";

            string serialProductos = JsonConvert.SerializeObject(productosCarne);

            archivo.Escritura(pathEscritura, serialProductos);
        }
    }
}
