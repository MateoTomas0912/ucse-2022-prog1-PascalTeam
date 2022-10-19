using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Queso : PorPeso
    {
        List<Queso> productosQueso = new List<Queso>();

        public void CrearActualizarProducto(Queso producto)
        {
            if (!productosQueso.Contains(producto)) // crear nuevo
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
        }
        public void EliminarProducto(Queso producto)
        {
            productosQueso.RemoveAll(x => x == producto);
        }
    }
}
