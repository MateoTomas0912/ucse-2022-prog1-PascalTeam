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
            MessageBox.Show(logicaRecetas1.BtnCrearReceta(NombreReceta.Text, CodigoReceta, checkSaludable.Checked, listaMomento.Text,grillaProductos));
            Form volver = new AgregarReceta();
            volver.Show();
            this.Hide();
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
