using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Logica.Logicas
{
    public  class Archivo
    {

        public string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + " \\JSON ";
        public bool Escritura (string path, string objeto)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (StreamWriter writer = new StreamWriter(path , false))
            {
                writer.Write(objeto);
                return true;
            }
        }

        public string  Lectura (string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                if (!File.Exists( path))
                {
                    File.Create(path);
                }
                string json = reader.ReadToEnd();
          
                return json ;
            }
        }
    }
}
