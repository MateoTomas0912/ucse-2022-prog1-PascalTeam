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
        public CargaIngredientes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form salir = new Menu();
            salir.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = nombre.Text;
            producto.Codigo = RandomString(10);
            producto.Precio = Convert.ToInt32(precio.Text);

            switch (categoriaBox.SelectedItem)
            {
                case "Hortalizas y verduras":
                    HortalizaVerdura hortalizaVerdura = new HortalizaVerdura();
                    hortalizaVerdura.Codigo = producto.Codigo;
                    hortalizaVerdura.Nombre = producto.Nombre;
                    hortalizaVerdura.Precio = producto.Precio;
                    hortalizaVerdura.CantidadMinima = 5;
                    hortalizaVerdura.Cantidad = int.Parse(cantidad.Text);
                    hortalizaVerdura.CrearActualizarProducto(hortalizaVerdura);
                break;
                case "Frutas":
                    Fruta fruta = new Fruta();
                    fruta.Codigo = producto.Codigo;
                    fruta.Nombre = producto.Nombre;
                    fruta.Precio = producto.Precio;
                    fruta.CantidadMinima = 5;
                    fruta.Cantidad = int.Parse(cantidad.Text);
                    fruta.CrearActualizarProducto(fruta);
                break;
                case "Lacteos":
                    Lacteo lacteo = new Lacteo();
                    lacteo.Codigo = producto.Codigo;
                    lacteo.Nombre = producto.Nombre;
                    lacteo.Precio = producto.Precio;
                    lacteo.LitrosMinimos = 2;
                    lacteo.Litros = int.Parse(cantidad.Text);
                    lacteo.CrearActualizarProducto(lacteo);
                    break;
                case "Quesos":
                    Queso queso = new Queso();
                    queso.Codigo = producto.Codigo;
                    queso.Nombre = producto.Nombre;
                    queso.Precio = producto.Precio;
                    queso.PesoMinimo = 5;
                    queso.Peso = int.Parse(cantidad.Text);
                    queso.CrearActualizarProducto(queso);
                    break;
                case "Carnes":
                    Carne carne = new Carne();
                    carne.Codigo = producto.Codigo;
                    carne.Nombre = producto.Nombre;
                    carne.Precio = producto.Precio;
                    carne.PesoMinimo = 5;
                    carne.Peso = int.Parse(cantidad.Text);
                    carne.CrearActualizarProducto(carne);
                    break;
                case "Panaderia":
                    Panaderia panaderia = new Panaderia();
                    panaderia.Codigo = producto.Codigo;
                    panaderia.Nombre = producto.Nombre;
                    panaderia.Precio = producto.Precio;
                    panaderia.PesoMinimo = 5;
                    panaderia.Peso = int.Parse(cantidad.Text);
                    panaderia.CrearActualizarProducto(panaderia);
                    break;
                case "Pescados":
                    Pescado pescado = new Pescado();
                    pescado.Codigo = producto.Codigo;
                    pescado.Nombre = producto.Nombre;
                    pescado.Precio = producto.Precio;
                    pescado.PesoMinimo = 5;
                    pescado.Peso = int.Parse(cantidad.Text);
                    pescado.CrearActualizarProducto(pescado);
                    break;
                case "Bebida(Normal)":
                    Bebida bebida = new Bebida();
                    bebida.Codigo = producto.Codigo;
                    bebida.Nombre = producto.Nombre;
                    bebida.Precio = producto.Precio;
                    bebida.TipoBebida = TipoBebida.Normales;
                    bebida.CrearActualizarProducto(bebida);
                    break;
                case "Bebida (Alta en azucar)":
                    Bebida bebida2 = new Bebida();
                    bebida2.Codigo = producto.Codigo;
                    bebida2.Nombre = producto.Nombre;
                    bebida2.Precio = producto.Precio;
                    bebida2.TipoBebida = TipoBebida.AltaEnAzucar;
                    bebida2.CrearActualizarProducto(bebida2);
                    break;
                case "Bebida (Alcoholicas)":
                    Bebida bebida3 = new Bebida();
                    bebida3.Codigo = producto.Codigo;
                    bebida3.Nombre = producto.Nombre;
                    bebida3.Precio = producto.Precio;
                    bebida3.TipoBebida = TipoBebida.Alcoholicas;
                    bebida3.CrearActualizarProducto(bebida3);
                    break;
            }

            LogicaDespensa logicaDespensa = new LogicaDespensa();
            logicaDespensa.CrearActualizarDespensa(producto);
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
