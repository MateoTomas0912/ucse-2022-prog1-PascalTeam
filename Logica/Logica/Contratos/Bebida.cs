using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Bebida : PorCantidad
    {
        public TipoBebida TipoBebida { get; set; }

        List<Bebida> productosBebida = new List<Bebida>();

        public void CrearActualizarProducto(Bebida producto)
        {
            if (!productosBebida.Contains(producto)) // crear nuevo
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
                            Logicas.LogicaSuper.CargarLista(item);
                        }
                    }
                }
            }
        }
        public void EliminarProducto(Bebida producto)
        {
            productosBebida.RemoveAll(x => x == producto);
        }
    }
}
