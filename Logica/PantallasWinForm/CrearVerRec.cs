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
    public partial class CrearVerRec : Form
    {
        public CrearVerRec()
        {
            InitializeComponent();
        }

        private void btn_Aggreceta_Click(object sender, EventArgs e)
        {
            Form agg = new AgregarReceta(null);
            agg.Show();
            this.Hide();
        }

        private void btn_Verrecetas_Click(object sender, EventArgs e)
        {
            Form verrecetas = new MisRecetas();
            verrecetas.Show();
            this.Hide();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form volver = new Menu();
            volver.Show();
            this.Hide();
        }
    }
}
