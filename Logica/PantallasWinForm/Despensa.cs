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
    public partial class Despensa : Form
    {
        public Despensa()
        {
            InitializeComponent();
        }

        private void btn_cargaringrediente_Click(object sender, EventArgs e)
        {
            Form cargar = new CargaIngredientes();
            cargar.Show();
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
            grillaDespensa.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaDespensa logicaDespensa = new LogicaDespensa();
            grillaDespensa.DataSource = logicaDespensa.LecturaDespensa();
        }

        private void grillaDespensa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = UtilidadesGrilla.ObtenerIndice(grillaDespensa, "Editar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(grillaDespensa, "Eliminar");

            if (indiceEditar == e.ColumnIndex)
            {
                //Hizo clic en editar
                var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaDespensa, "Codigo");
                var codigoUsuario = grillaDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                CargaIngredientes cargaIngredientes = new CargaIngredientes();
                cargaIngredientes.ShowDialog(this);
            }

            if (indiceEliminar == e.ColumnIndex)
            {
                //Hizo clic en eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    //Invocar a la logica para eliminar registro.
                    LogicaDespensa logicaDespensa = new LogicaDespensa();
                    var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaDespensa, "Codigo");
                    var codigoProducto = grillaDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                    logicaDespensa.EliminarProducto(codigoProducto);
                    ActualizarGrilla();
                }
            }
        }

    }
}
