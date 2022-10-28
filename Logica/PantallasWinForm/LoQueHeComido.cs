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
            grillaComidas.AutoGenerateColumns = false;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            LogicaComidas logicaComidas = new LogicaComidas();
            grillaComidas.DataSource = logicaComidas.ObtenerComidas();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void AgregarComida_Click(object sender, EventArgs e)
        {
            Form registrarComida = new RegistrarComidas(null);
            registrarComida.Show();
            this.Hide();
        }

        private void grillaComidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = UtilidadesGrilla.ObtenerIndice(grillaComidas, "Editar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(grillaComidas, "Eliminar");

            if (indiceEditar == e.ColumnIndex)
            {
                //Hizo clic en editar
                var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaComidas, "Codigo");
                var codigoUsuario = grillaComidas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                RegistrarComidas registar = new RegistrarComidas(codigoUsuario);

                registar.ShowDialog(this);
            }

            if (indiceEliminar == e.ColumnIndex)
            {
                //Hizo clic en eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    //Invocar a la logica para eliminar registro.
                    LogicaComidas logicaComida = new LogicaComidas();
                    var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaComidas, "Codigo");
                    var codigoComida = grillaComidas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                    logicaComida.EliminarComida(codigoComida);
                    ActualizarGrilla();
                }
            }
        }
    }
}
