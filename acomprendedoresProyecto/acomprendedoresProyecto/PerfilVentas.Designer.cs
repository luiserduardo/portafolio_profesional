namespace acomprendedoresProyecto
{
    partial class PerfilVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilVentas));
            this.panelDelContenido = new System.Windows.Forms.Panel();
            this.panelDelMenu = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDelContenido
            // 
            this.panelDelContenido.Location = new System.Drawing.Point(1, 113);
            this.panelDelContenido.Name = "panelDelContenido";
            this.panelDelContenido.Size = new System.Drawing.Size(1322, 649);
            this.panelDelContenido.TabIndex = 3;
            this.panelDelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDelContenido_Paint);
            // 
            // panelDelMenu
            // 
            this.panelDelMenu.Controls.Add(this.menu);
            this.panelDelMenu.Controls.Add(this.pictureBox1);
            this.panelDelMenu.Location = new System.Drawing.Point(1, 7);
            this.panelDelMenu.Name = "panelDelMenu";
            this.panelDelMenu.Size = new System.Drawing.Size(1322, 100);
            this.panelDelMenu.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.FormattingEnabled = true;
            this.menu.Items.AddRange(new object[] {
            "Ver cartera",
            "Registrar deposito"});
            this.menu.Location = new System.Drawing.Point(203, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(304, 33);
            this.menu.TabIndex = 1;
            this.menu.TabStop = false;
            this.menu.SelectedValueChanged += new System.EventHandler(this.cambioMenu);
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
            // PerfilVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 769);
            this.Controls.Add(this.panelDelContenido);
            this.Controls.Add(this.panelDelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerfilVentas";
            this.Text = "PerfilVentas";
            this.panelDelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDelContenido;
        private System.Windows.Forms.Panel panelDelMenu;
        private System.Windows.Forms.ComboBox menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}