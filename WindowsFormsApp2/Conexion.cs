using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Conexion
    {
        public SqlConnection cnx;
        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=WINAPOHGECOCLWC\\SQLEXPRESS; Initial Catalog=Library;Integrated Security=True");
                Console.WriteLine("Éxito al conectar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar. " + ex.Message);
            }
        }
    }
}
