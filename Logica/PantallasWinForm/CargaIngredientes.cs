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
    public partial class CargaIngredientes : Form
    {
        string CodigoProducto = String.Empty;
        public CargaIngredientes(string codigoProducto)
        {
            InitializeComponent();
            CodigoProducto = codigoProducto;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form salir = new Menu();
            salir.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            LogicaDespensa logicaDespensa = new LogicaDespensa();
            MessageBox.Show(logicaDespensa.ValidacionCargaIngredientes(nombre.Text, cantidad.Text, stockMinimo.Text, precio.Text, CodigoProducto, categoriaBox));
            Form nuevo = new CargaIngredientes( CodigoProducto);
            nuevo.Show();
            this.Hide();


        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form volver = new Despensa();
            volver.Show();
            this.Hide();

        }
    }  
}
