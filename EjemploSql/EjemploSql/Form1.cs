using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo(txtDescripcion.Text, int.Parse(txtCantidad.Text));
            try
            {
                if (ConexionSQL.insertarArticulo(articulo))
                {
                    MessageBox.Show(this, "Articulo Agregado");
                }

                txtDescripcion.Clear();
                txtCantidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            List<Articulo> articulos = new List<Articulo>();
            try
            {                
                articulos = ConexionSQL.mostrarLista();
                Form2 lista = new Form2(articulos);
                lista.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
