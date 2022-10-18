using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Lacteo : Producto
    {
        public double Litros { get; set; }
        public double LitrosMinimos { get; set; }


        List<Lacteo> productosLacteo = new List<Lacteo>();

        public void CrearActualizarProducto(Lacteo producto)
        {
            if (!productosLacteo.Contains(producto)) // crear nuevo
            {
                //generar codigo
                productosLacteo.Add(producto);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var item in productosLacteo)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Litros = producto.Litros;
                        if (item.Litros <= item.LitrosMinimos) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper.CargarLista(item);
                        }
                    }
                }
            }
        }
        public void EliminarProducto(Lacteo producto)
        {
            productosLacteo.RemoveAll(x => x == producto);
        }
    }
}
