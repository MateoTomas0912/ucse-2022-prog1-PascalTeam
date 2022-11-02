using Logica;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CheckBox = System.Web.UI.WebControls.CheckBox;

namespace PantallasWinForm
{
    public partial class RegistrarComidas : Form
    {
        string CodigoComida = string.Empty;
        public RegistrarComidas(string codigoComida)
        {
            InitializeComponent();
            CodigoComida = codigoComida;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form loQueHeComido = new LoQueHeComido();
            loQueHeComido.Show();
            this.Hide();
        }


        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //mostrarlos
            grillaRecetas.AutoGenerateColumns = false;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            grillaRecetas.DataSource = null;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas();
        }

        private void eliminarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

       /* private void filtroBuscar_Click_1(object sender, EventArgs e)
        {
            string momentoReceta = listaMomentos.Text;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = null;
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas(momentoReceta);
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicaComidas logicaComidas = new LogicaComidas();
            logicaComidas.CrearActualizarComida(grillaRecetas, fechaComida.Value);

            LoQueHeComido loQueHeComido = new LoQueHeComido();
            loQueHeComido.Show();
            this.Hide();

        }

        private void filtroBuscar_Click(object sender, EventArgs e)
        {
            string momentoReceta = listaMomentos.Text;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = null;
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas(momentoReceta);

        }

        private void eliminarFiltro_Click_1(object sender, EventArgs e)
        {
            LogicaRecetas logicarecetas = new LogicaRecetas();
            grillaRecetas.DataSource = logicarecetas.ObtenerRecetas();

        }
    }
}
