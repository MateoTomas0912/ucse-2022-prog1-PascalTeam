using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Logica.Logicas
{
    public abstract class Archivo
    {
        private bool escribirListaPaquetes(string path, string objeto)
        {
            using (StreamWriter writer = new StreamWriter(path , false))
            {
                string serialCamiones = JsonConvert.SerializeObject(objeto);
                writer.Write(serialCamiones);
                return true;
            }
        }

        private List<string> leerListaPaquetes(string path , string objeto)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                List<string > PaquetesDesdeArchivo = JsonConvert.DeserializeObject<List<string >>(json);
                return PaquetesDesdeArchivo;
            }
        }







        public void lecturaArchivos(string path )
        {
            if (!File.Exists(path ))
            {
                camiones = leerListaCamiones();
                if (File.Exists(pathPaquetes))
                {

                    paquetes = leerListaPaquetes();
                }
            }

        }



        //Metodos para leer y escribir
    }
}
