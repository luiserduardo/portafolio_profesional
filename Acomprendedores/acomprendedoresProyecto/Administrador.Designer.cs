using System.Windows.Forms;

namespace acomprendedoresProyecto
{
    partial class formulario2 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario2));
            this.panelDelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.ComboBox();
            this.panelDelContenido = new System.Windows.Forms.Panel();
            this.panelDelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDelMenu
            // 
            this.panelDelMenu.Controls.Add(this.pictureBox1);
            this.panelDelMenu.Controls.Add(this.comboBox2);
            this.panelDelMenu.Controls.Add(this.comboBox1);
            this.panelDelMenu.Controls.Add(this.menu);
            this.panelDelMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDelMenu.Location = new System.Drawing.Point(2, 0);
            this.panelDelMenu.Name = "panelDelMenu";
            this.panelDelMenu.Size = new System.Drawing.Size(1231, 100);
            this.panelDelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::acomprendedoresProyecto.Properties.Resources.logoIcono;
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Registrar empleados",
            "Registrar clientes",
            "Ver empleados",
            "Ver clientes",
            "Registrar cartera virtual"});
            this.comboBox2.Location = new System.Drawing.Point(753, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 33);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.TabStop = false;
            this.comboBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cuenta",
            "Prestamo"});
            this.comboBox1.Location = new System.Drawing.Point(538, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TabStop = false;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.cambioMenu2);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.FormattingEnabled = true;
            this.menu.Items.AddRange(new object[] {
            "Registrar empleados",
            "Registrar clientes",
            "Ver empleados",
            "Ver clientes",
            "Registrar cartera virtual",
            "Registrar producto financiero",
            "Gestionar productos-clientes"});
            this.menu.Location = new System.Drawing.Point(203, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(291, 33);
            this.menu.TabIndex = 1;
            this.menu.TabStop = false;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            this.menu.SelectedValueChanged += new System.EventHandler(this.cambioMenu);
            // 
            // panelDelContenido
            // 
            this.panelDelContenido.BackColor = System.Drawing.SystemColors.Control;
            this.panelDelContenido.Location = new System.Drawing.Point(2, 106);
            this.panelDelContenido.Name = "panelDelContenido";
            this.panelDelContenido.Size = new System.Drawing.Size(1231, 649);
            this.panelDelContenido.TabIndex = 1;
            // 
            // formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.panelDelContenido);
            this.Controls.Add(this.panelDelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formulario2";
            this.Text = "Administrador";
            this.panelDelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDelMenu;
        private System.Windows.Forms.Panel panelDelContenido;
        private System.Windows.Forms.ComboBox menu;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}