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
    public partial class LoQueHeComido : Form
    {
        public LoQueHeComido()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //mostrarlos
            grillaComidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaComidas logicaComidas = new LogicaComidas();
            grillaComidas.DataSource = logicaComidas.ObtenerComidas();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void AgregarComida_Click(object sender, EventArgs e)
        {
            Form registrarComida = new RegistrarComidas(null);
            registrarComida.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void buscarPorFecha_Click(object sender, EventArgs e)
        {
            LogicaComidas logicaComidas = new LogicaComidas();
            grillaComidas.DataSource = logicaComidas.ObtenerComidas(dateTimeComidas.Text);
        }
    }
}
