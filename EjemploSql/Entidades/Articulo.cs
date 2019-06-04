using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        private int codigo;
        private string descripcion;
        private int cantidad;

        public Articulo(string descripcion, int cantidad)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad; 
        }

        public Articulo(int codigo, string descripcion, int cantidad):this(descripcion, cantidad)
        {
            this.codigo = codigo;
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value; 
            }
        }

        public string Descripcion
        {
            set
            {
                this.descripcion = value; 
            }

            get
            {
                return this.descripcion;
            }
        }

        public int Cantidad
        {
            set
            {
                this.cantidad = value;
            }

            get
            {
                return this.cantidad;
            }
        }
    }
}
