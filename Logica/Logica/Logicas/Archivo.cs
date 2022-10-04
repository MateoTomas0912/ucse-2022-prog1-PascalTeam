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
        private bool Escritura (string path, string objeto)
        {
            using (StreamWriter writer = new StreamWriter(path , false))
            {
                string Objeto  = JsonConvert.SerializeObject(objeto);
                writer.Write(Objeto);
                return true;
            }
        }

        private List<string[]> Lectura (string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                string json = reader.ReadToEnd();
                List<string[]> Objeto  = JsonConvert.DeserializeObject<List<string[]>>(json);
                return Objeto ;
            }
        }
    }
}
