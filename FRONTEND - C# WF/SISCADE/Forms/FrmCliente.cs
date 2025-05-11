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
                Cliente cliente = new Cliente();
                cliente.NombreCompleto = txtNombre.Text;
                cliente.DocumentoTipo = txtDocumentoTipo.Text;
                cliente.DocumentoNumero = txtDocumentoNumero.Text;
                cliente.Nacionalidad = txtNacionalidad.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Ocupacion = txtOcupacion.Text;
                cliente.FuenteFondos = txtFuenteFondos.Text;
                int result = ClienteDAL.AgregarCliente(cliente);

                if (result > 0)
                {
                    MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Cliente no registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0D0E12");

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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
