using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repository
{
    internal class RepositorySQLServer
    {
        public static DataSet GetBooks()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM Books";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public static bool CrearContacto(Book c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat ymd; INSERT INTO Books VALUES ('" + c.Title + "', '" + c.PublicationDate + "', '" + c.Description + "', '" + c.NumOfPages + "')";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para eliminar un contacto.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarContacto(Book c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM Book WHERE Id = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para modificar un contacto.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ModificarContacto(Book c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; UPDATE Books SET Title = '" + c.Title + "', PublicationDate= '" + c.PublicationDate + "', " +
                    "Description = '" + c.Description + "', NumOfPages = '" + c.NumOfPages + "' " +
                    " WHERE ID = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }
    }

}
