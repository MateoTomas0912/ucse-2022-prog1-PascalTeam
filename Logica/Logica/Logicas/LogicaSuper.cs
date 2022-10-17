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

        public static List<Producto> LecturaSuper()
        {
            //Lista supermercado se iguala al resultado de la lectura del JSON
            Archivo archivo = new Archivo();
            Supermercado = archivo.Lectura();
            return Supermercado;
        }
        public static void EscribirSuper()
        {
            Archivo archivo = new Archivo();
            string pathDespensa = "super.txt";
            archivo.Escritura(pathDespensa, Supermercado);
        }
        public static void CargarLista(Producto producto) //Este metodo va a recibir los productos que se vayan agotando en despensa
        {
            Supermercado.Add(producto);
            EscribirSuper();
        }
        public static void VaciarLista() //Método para vaciar la lista del super
        {
            Supermercado.Clear(); //Vacio la lista
            EscribirSuper();
        }
    }
}
