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
            LogicaRecetas logicaRecetas1 = new LogicaRecetas();
            string resultado = logicaRecetas1.BtnCrearReceta(NombreReceta.Text, CodigoReceta, checkSaludable.Checked, listaMomento.Text,grillaProductos);

            //Validar los datos 
            switch (resultado)
            {
                case "Error, nombre mal cargado":
                    MessageBox.Show("Cargale nombre");
                    break;
                case "La cantidad no puede ser menor a 0":
                    MessageBox.Show("La cantidad no puede ser menor a 0");
                    break;
                case "Error al cargar los productos":
                    MessageBox.Show("Error al cargar los productos");
                    break;
                case "Carga correcta":
                    Form volver = new CrearVerRec();
                    volver.Show();
                    this.Hide();
                    MessageBox.Show("Carga correcta");
                    break;
                case "Error en la carga":
                    MessageBox.Show("Error en carga");
                    break;
            }
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
