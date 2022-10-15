using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaComidas : Archivo
    {
        private static List<Comida> comidas = null;

        public static List<Comida> ObtenerComidas()
        {
            //Leer el JSON de Comidas
            return comidas;
        }

        internal static void CrearActualizarComida(Comida comida)
        {
            if (string.IsNullOrEmpty(comida.Codigo)) // crear nuevo
            {
                //generar codigo
                comidas.Add(comida);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var u in comidas)
                {
                    if (u.Codigo == comida.Codigo) //este quiero editar!
                    {
                        //Edicion reemplazando los datos
                        u.RecetaElegida = comida.RecetaElegida;
                        u.RegistroDeComida = comida.RegistroDeComida;
                    }
                }
            }
        }

        internal static void EliminarComida(Comida comida)
        {
            comidas.Remove(comida);
        }
    }
}
