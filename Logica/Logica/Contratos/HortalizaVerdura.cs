using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class HortalizaVerdura: PorCantidad
    {
        List<HortalizaVerdura> productosHortalizaVerdura = new List<HortalizaVerdura>();

        public void CrearActualizarProducto(HortalizaVerdura producto)
        {
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
                        item.Cantidad = producto.Cantidad;
                        if (item.Cantidad <= item.CantidadMinima) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper.CargarLista(item);
                        }
                    }
                }
            }
        }
        public void EliminarProducto(HortalizaVerdura producto)
        {
            productosHortalizaVerdura.RemoveAll(x => x == producto);
        }
    }
}
