using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaSuper : Archivo
    {
        private List<Producto> Supermercado { get; set; }

        public List<Producto> LecturaSuper()
        {
            //Lista supermercado se iguala al resultado de la lectura del JSON
            Archivo archivo = new Archivo();
            Supermercado = archivo.Lectura();
            return Supermercado;
        }
        public void EscribirSuper()
        {
            string pathDespensa = "super.txt";

            string serialProductos = JsonConvert.SerializeObject(Supermercado);

            Escritura(pathDespensa, serialProductos);
        }
        public void CargarLista(Producto producto) //Este metodo va a recibir los productos que se vayan agotando en despensa
        {
            Supermercado.Add(producto);
            EscribirSuper();
        }
        public void VaciarLista() //Método para vaciar la lista del super
        {
            Supermercado.Clear(); //Vacio la lista
            EscribirSuper();
        }
    }
}
