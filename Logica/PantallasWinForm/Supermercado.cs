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

            List<Producto> productos = new List<Producto>();

            foreach (DataGridViewRow row in grillaSupermercado.Rows)
            {
                Producto producto = new Producto();
                producto.Codigo = Convert.ToString(row.Cells[0].Value);
                producto.Nombre = row.Cells[1].Value.ToString();
                producto.Precio = Convert.ToDouble(row.Cells[2].Value);
                producto.Cantidad = 10;
                producto.CantidadMinima = Convert.ToInt32(row.Cells[4].Value);

                productos.Add(producto);
            }

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
            grillaSupermercado.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaSuper logicaSupermercado = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSupermercado.LecturaSuper();
        }

        private void filtroBuscar_Click(object sender, EventArgs e)
        {
            LogicaSuper logicaSuper = new LogicaSuper();
            grillaSupermercado.DataSource = logicaSuper.FiltrarSuper(listaIngredientes.Text);
        }

        private void eliminarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
