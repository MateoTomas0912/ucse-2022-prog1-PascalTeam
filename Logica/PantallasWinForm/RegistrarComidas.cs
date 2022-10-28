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

        private void button1_Click(object sender, EventArgs e)
        {
            ComidaArchivo comida = new ComidaArchivo();
            if(CodigoComida == null)
            {
                comida.Codigo = RandomString(10);
            }
            else
            {
                comida.Codigo = CodigoComida;
            }
            comida.RegistroDeComida = fechaComida.Value;

            foreach (DataGridViewRow row in grillaRecetas.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    Receta receta = new Receta();
                    receta.Codigo = row.Cells[1].Value.ToString();
                    receta.Nombre = row.Cells[2].Value.ToString();
                    receta.Saludable = Convert.ToBoolean(row.Cells[3].Value);

                    switch (row.Cells[4].Value)
                    {
                        case "Desayuno":
                            receta.Momento = MomentosDelDia.Desayuno;
                            break;
                        case "Almuerzo":
                            receta.Momento = MomentosDelDia.Almuerzo;
                            break;
                        case "Merienda":
                            receta.Momento = MomentosDelDia.Merienda;
                            break;
                        case "Cena":
                            receta.Momento = MomentosDelDia.Cena;
                            break;
                    }

                    comida.Receta = receta;
                    comida.CodigoReceta = row.Cells[1].Value.ToString();

                    //Actualizar Despensa
                    LogicaDespensa logicaDespensa = new LogicaDespensa();
                    bool hayProductos = logicaDespensa.DescontarProductos(receta.Codigo);
                    if (!hayProductos)
                    {
                        MessageBox.Show("No tiene la suficiente cantidad de productos");
                    }
                    else
                    {
                        //Generar comida
                        LogicaComidas logicaComidas = new LogicaComidas();
                        logicaComidas.CrearActualizarComida(comida);
                    }
                }
            }
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
            grillaRecetas.AutoGenerateColumns = true;

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

        private void filtroBuscar_Click_1(object sender, EventArgs e)
        {
            string momentoReceta = listaMomentos.Text;
            LogicaRecetas logicaRecetas = new LogicaRecetas();
            grillaRecetas.DataSource = null;
            grillaRecetas.DataSource = logicaRecetas.ObtenerRecetas(momentoReceta);
        }
    }
}
