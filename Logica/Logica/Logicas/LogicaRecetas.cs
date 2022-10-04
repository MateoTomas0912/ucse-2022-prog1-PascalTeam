using Logica.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Logicas
{
    public class LogicaRecetas : Archivo
    {
        private static List<Receta> recetas = null;

        public static List<Receta> ObtenerRecetas()
        {
            //Igualar recetas al resultado del json
            return recetas;
        }

        internal static void CrearActualizarRecetas(Receta receta)
        {
            if (string.IsNullOrEmpty(receta.Codigo)) // crear nuevo
            {
                //generar codigo
                recetas.Add(receta);
            }
            else
            {
                //edito el usuario que tenga el codigo
                foreach (var r in recetas)
                {
                    if (r.Codigo == receta.Codigo) //este quiero editar!
                    {
                        //Edicion reemplazando los datos
                        r.Codigo = receta.Codigo;
                        r.Nombre = receta.Nombre;
                        r.Recetas = recetas;
                        r.Saludable = receta.Saludable;
                        r.ProductosNecesarios = receta.ProductosNecesarios;
                        r.Momento = receta.Momento;
                    }
                }
            }
        }

        internal static void EliminarReceta(Receta receta)
        {
            recetas.Remove(receta);
        }
    }
}
