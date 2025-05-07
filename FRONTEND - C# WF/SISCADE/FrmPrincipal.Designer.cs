namespace SISCADE
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.registrarClienteFormulario_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrarClienteFormulario_Btn
            // 
            this.registrarClienteFormulario_Btn.Location = new System.Drawing.Point(56, 338);
            this.registrarClienteFormulario_Btn.Name = "registrarClienteFormulario_Btn";
            this.registrarClienteFormulario_Btn.Size = new System.Drawing.Size(132, 23);
            this.registrarClienteFormulario_Btn.TabIndex = 0;
            this.registrarClienteFormulario_Btn.Text = "Registrar nuevo cliente";
            this.registrarClienteFormulario_Btn.UseVisualStyleBackColor = true;
            this.registrarClienteFormulario_Btn.Click += new System.EventHandler(this.registrarClienteFormulario_Btn_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.registrarClienteFormulario_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrarClienteFormulario_Btn;
    }
}

