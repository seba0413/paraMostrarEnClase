using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSql
{
    public partial class Form2 : Form
    {
        public List<Articulo> articulos;

        public Form2(List<Articulo> articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Articulo articulo in articulos)
            {
                ltbArticulos.Items.Add(articulo.Descripcion);
            }           
        }

        private void ltbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = ltbArticulos.SelectedItem.ToString();

            foreach(Articulo articulo in articulos)
            {
                if(seleccion == articulo.Descripcion)
                {
                    lblCantidad.Text = articulo.Cantidad.ToString();
                    break;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string itemSeleccionado = (string)ltbArticulos.SelectedItem;

            try
            {
                foreach (Articulo art in articulos)
                {
                    if (itemSeleccionado == art.Descripcion)
                    {
                        if (ConexionSQL.borrarArticulo(art.Codigo))
                        {
                            MessageBox.Show(this, "Articulo Borrado");
                        }
                    }
                }
                ltbArticulos.Items.Clear();
                articulos = ConexionSQL.mostrarLista();
                foreach (Articulo articulo in articulos)
                {
                    ltbArticulos.Items.Add(articulo.Descripcion);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
