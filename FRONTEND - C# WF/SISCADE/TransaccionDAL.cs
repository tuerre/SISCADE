using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISCADE.Data;

namespace SISCADE
{
    public class TransaccionDAL
    {
        public static int AgregarTransaccion(Transaccion t)
        {
            int resultado = 0;
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Transaccion 
                (IdCliente, IdEmpleado, IdMoneda, TipoTransaccion, Monto, TasaCambioAplicada, TotalLocal, FechaHora, FormaPago, Observaciones)
                VALUES
                (@IdCliente, @IdEmpleado, @IdMoneda, @TipoTransaccion, @Monto, @TasaCambioAplicada, @TotalLocal, GETDATE(), @FormaPago, @Observaciones)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdCliente", t.IdCliente);
                comando.Parameters.AddWithValue("@IdEmpleado", t.IdEmpleado);
                comando.Parameters.AddWithValue("@IdMoneda", t.IdMoneda);
                comando.Parameters.AddWithValue("@TipoTransaccion", t.TipoTransaccion);
                comando.Parameters.AddWithValue("@Monto", t.Monto);
                comando.Parameters.AddWithValue("@TasaCambioAplicada", t.TasaCambioAplicada);
                comando.Parameters.AddWithValue("@TotalLocal", t.TotalLocal);
                comando.Parameters.AddWithValue("@FormaPago", t.FormaPago);
                comando.Parameters.AddWithValue("@Observaciones", t.Observaciones ?? "");

                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }
    }

}
