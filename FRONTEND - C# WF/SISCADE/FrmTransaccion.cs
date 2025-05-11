using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISCADE.Data;

namespace SISCADE
{
    public partial class FrmTransaccion : Form
    {
        public FrmTransaccion()
        {
            InitializeComponent();
            CargarClientes();
            CargarMonedas();
            CargarFormasPago();
            cbTipoTransaccion.Items.AddRange(new string[] { "Compra", "Venta" });
        }

        private void FrmTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void CargarClientes()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdCliente, NombreCompleto FROM Cliente", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbCliente.Items.Add(new ComboboxItem(reader["NombreCompleto"].ToString(), Convert.ToInt32(reader["IdCliente"])));
                }
            }
        }

        private void CargarMonedas()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdMoneda, Nombre FROM Moneda", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbMoneda.Items.Add(new ComboboxItem(reader["Nombre"].ToString(), Convert.ToInt32(reader["IdMoneda"])));
                }
            }
        }

        private void CargarFormasPago()
        {
            cbFormaPago.Items.AddRange(new string[] { "Efectivo", "Transferencia", "Cheque" });
        }

        private void cbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMoneda.SelectedItem != null && cbTipoTransaccion.SelectedItem != null)
            {
                int idMoneda = ((ComboboxItem)cbMoneda.SelectedItem).Value;
                string tipo = cbTipoTransaccion.SelectedItem.ToString();

                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 TasaCompra, TasaVenta FROM TasaCambio WHERE IdMoneda = @id ORDER BY FechaVigencia DESC", con);
                    cmd.Parameters.AddWithValue("@id", idMoneda);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        decimal tasa = (tipo == "Compra") ? reader.GetDecimal(0) : reader.GetDecimal(1);
                        txtTasaCambio.Text = tasa.ToString("N4");
                        CalcularTotal();
                    }
                }
            }
        }

        private void CargarTasaYCalcular()
        {
            if (cbMoneda.SelectedItem != null && cbTipoTransaccion.SelectedItem != null)
            {
                int idMoneda = ((ComboboxItem)cbMoneda.SelectedItem).Value;
                string tipo = cbTipoTransaccion.SelectedItem.ToString();

                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 TasaCompra, TasaVenta FROM TasaCambio WHERE IdMoneda = @id ORDER BY FechaVigencia DESC", con);
                    cmd.Parameters.AddWithValue("@id", idMoneda);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        decimal tasa = (tipo == "Compra") ? reader.GetDecimal(0) : reader.GetDecimal(1);
                        txtTasaCambio.Text = tasa.ToString("N4");
                        CalcularTotal();
                    }
                    else
                    {
                        txtTasaCambio.Text = "";
                        txtTotalLocal.Text = "";
                        MessageBox.Show("No hay tasa registrada para esta moneda.");
                    }
                }
            }
        }

        private void cbTipoTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTasaYCalcular();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && decimal.TryParse(txtTasaCambio.Text, out decimal tasa))
            {
                txtTotalLocal.Text = (monto * tasa).ToString("N2");
            }
            else
            {
                txtTotalLocal.Text = "0.00";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedItem == null || cbMoneda.SelectedItem == null || cbTipoTransaccion.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(txtTasaCambio.Text) || cbFormaPago.SelectedItem == null)
            {
                MessageBox.Show("Por favor, llena todos los campos requeridos.");
                return;
            }

            Transaccion t = new Transaccion
            {
                IdCliente = ((ComboboxItem)cbCliente.SelectedItem).Value,
                IdEmpleado = 1, // Aquí luego pones el ID del empleado logueado
                IdMoneda = ((ComboboxItem)cbMoneda.SelectedItem).Value,
                TipoTransaccion = cbTipoTransaccion.SelectedItem.ToString(),
                Monto = decimal.Parse(txtMonto.Text),
                TasaCambioAplicada = decimal.Parse(txtTasaCambio.Text),
                TotalLocal = decimal.Parse(txtTotalLocal.Text),
                FormaPago = cbFormaPago.SelectedItem.ToString(),
                Observaciones = txtObservaciones.Text
            };

            int r = TransaccionDAL.AgregarTransaccion(t);
            if (r > 0)
                MessageBox.Show("Transacción registrada correctamente.");
            else
                MessageBox.Show("Error al registrar.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboboxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }


}
