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
                        item.Cantidad = producto.Cantidad;
                        if (item.Cantidad <= item.CantidadMinima) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper.CargarLista(item);
                        }
                    }
                }
            }
        }
        public void EliminarProducto(Fruta producto)
        {
            productosFruta.RemoveAll(x => x == producto);
        }
    }
}
