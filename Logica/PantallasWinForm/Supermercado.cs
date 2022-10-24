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
    public partial class Supermercado : Form
    {
        public Supermercado()
        {
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            LogicaSuper logicaSupermercado = new LogicaSuper();
            logicaSupermercado.VaciarLista();
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
            grillaSupermercado.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaSuper logicaSupermercado = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSupermercado.Lectura();
        }

    }
}
