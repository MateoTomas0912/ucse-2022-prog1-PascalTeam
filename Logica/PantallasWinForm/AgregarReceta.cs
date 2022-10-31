using Logica.Contratos;
using Logica.Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasWinForm
{
    public partial class AgregarReceta : Form
    {
        string CodigoReceta = string.Empty;

        public AgregarReceta(string codigoReceta)
        {
            InitializeComponent();
            CodigoReceta = codigoReceta;
        }

        private void btn_volverInicio_Click(object sender, EventArgs e)
        {
            Form volver = new Menu();
            volver.Show();
            this.Hide();
        }

        private void btn_crearReceta_Click(object sender, EventArgs e)
        {
            //Validar los datos 
            if (string.IsNullOrEmpty(NombreReceta.Text))
            {
                MessageBox.Show("Cargale nombre");
            }
            else
            {
                //Generar el objeto

                RecetaArchivo receta = new RecetaArchivo();
                if(CodigoReceta == null)
                {
                    receta.Codigo = RandomString(10);
                }
                else
                {
                    receta.Codigo = CodigoReceta;
                }
                receta.Saludable = checkSaludable.Checked;
                receta.Nombre = NombreReceta.Text;
                switch (listaMomento.Text)
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
                }

                receta.ProductosNecesarios = new List<Producto>();
                receta.IngredientesCodigo = new List<string>();

                foreach (DataGridViewRow row in grillaProductos.Rows)
                {
                    if (row.Cells[0].Value != null && int.Parse(row.Cells[1].Value.ToString()) > 0 )
                    { 
                        Producto producto = new Producto();
                        producto.Codigo = Convert.ToString(row.Cells[2].Value);
                        producto.Nombre = row.Cells[3].Value.ToString();
                        producto.Precio = Convert.ToDouble(row.Cells[4].Value);

                        receta.ProductosNecesarios.Add(producto);
                        receta.CantidadPorProducto.Add(Convert.ToInt32(row.Cells[1].Value));
                        receta.IngredientesCodigo.Add(producto.Codigo);
                    }
                }

                if(receta.IngredientesCodigo.Count > 0 && receta.ProductosNecesarios.Count > 0 && receta.IngredientesCodigo.Count == receta.ProductosNecesarios.Count)
                {
                    //Guardar
                    LogicaRecetas logicaRecetas = new Logica.Logicas.LogicaRecetas();
                    logicaRecetas.CrearActualizarRecetas(receta);
                }
                else
                {
                    MessageBox.Show("Error al cargar los productos");
                }
            }

            Form volver = new CrearVerRec();
            volver.Show();
            this.Hide();
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void listaMomento_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMomento.Text = listaMomento.SelectedItem.ToString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //mostrarlos
            grillaProductos.AutoGenerateColumns = false;

            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            grillaProductos.DataSource = null;
            Archivo archivo = new Archivo();
            grillaProductos.DataSource = archivo.Lectura();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form volver = new CrearVerRec();
            volver.Show();
            this.Hide();
        }
    }
}
