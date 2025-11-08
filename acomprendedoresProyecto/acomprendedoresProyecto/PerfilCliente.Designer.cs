namespace acomprendedoresProyecto
{
    partial class PerfilCliente
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilCliente));
            this.panelDelMenu = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDelMenu
            // 
            this.panelDelMenu.Controls.Add(this.menu);
            this.panelDelMenu.Controls.Add(this.pictureBox1);
            this.panelDelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelDelMenu.Name = "panelDelMenu";
            this.panelDelMenu.Size = new System.Drawing.Size(1322, 100);
            this.panelDelMenu.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.menu.FormattingEnabled = true;
            this.menu.Items.AddRange(new object[] {
            "Ver productos financieros",
            "Retirar de cuenta",
            "Retirar de tarjeta",
            "Pagar prestamo",
            "Transferir"});
            this.menu.Location = new System.Drawing.Point(203, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(304, 33);
            this.menu.TabIndex = 1;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::acomprendedoresProyecto.Properties.Resources.logoIcono;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 649);
            this.panel1.TabIndex = 5;
            // 
            // PerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerfilCliente";
            this.Text = "Cliente";
            this.panelDelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox menu;
    }
}