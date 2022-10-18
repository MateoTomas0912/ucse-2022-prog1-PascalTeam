﻿using System;
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
                            Logicas.LogicaSuper.CargarLista(item);
                        }
                    }
                }
            }
        }
        public void EliminarProducto(Carne producto)
        {
            productosCarne.RemoveAll(x => x == producto);
        }
    }
}
