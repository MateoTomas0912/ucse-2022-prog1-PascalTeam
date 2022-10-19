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
    }
}
