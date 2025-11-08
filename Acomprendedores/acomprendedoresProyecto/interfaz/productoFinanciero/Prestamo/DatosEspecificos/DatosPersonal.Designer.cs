namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Personal
{
    partial class DatosPersonal
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
            this.txtNumeroReferencia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroReferencia
            // 
            this.txtNumeroReferencia.Location = new System.Drawing.Point(206, 13);
            this.txtNumeroReferencia.Multiline = true;
            this.txtNumeroReferencia.Name = "txtNumeroReferencia";
            this.txtNumeroReferencia.ReadOnly = true;
            this.txtNumeroReferencia.Size = new System.Drawing.Size(185, 20);
            this.txtNumeroReferencia.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Número referencia";
            // 
            // DatosPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNumeroReferencia);
            this.Controls.Add(this.label14);
            this.Name = "DatosPersonal";
            this.Size = new System.Drawing.Size(529, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtNumeroReferencia;
    }
}
