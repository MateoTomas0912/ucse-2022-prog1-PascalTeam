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
        public AgregarReceta()
        {
            InitializeComponent();
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
                Receta receta = new Receta();
                receta.Codigo = RandomString(10);
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

                //Guardar
                Logica.Logicas.LogicaRecetas logicaRecetas = new Logica.Logicas.LogicaRecetas();
                logicaRecetas.CrearActualizarRecetas(receta);
            }

            Form volver = new CrearVerRec();
            volver.Show();
            this.Hide();
        }

        private static Random random = new Random();

        private static string RandomString(int length)
        {
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
            grillaProductos.AutoGenerateColumns = true;

            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            grillaProductos.DataSource = null;
            Archivo archivo = new Archivo();
            grillaProductos.DataSource = archivo.Lectura();
        }
    }
}
