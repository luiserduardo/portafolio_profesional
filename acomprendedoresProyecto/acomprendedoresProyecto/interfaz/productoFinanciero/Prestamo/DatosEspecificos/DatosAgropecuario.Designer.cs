namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Agropecurios
{
    partial class DatosAgropecuario
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCuotaSeguro = new System.Windows.Forms.TextBox();
            this.txtTipoActividad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuotaSeguro
            // 
            this.txtCuotaSeguro.Location = new System.Drawing.Point(520, 13);
            this.txtCuotaSeguro.Multiline = true;
            this.txtCuotaSeguro.Name = "txtCuotaSeguro";
            this.txtCuotaSeguro.Size = new System.Drawing.Size(185, 26);
            this.txtCuotaSeguro.TabIndex = 31;
            this.txtCuotaSeguro.TextChanged += new System.EventHandler(this.txtCuotaSeguro_TextChanged);
            this.txtCuotaSeguro.Leave += new System.EventHandler(this.txtCuotaSeguro_Leave);
            // 
            // txtTipoActividad
            // 
            this.txtTipoActividad.Location = new System.Drawing.Point(160, 12);
            this.txtTipoActividad.Multiline = true;
            this.txtTipoActividad.Name = "txtTipoActividad";
            this.txtTipoActividad.Size = new System.Drawing.Size(185, 20);
            this.txtTipoActividad.TabIndex = 30;
            this.txtTipoActividad.Leave += new System.EventHandler(this.txtTipoActividad_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(380, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cuota seguro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tipo actividad";
            // 
            // DatosAgropecuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCuotaSeguro);
            this.Controls.Add(this.txtTipoActividad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Name = "DatosAgropecuario";
            this.Size = new System.Drawing.Size(1013, 100);
            this.Load += new System.EventHandler(this.DatosAgropecuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtTipoActividad;
        public System.Windows.Forms.TextBox txtCuotaSeguro;
    }
}
