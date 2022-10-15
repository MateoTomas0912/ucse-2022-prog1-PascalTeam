using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Logicas;
using Logica.Contratos;

namespace PantallasWinForm
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Archivo archivo = new Archivo();
            /*

             string path = "panaderia.txt";
             List<Producto> productos = new List<Producto>();    
             Panaderia panaderia = new Panaderia() { Codigo = 12, Nombre = "Pan", Peso = 14, PesoMinimo = 10, Precio = 100};
             Panaderia panaderia2 = new Panaderia() { Codigo = 14, Nombre = "Facturas", Peso = 14, PesoMinimo = 10, Precio = 100 };
             Panaderia panaderia3 = new Panaderia() { Codigo = 16, Nombre = "Alfajores negros", Peso = 14, PesoMinimo = 10, Precio = 100 };

             productos.Add(panaderia);
             productos.Add(panaderia2);
             productos.Add(panaderia3);

             archivo.Escritura(path,productos);
             */
            string path = "C:\\Users\\mtoma\\Documents\\Mateo\\Trabajos Universidad\\2do Año\\Programacion I\\ucse-2022-prog1-PascalTeam\\Logica\\PantallasWinForm\bin\\Debug\\JSON\\panaderia";
            List<Producto> list = archivo.Lectura();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
