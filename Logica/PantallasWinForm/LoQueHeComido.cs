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
            grillaComidas.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaComidas logicaComidas = new LogicaComidas();
            grillaComidas.DataSource = logicaComidas.Lectura();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}
