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
    public partial class MisRecetas : Form
    {
        public MisRecetas()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //mostrarlos
            grillaRecetas.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void grillaRecetas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla.CargarCamposAcciones(grillaRecetas);
        }

        private void ActualizarGrilla()
        {
            grillaRecetas.DataSource = null;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form salir = new Menu();
            salir.Show();
            this.Hide();
        }

        private void grillaRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = UtilidadesGrilla.ObtenerIndice(grillaRecetas, "Editar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(grillaRecetas, "Eliminar");
            int indiceVerProductos = UtilidadesGrilla.ObtenerIndice(grillaRecetas, "VerProductos");

            if (indiceEditar == e.ColumnIndex)
            {
                //Hizo clic en editar
                var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaRecetas, "Codigo");
                var codigoUsuario = grillaRecetas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                AgregarReceta agregarReceta = new AgregarReceta(codigoUsuario);

                agregarReceta.ShowDialog(this);
            }
            if (indiceVerProductos == e.ColumnIndex)
            {
                this.Hide();
            }

            if (indiceEliminar == e.ColumnIndex)
            {
                //Hizo clic en eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    //Invocar a la logica para eliminar registro.
                    LogicaRecetas logicaRecetas = new LogicaRecetas();
                    var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaRecetas, "Codigo");
                    var codigoReceta = grillaRecetas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                    logicaRecetas.EliminarReceta(codigoReceta);
                    ActualizarGrilla();
                }
            }

            if(indiceVerProductos == e.ColumnIndex)
            {
                var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(grillaRecetas, "Codigo");
                var codigoReceta = grillaRecetas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                LogicaRecetas logicaRecetas = new LogicaRecetas();
                List<Producto> productosEnReceta = logicaRecetas.ObtenerReceta(codigoReceta).ProductosNecesarios;

                GrillaProductoReceta grillaProductoReceta = new GrillaProductoReceta(productosEnReceta);
                grillaProductoReceta.Show();
            }
        }

        private void filtroBuscar_Click(object sender, EventArgs e)
        {
            string momentoReceta = listaMomentos.Text;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = null;
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas(momentoReceta);
        }

        private void eliminarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form volver = new CrearVerRec();
            volver.Show();
            this.Hide();
        }

        private void grillaRecetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
