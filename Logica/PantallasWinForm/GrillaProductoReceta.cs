using Logica.Contratos;
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
    public partial class GrillaProductoReceta : Form
    {
        public GrillaProductoReceta(List<Producto> productos)
        {
            InitializeComponent();
            ActualizarGrilla(productos);
        }

        private void ActualizarGrilla(List<Producto> productos)
        {
            grillaProductos.DataSource = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form volver = new MisRecetas();
            volver.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form salir = new Menu();
            salir.Show();
            this.Hide();
        }
    }
}
