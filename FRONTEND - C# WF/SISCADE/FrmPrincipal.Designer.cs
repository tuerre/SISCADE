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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realizarTransaccionFormulario_Btn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrarClienteFormulario_Btn
            // 
            this.registrarClienteFormulario_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.registrarClienteFormulario_Btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarClienteFormulario_Btn.Location = new System.Drawing.Point(117, 72);
            this.registrarClienteFormulario_Btn.Name = "registrarClienteFormulario_Btn";
            this.registrarClienteFormulario_Btn.Size = new System.Drawing.Size(154, 22);
            this.registrarClienteFormulario_Btn.TabIndex = 0;
            this.registrarClienteFormulario_Btn.Text = "Registrar nuevo cliente";
            this.registrarClienteFormulario_Btn.UseVisualStyleBackColor = false;
            this.registrarClienteFormulario_Btn.Click += new System.EventHandler(this.registrarClienteFormulario_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(89, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PANEL DE RECURSOS ADMIN";
            // 
            // realizarTransaccionFormulario_Btn
            // 
            this.realizarTransaccionFormulario_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.realizarTransaccionFormulario_Btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizarTransaccionFormulario_Btn.Location = new System.Drawing.Point(117, 116);
            this.realizarTransaccionFormulario_Btn.Name = "realizarTransaccionFormulario_Btn";
            this.realizarTransaccionFormulario_Btn.Size = new System.Drawing.Size(154, 22);
            this.realizarTransaccionFormulario_Btn.TabIndex = 4;
            this.realizarTransaccionFormulario_Btn.Text = "Realizar Transacción";
            this.realizarTransaccionFormulario_Btn.UseVisualStyleBackColor = false;
            this.realizarTransaccionFormulario_Btn.Click += new System.EventHandler(this.realizarTransaccionFormulario_Btn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(244, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.realizarTransaccionFormulario_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarClienteFormulario_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "SISCADE - RECURSOS ADMIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrarClienteFormulario_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button realizarTransaccionFormulario_Btn;
        private System.Windows.Forms.Button btnClose;
    }
}

