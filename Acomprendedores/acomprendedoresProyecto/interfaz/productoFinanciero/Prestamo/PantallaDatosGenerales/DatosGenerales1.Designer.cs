namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.PantallaDatosGenerales
{
    partial class DatosGenerales1
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCodigoPrestamo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(482, 12);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(241, 26);
            this.txtMonto.TabIndex = 16;
            this.txtMonto.Leave += new System.EventHandler(this.validarMonto);
            // 
            // txtCodigoPrestamo
            // 
            this.txtCodigoPrestamo.Location = new System.Drawing.Point(149, 13);
            this.txtCodigoPrestamo.Multiline = true;
            this.txtCodigoPrestamo.Name = "txtCodigoPrestamo";
            this.txtCodigoPrestamo.ReadOnly = true;
            this.txtCodigoPrestamo.Size = new System.Drawing.Size(185, 20);
            this.txtCodigoPrestamo.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(378, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Monto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Código prestamo";
            // 
            // DatosGenerales1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCodigoPrestamo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Name = "DatosGenerales1";
            this.Size = new System.Drawing.Size(760, 100);
            this.Load += new System.EventHandler(this.DatosGenerales1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCodigoPrestamo;
        public System.Windows.Forms.TextBox txtMonto;
    }
}
