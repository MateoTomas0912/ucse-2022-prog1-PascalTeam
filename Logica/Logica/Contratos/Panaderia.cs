using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Contratos
{
    public class Panaderia : PorPeso
    {
        List<Panaderia> productosPanaderia = new List<Panaderia>();

        public void CrearActualizarProducto(Panaderia producto)
        {
            if (!productosPanaderia.Contains(producto)) // crear nuevo
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
                        item.Peso = producto.Peso;
                        if(item.Peso <= item.PesoMinimo) //Lo envio a la lista del super
                        {
                            Logicas.LogicaSuper.CargarLista(item);
                        }
                    }
                }
            }
        }
    }
}
