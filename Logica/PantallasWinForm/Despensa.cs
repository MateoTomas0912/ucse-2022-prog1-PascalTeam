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
    public partial class Despensa : Form
    {
        public Despensa()
        {
            InitializeComponent();
        }

        private void btn_cargaringrediente_Click(object sender, EventArgs e)
        {
            Form cargar = new CargaIngredientes();
            cargar.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form salir = new Menu();
            salir.Show();
            this.Hide();


        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //mostrarlos
            grillaDespensa.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaDespensa logicaDespensa = new LogicaDespensa();
            grillaDespensa.DataSource = logicaDespensa.LecturaDespensa();
        }
    }
}
