using Logica.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaSuper : Archivo
    {
        private static List<Producto> Supermercado { get; set; }

        public static List<Producto> ObtenerListaSupermercado()
        {
            //Lista supermercado se iguala al resultado de la lectura del JSON
            Archivo archivo = new Archivo();
            Supermercado = archivo.Lectura();
            return Supermercado;
        }
        public bool CargarLista(Producto producto) //Este metodo va a recibir los productos que se vayan agotando en despensa
        {
            Supermercado.Add(producto);
            return true; 
        }
        public bool VaciarLista() //Método para vaciar la lista del super
        {
            Supermercado.Clear(); //Vacio la lista
            return true;           
        }
    }
}
