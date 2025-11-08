namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Hipotecario
{
    partial class DatosHipotecario
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
            this.txtValorPropiedad = new System.Windows.Forms.TextBox();
            this.txtTipoPropiedad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDireccionTrabajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorPropiedad
            // 
            this.txtValorPropiedad.Location = new System.Drawing.Point(155, 72);
            this.txtValorPropiedad.Multiline = true;
            this.txtValorPropiedad.Name = "txtValorPropiedad";
            this.txtValorPropiedad.Size = new System.Drawing.Size(185, 26);
            this.txtValorPropiedad.TabIndex = 31;
            this.txtValorPropiedad.Leave += new System.EventHandler(this.txtValorPropiedad_Leave);
            // 
            // txtTipoPropiedad
            // 
            this.txtTipoPropiedad.Location = new System.Drawing.Point(155, 10);
            this.txtTipoPropiedad.Multiline = true;
            this.txtTipoPropiedad.Name = "txtTipoPropiedad";
            this.txtTipoPropiedad.Size = new System.Drawing.Size(185, 20);
            this.txtTipoPropiedad.TabIndex = 30;
            this.txtTipoPropiedad.Leave += new System.EventHandler(this.txtTipoPropiedad_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 19);
            this.label13.TabIndex = 29;
            this.label13.Text = "Valor propiedad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tipo propiedad";
            // 
            // txtDireccionTrabajo
            // 
            this.txtDireccionTrabajo.Location = new System.Drawing.Point(584, 12);
            this.txtDireccionTrabajo.Multiline = true;
            this.txtDireccionTrabajo.Name = "txtDireccionTrabajo";
            this.txtDireccionTrabajo.Size = new System.Drawing.Size(185, 26);
            this.txtDireccionTrabajo.TabIndex = 33;
            this.txtDireccionTrabajo.Leave += new System.EventHandler(this.txtDireccionTrabajo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dirección trabajo";
            // 
            // DatosHipotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDireccionTrabajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorPropiedad);
            this.Controls.Add(this.txtTipoPropiedad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Name = "DatosHipotecario";
            this.Size = new System.Drawing.Size(806, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtValorPropiedad;
        public System.Windows.Forms.TextBox txtTipoPropiedad;
        public System.Windows.Forms.TextBox txtDireccionTrabajo;
    }
}
