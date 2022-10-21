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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form super = new Supermercado();
            super.Show();
            this.Hide();

        }
        private void btnComidas_Click(object sender, EventArgs e)
        {
            Form comida = new GrillaProductos();
            comida.Show();
            this.Hide();

        }

        private void btnDespensa_Click(object sender, EventArgs e)
        {
            Form ingredientes  = new  CargaIngredientes();
            ingredientes.Show();
            this.Hide();

        }

        private void BtnRecetas_Click(object sender, EventArgs e)
        {
            Form Verocrear = new CrearVerRec();
            Verocrear.Show();
            this.Hide();

        }
    }
}
