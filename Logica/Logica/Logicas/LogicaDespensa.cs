using Logica.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaDespensa : Archivo 
    {
        private List<Producto> Despensa { get; set; }


        public void LeerDespensa()
        {
            Archivo archivo = new Archivo();
            Despensa = archivo.Lectura();
        }

        public void EscribirDespensa()
        {
            Archivo archivo = new Archivo();
            string pathDespensa = "despensa.txt";
            archivo.Escritura(pathDespensa, Despensa);
        }

        public void EliminarProducto(Producto producto)
        {
            Despensa.Remove(producto);
        }

        public void CrearActualizarProducto(Producto producto)
        {
            if (!Despensa.Contains(producto)) // crear nuevo
            {
                Despensa.Add(producto);
            }
            else
            {
                //edito la panaderia que tenga el codigo
                foreach (var item in Despensa)
                {
                    if (item.Codigo == producto.Codigo) //este quiero editar!
                    {
                        item.Nombre = producto.Nombre;
                        item.Precio = producto.Precio;
                    }
                }
            }
        }
    }
}
