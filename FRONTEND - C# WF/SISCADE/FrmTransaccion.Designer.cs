namespace SISCADE
{
    partial class FrmTransaccion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblTasa = new System.Windows.Forms.Label();
            this.txtTasaCambio = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalLocal = new System.Windows.Forms.TextBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCliente.Location = new System.Drawing.Point(30, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 14);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Location = new System.Drawing.Point(178, 27);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(200, 21);
            this.cbCliente.TabIndex = 1;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMoneda.Location = new System.Drawing.Point(30, 70);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(54, 14);
            this.lblMoneda.TabIndex = 2;
            this.lblMoneda.Text = "Moneda:";
            // 
            // cbMoneda
            // 
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.Location = new System.Drawing.Point(178, 67);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(200, 21);
            this.cbMoneda.TabIndex = 3;
            this.cbMoneda.SelectedIndexChanged += new System.EventHandler(this.cbMoneda_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipo.Location = new System.Drawing.Point(30, 110);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(113, 14);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo de Transacción:";
            // 
            // cbTipoTransaccion
            // 
            this.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTransaccion.Location = new System.Drawing.Point(178, 107);
            this.cbTipoTransaccion.Name = "cbTipoTransaccion";
            this.cbTipoTransaccion.Size = new System.Drawing.Size(200, 21);
            this.cbTipoTransaccion.TabIndex = 5;
            this.cbTipoTransaccion.SelectedIndexChanged += new System.EventHandler(this.cbTipoTransaccion_SelectedIndexChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonto.Location = new System.Drawing.Point(30, 150);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(46, 14);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(178, 147);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTasa.Location = new System.Drawing.Point(30, 190);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(92, 14);
            this.lblTasa.TabIndex = 8;
            this.lblTasa.Text = "Tasa de Cambio:";
            // 
            // txtTasaCambio
            // 
            this.txtTasaCambio.Location = new System.Drawing.Point(178, 187);
            this.txtTasaCambio.Name = "txtTasaCambio";
            this.txtTasaCambio.ReadOnly = true;
            this.txtTasaCambio.Size = new System.Drawing.Size(200, 20);
            this.txtTasaCambio.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(30, 230);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 14);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total en moneda local:";
            // 
            // txtTotalLocal
            // 
            this.txtTotalLocal.Location = new System.Drawing.Point(178, 227);
            this.txtTotalLocal.Name = "txtTotalLocal";
            this.txtTotalLocal.ReadOnly = true;
            this.txtTotalLocal.Size = new System.Drawing.Size(200, 20);
            this.txtTotalLocal.TabIndex = 11;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFormaPago.Location = new System.Drawing.Point(30, 270);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(89, 14);
            this.lblFormaPago.TabIndex = 12;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.Location = new System.Drawing.Point(178, 267);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(200, 21);
            this.cbFormaPago.TabIndex = 13;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObs.Location = new System.Drawing.Point(30, 310);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(85, 14);
            this.lblObs.TabIndex = 14;
            this.lblObs.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(178, 307);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(200, 20);
            this.txtObservaciones.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(33, 349);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 30);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar Transacción";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(239, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmTransaccion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipoTransaccion);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.txtTasaCambio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalLocal);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FrmTransaccion";
            this.Text = "Registro de Transacción";
            this.Load += new System.EventHandler(this.FrmTransaccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoTransaccion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.TextBox txtTasaCambio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalLocal;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnClose;
    }
}