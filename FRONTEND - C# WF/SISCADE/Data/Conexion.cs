using System;
using System.Data.SqlClient;

namespace SISCADE.Data
{
    public class Conexion
    {
        private static string connectionString = "Data Source=SLIMREAPER;Initial Catalog=SISCADE;User ID=sa;Password=GodIsGood072330";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }
    }


}
