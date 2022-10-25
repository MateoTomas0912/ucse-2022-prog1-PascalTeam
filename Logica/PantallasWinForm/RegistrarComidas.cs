using Logica;
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
    public partial class RegistrarComidas : Form
    {
        public RegistrarComidas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form loQueHeComido = new LoQueHeComido();
            loQueHeComido.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comida comida = new Comida();
            comida.Codigo = RandomString(10);
            comida.RegistroDeComida = fechaComida.Value; 
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
            grillaRecetas.AutoGenerateColumns = true;

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            grillaRecetas.DataSource = null;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas();
        }
    }
}
