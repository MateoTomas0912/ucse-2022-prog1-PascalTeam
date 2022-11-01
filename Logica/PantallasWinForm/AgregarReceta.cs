﻿using Logica.Contratos;
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
    public partial class AgregarReceta : Form
    {
        string CodigoReceta = string.Empty;

        public AgregarReceta(string codigoReceta)
        {
            InitializeComponent();
            CodigoReceta = codigoReceta;
        }

        public AgregarReceta()
        {
            InitializeComponent();
        }

        private void btn_volverInicio_Click(object sender, EventArgs e)
        {
            Form volver = new Menu();
            volver.Show();
            this.Hide();
        }

        private void btn_crearReceta_Click(object sender, EventArgs e)
        {
            bool cargaCorrecta = true;

            //Validar los datos 
            if (string.IsNullOrEmpty(NombreReceta.Text))
            {
                MessageBox.Show("Cargale nombre");
            }
            else
            {
                //Generar el objeto

                RecetaArchivo receta = new RecetaArchivo();
                if(CodigoReceta == null)
                {
                    receta.Codigo = RandomString(10);
                }
                else
                {
                    receta.Codigo = CodigoReceta;
                }
                receta.Saludable = checkSaludable.Checked;
                receta.Nombre = NombreReceta.Text;
                switch (listaMomento.Text)
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
                    case null:
                        MessageBox.Show("Falta cargar el momento del dia");
                        break;
                }

                receta.ProductosNecesarios = new List<Producto>();
                receta.IngredientesCodigo = new List<string>();

                foreach (DataGridViewRow row in grillaProductos.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        if(int.Parse(row.Cells[1].Value.ToString()) > 0)
                        {
                            //Buscar el producto con el codigo
                            Archivo archivo = new Archivo();
                            Producto producto = archivo.ObtenerProducto(row.Cells[2].Value.ToString());

                            receta.ProductosNecesarios.Add(producto);
                            receta.CantidadPorProducto.Add(Convert.ToInt32(row.Cells[1].Value));
                            receta.IngredientesCodigo.Add(producto.Codigo);
                        }
                        else
                        {
                            MessageBox.Show("La cantidad no puede ser menor a 0");
                            cargaCorrecta = false;
                            this.Hide();
                            break;
                        }
                    }
                    else
                    {
                        cargaCorrecta = false;
                    }
                }

                if(receta.IngredientesCodigo.Count > 0 && receta.ProductosNecesarios.Count > 0 && receta.IngredientesCodigo.Count == receta.ProductosNecesarios.Count && cargaCorrecta != false)
                {
                    //Guardar
                    LogicaRecetas logicaRecetas = new Logica.Logicas.LogicaRecetas();
                    logicaRecetas.CrearActualizarRecetas(receta);
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar los productos");
                    Form error = new AgregarReceta();
                    error.Show();
                    this.Hide();
                    cargaCorrecta = false;
                }
            }

            if(cargaCorrecta == true)
            {
                Form volver = new CrearVerRec();
                volver.Show();
                this.Hide();
            } 
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void listaMomento_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMomento.Text = listaMomento.SelectedItem.ToString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //mostrarlos
            grillaProductos.AutoGenerateColumns = false;

            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            grillaProductos.DataSource = null;
            Archivo archivo = new Archivo();
            grillaProductos.DataSource = archivo.Lectura();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form volver = new CrearVerRec();
            volver.Show();
            this.Hide();
        }
    }
}
