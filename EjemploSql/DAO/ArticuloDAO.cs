using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;


namespace DAO
{
    public static class ArticuloDAO
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static  ArticuloDAO()
        {
            string connectionStr = "Data Source=./SQLEXPRESS/DESKTOP-PFDR43B; Initial Catalog=base1; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool agregarArticulo(Articulo articulo)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("INSERT INTO articulos (descripcion, cantidad) VALUES ('{0}','{1}')", articulo.Descripcion, articulo.Cantidad);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;
        }

        public static bool borrarArticulo(int codigo)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("DELETE FROM articulos WHERE codigo = " + codigo);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;
        }

        public static List<Articulo> mostrarLista()
        {
            List<Articulo> articulos = new List<Articulo>();
            Articulo articulo;

            string consulta = String.Format("Select * from articulos");
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int codigo = int.Parse(oDr["codigo"].ToString());
                    string descripcion = oDr["descripcion"].ToString();
                    int cantidad = int.Parse(oDr["cantidad"].ToString());
                    articulo = new Articulo(codigo, descripcion, cantidad);
                    articulos.Add(articulo);
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return articulos;
        }

    }
}
