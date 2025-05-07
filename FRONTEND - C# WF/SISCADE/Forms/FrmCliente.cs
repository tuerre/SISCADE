using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SISCADE.Data;

namespace SISCADE.Forms
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDocumentoTipo.Text) ||
                string.IsNullOrWhiteSpace(txtDocumentoNumero.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "INSERT INTO Cliente (NombreCompleto, DocumentoTipo, DocumentoNumero, Nacionalidad, Direccion, Telefono, Correo, Ocupacion, FuenteFondos) " +
                                   "VALUES (@nombre, @tipo, @numero, @nacionalidad, @direccion, @telefono, @correo, @ocupacion, @fuente)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@tipo", txtDocumentoTipo.Text);
                        cmd.Parameters.AddWithValue("@numero", txtDocumentoNumero.Text);
                        cmd.Parameters.AddWithValue("@nacionalidad", txtNacionalidad.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@ocupacion", txtOcupacion.Text);
                        cmd.Parameters.AddWithValue("@fuente", txtFuenteFondos.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#228B22");

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDocumentoTipo.Clear();
            txtDocumentoNumero.Clear();
            txtNacionalidad.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtOcupacion.Clear();
            txtFuenteFondos.Clear();
        }
    }
}
