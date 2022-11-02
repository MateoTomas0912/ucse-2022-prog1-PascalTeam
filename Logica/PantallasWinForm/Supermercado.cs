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
using System.Windows.Forms.VisualStyles;

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
            logicaSupermercado.VaciarLista(grillaSupermercado);

            ActualizarGrilla();

            Menu menu = new Menu();
            menu.Show();
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
            grillaSupermercado.AutoGenerateColumns = false;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaSuper logicaSupermercado = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSupermercado.LecturaSuper();
            int total = 0;
            foreach (DataGridViewRow row in grillaSupermercado.Rows)
            {
                    total = int.Parse(row.Cells[2].Value.ToString()) + total;
            }
            (costoTotal.Text) = total.ToString();
        }

        private void filtroBuscar_Click(object sender, EventArgs e)
        {
            LogicaSuper logicaSuper = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSuper.FiltrarSuperIngredientes(listaIngredientes.Text);
        }

        private void eliminarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void buscarPrecio_Click(object sender, EventArgs e)
        {
            LogicaSuper logicaSuper = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSuper.FiltrarSuperPrecio(precioText.Text);
        }

        private void quitarPrecio_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void cantidadButton_Click(object sender, EventArgs e)
        {
            LogicaSuper logicaSuper = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSuper.FiltrarSuperCantidad(cantidadText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void BuscarPorNombre_Click(object sender, EventArgs e)
        {
            LogicaSuper logicaSuper = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSuper.FiltrarSuperNombre(buscarProducto.Text);
        }

        private void QuitarFiltroNombre_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void grillaSupermercado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    LogicaSuper logicasuper = new LogicaSuper();
            //    logicasuper.ComprarAlgo(sender, e, costoTotal.Text, grillaSupermercado);
        }
    }
}
