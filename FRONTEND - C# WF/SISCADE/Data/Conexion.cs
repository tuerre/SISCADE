using System;
using System.Data.SqlClient;

namespace SISCADE.Data
{
    public class Conexion
    {

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=SISCADE;Data Source=SlimReaper");
            conexion.Open();

            return conexion;
        }
    }


}
