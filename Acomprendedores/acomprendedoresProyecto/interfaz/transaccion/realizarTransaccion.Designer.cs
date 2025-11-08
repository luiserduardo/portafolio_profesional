namespace acomprendedoresProyecto.ui.transaccion
{
    partial class realizarTransaccion
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTipoTransaccion = new System.Windows.Forms.Panel();
            this.lblTipoTransaccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelTipoTransaccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Controls.Add(this.panelTipoTransaccion);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1213, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(55, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Realizar Transacción";
            // 
            // panelTipoTransaccion
            // 
            this.panelTipoTransaccion.BackColor = System.Drawing.Color.White;
            this.panelTipoTransaccion.Controls.Add(this.comboBox1);
            this.panelTipoTransaccion.Controls.Add(this.lblTipoTransaccion);
            this.panelTipoTransaccion.Location = new System.Drawing.Point(364, 17);
            this.panelTipoTransaccion.Name = "panelTipoTransaccion";
            this.panelTipoTransaccion.Size = new System.Drawing.Size(404, 39);
            this.panelTipoTransaccion.TabIndex = 1;
            // 
            // lblTipoTransaccion
            // 
            this.lblTipoTransaccion.AutoSize = true;
            this.lblTipoTransaccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoTransaccion.ForeColor = System.Drawing.Color.Black;
            this.lblTipoTransaccion.Location = new System.Drawing.Point(3, 10);
            this.lblTipoTransaccion.Name = "lblTipoTransaccion";
            this.lblTipoTransaccion.Size = new System.Drawing.Size(142, 19);
            this.lblTipoTransaccion.TabIndex = 0;
            this.lblTipoTransaccion.Text = "Tipo de Transacción";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Depositar",
            "Transferir",
            "Pago prestamos",
            "Pago servicios",
            "Pago servicios"});
            this.comboBox1.Location = new System.Drawing.Point(203, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 540);
            this.panel1.TabIndex = 1;
            // 
            // realizarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "realizarTransaccion";
            this.Size = new System.Drawing.Size(1213, 636);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTipoTransaccion.ResumeLayout(false);
            this.panelTipoTransaccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTipoTransaccion;
        private System.Windows.Forms.Label lblTipoTransaccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}