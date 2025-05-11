using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISCADE;
using SISCADE.Data;

namespace SISCADE
{
    public class ClienteDAL
    {
        public static int AgregarCliente(Cliente cliente)
        {
            int returnStatus = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Cliente (NombreCompleto, DocumentoTipo, DocumentoNumero, Nacionalidad, Direccion, Telefono, Correo, Ocupacion, FuenteFondos) VALUES('" + cliente.NombreCompleto + "', '" + cliente.DocumentoTipo + "', '" + cliente.DocumentoNumero + "', '" + cliente.Nacionalidad + "', '" + cliente.Direccion + "', '" + cliente.Telefono + "', '" + cliente.Correo + "', '" + cliente.Ocupacion + "', '" + cliente.FuenteFondos + "')";

                SqlCommand comando = new SqlCommand(query, conexion);

                returnStatus = comando.ExecuteNonQuery();
            }

            return returnStatus;
        }
    }
}
