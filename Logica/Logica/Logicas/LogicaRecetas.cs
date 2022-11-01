using Logica.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Logicas
{
    public class LogicaRecetas : Archivo
    {

        public List<Receta> ObtenerRecetas()
        {
            List<Receta> recetas = new List<Receta>();
            List<RecetaArchivo> recetaArchivo = LecturaRecetas();
            foreach (var receta in recetaArchivo)
            {
                LogicaDespensa logicaDespensa = new LogicaDespensa();
                receta.ProductosNecesarios = logicaDespensa.ObtenerProductosReceta(receta.IngredientesCodigo);
                recetas.Add(receta);
            }
            return recetas;
        }

      
        public List<Receta> ObtenerRecetas(string filtro)
        {
            List<Receta> recetas = new List<Receta>();
            List<RecetaArchivo> recetaArchivo = LecturaRecetas();
            foreach (var receta in recetaArchivo)
            {
                LogicaDespensa logicaDespensa = new LogicaDespensa();
                receta.ProductosNecesarios = logicaDespensa.ObtenerProductosReceta(receta.IngredientesCodigo);
                recetas.Add(receta);
            }

            switch (filtro)
            {
                case "Desayuno":
                    recetas = recetas.FindAll(x => x.Momento == MomentosDelDia.Desayuno);
                    break;
                case "Almuerzo":
                    recetas = recetas.FindAll(x => x.Momento == MomentosDelDia.Almuerzo);
                    break;
                case "Merienda":
                    recetas = recetas.FindAll(x => x.Momento == MomentosDelDia.Merienda);
                    break;
                case "Cena":
                    recetas = recetas.FindAll(x => x.Momento == MomentosDelDia.Cena);
                    break;

            }

            return recetas;
        }

        public void CrearActualizarRecetas(Receta receta)
        {
            List<Receta> recetas = new List<Receta>();
            recetas = ObtenerRecetas();
            List<string> codigosRecetas = recetas.Select(x => x.Codigo).ToList();
            if (!codigosRecetas.Contains(receta.Codigo)) // crear nuevo
            {
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
                        r.Nombre = receta.Nombre;
                        r.Saludable = receta.Saludable;
                        r.ProductosNecesarios = receta.ProductosNecesarios;
                        r.CantidadPorProducto = receta.CantidadPorProducto;
                        r.Momento = receta.Momento;
                    }
                }
            }
            EscrituraRecetas(recetas);
        }

        public void EliminarReceta(string codigo)
        {
            List<Receta> recetasFiltradas = ObtenerRecetas();
            foreach (var receta in recetasFiltradas)
            {
                if (receta.Codigo == codigo)
                {
                    recetasFiltradas.Remove(receta);
                    EscrituraRecetas(recetasFiltradas);
                    break;
                }
            }
        }

        public void EscrituraRecetas(List<Receta> recetas)
        {
            string pathEscritura = "recetas.txt";

            string serialProductos = JsonConvert.SerializeObject(recetas);

            Escritura(pathEscritura, serialProductos);
        }

        public static List<RecetaArchivo> LecturaRecetas()
        {
            string pathDirectorio = AppDomain.CurrentDomain.BaseDirectory + "JSON\\ ";
            string pathProducto = pathDirectorio + "recetas.txt";
            if (File.Exists(pathProducto))
            {
                using (StreamReader reader = new StreamReader(pathProducto))
                {

                    string json = reader.ReadToEnd();
                    List<RecetaArchivo> recetas = JsonConvert.DeserializeObject<List<RecetaArchivo>>(json);
                    if (recetas == null)
                    {
                        return new List<RecetaArchivo>();
                    }
                    return recetas;
                }
            }

            return new List<RecetaArchivo>();
        }

        public static Receta ObtenerRecetaComidas(string codigoReceta)
        {
            List<RecetaArchivo> recetas = LecturaRecetas();
            foreach (var receta in recetas)
            {
                if (receta.Codigo == codigoReceta)
                {
                    Receta recetaComida = receta;
                    return recetaComida;
                }
            }

            return new Receta();
        }

        public string BtnCrearReceta(string nombreReceta, string CodigoReceta, bool checkSaludable, string listaMomento, DataGridView grillaProductos)
        {
            bool cargaCorrecta = true;

            //Validar los datos 
            if (string.IsNullOrEmpty(nombreReceta))
            {
                return "Error, nombre mal cargado";
            }
            else
            {
                //Generar el objeto

                RecetaArchivo receta = new RecetaArchivo();
                if (CodigoReceta == null)
                {
                    receta.Codigo = RandomString(10);
                }
                else
                {
                    receta.Codigo = CodigoReceta;
                }
                receta.Saludable = checkSaludable;
                receta.Nombre = nombreReceta;
                switch (listaMomento)
                {
                    case "Desayuno":
                        receta.Momento = MomentosDelDia.Desayuno;
                        break;
                    case "Almuerzo":
                        receta.Momento = MomentosDelDia.Almuerzo;
                        break;
                    case "Merienda":
                        receta.Momento = MomentosDelDia.Merienda;
                        break;
                    case "Cena":
                        receta.Momento = MomentosDelDia.Cena;
                        break;
                    case null:
                        return "Falta cargar el momento del dia";
                }

                receta.ProductosNecesarios = new List<Producto>();
                receta.IngredientesCodigo = new List<string>();

                foreach (DataGridViewRow row in grillaProductos.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        if (int.Parse(row.Cells[1].Value.ToString()) > 0)
                        {
                            //Buscar el producto con el codigo
                            Archivo archivo = new Archivo();
                            Producto producto = archivo.ObtenerProducto(row.Cells[2].Value.ToString());

                            receta.ProductosNecesarios.Add(producto);
                            receta.CantidadPorProducto.Add(Convert.ToInt32(row.Cells[1].Value));
                            receta.IngredientesCodigo.Add(producto.Codigo);
                        }
                        else
                        {
                            return "La cantidad no puede ser menor a 0";
                        }
                    }
                }

                if (receta.IngredientesCodigo.Count > 0 && receta.ProductosNecesarios.Count > 0 && receta.IngredientesCodigo.Count == receta.ProductosNecesarios.Count && cargaCorrecta != false)
                {
                    //Guardar
                    CrearActualizarRecetas(receta);
                    return "Carga correcta";
                }
                else
                {
                    return "Error al cargar los productos";
                }
            }
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        
    }
}
