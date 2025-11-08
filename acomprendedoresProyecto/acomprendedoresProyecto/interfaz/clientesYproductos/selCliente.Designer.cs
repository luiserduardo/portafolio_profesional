namespace acomprendedoresProyecto.pantallas.clientesYproductos
{
    partial class clientYProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlCardClientes;
        private System.Windows.Forms.Label lblClientesIcono; 
        private System.Windows.Forms.Label lblClientesValor;
        private System.Windows.Forms.Label lblClientesTexto;
        private System.Windows.Forms.Panel pnlCardProductos;
        private System.Windows.Forms.Label lblProductosIcono;
        private System.Windows.Forms.Label lblProductosValor;
        private System.Windows.Forms.Label lblProductosTexto;
        private System.Windows.Forms.Panel pnlBuscador;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblDirectorioTitulo;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.pnlCardClientes = new System.Windows.Forms.Panel();
            this.lblClientesIcono = new System.Windows.Forms.Label();
            this.lblClientesValor = new System.Windows.Forms.Label();
            this.lblClientesTexto = new System.Windows.Forms.Label();
            this.pnlCardProductos = new System.Windows.Forms.Panel();
            this.lblProductosIcono = new System.Windows.Forms.Label();
            this.lblProductosValor = new System.Windows.Forms.Label();
            this.lblProductosTexto = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblDirectorioTitulo = new System.Windows.Forms.Label();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlCardClientes.SuspendLayout();
            this.pnlCardProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.pnlHeader.Controls.Add(this.lblTituloPanel);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1231, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPanel.ForeColor = System.Drawing.Color.White;
            this.lblTituloPanel.Location = new System.Drawing.Point(19, 23);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(280, 25);
            this.lblTituloPanel.TabIndex = 0;
            this.lblTituloPanel.Text = "Gestión de clientes - producto";
            // 
            // pnlCardClientes
            // 
            this.pnlCardClientes.BackColor = System.Drawing.Color.White;
            this.pnlCardClientes.Controls.Add(this.lblClientesIcono);
            this.pnlCardClientes.Controls.Add(this.lblClientesValor);
            this.pnlCardClientes.Controls.Add(this.lblClientesTexto);
            this.pnlCardClientes.Location = new System.Drawing.Point(59, 94);
            this.pnlCardClientes.Name = "pnlCardClientes";
            this.pnlCardClientes.Size = new System.Drawing.Size(240, 90);
            this.pnlCardClientes.TabIndex = 1;
            // 
            // lblClientesIcono
            // 
            this.lblClientesIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblClientesIcono.Location = new System.Drawing.Point(186, 36);
            this.lblClientesIcono.Name = "lblClientesIcono";
            this.lblClientesIcono.Size = new System.Drawing.Size(38, 35);
            this.lblClientesIcono.TabIndex = 0;
            this.lblClientesIcono.Text = "👤";
            // 
            // lblClientesValor
            // 
            this.lblClientesValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesValor.Location = new System.Drawing.Point(15, 40);
            this.lblClientesValor.Name = "lblClientesValor";
            this.lblClientesValor.Size = new System.Drawing.Size(165, 31);
            this.lblClientesValor.TabIndex = 1;
            this.lblClientesValor.Text = "5";
            // 
            // lblClientesTexto
            // 
            this.lblClientesTexto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesTexto.Location = new System.Drawing.Point(15, 15);
            this.lblClientesTexto.Name = "lblClientesTexto";
            this.lblClientesTexto.Size = new System.Drawing.Size(100, 23);
            this.lblClientesTexto.TabIndex = 2;
            this.lblClientesTexto.Text = "Total Clientes";
            // 
            // pnlCardProductos
            // 
            this.pnlCardProductos.BackColor = System.Drawing.Color.White;
            this.pnlCardProductos.Controls.Add(this.lblProductosIcono);
            this.pnlCardProductos.Controls.Add(this.lblProductosValor);
            this.pnlCardProductos.Controls.Add(this.lblProductosTexto);
            this.pnlCardProductos.Location = new System.Drawing.Point(357, 94);
            this.pnlCardProductos.Name = "pnlCardProductos";
            this.pnlCardProductos.Size = new System.Drawing.Size(240, 90);
            this.pnlCardProductos.TabIndex = 2;
            // 
            // lblProductosIcono
            // 
            this.lblProductosIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblProductosIcono.Location = new System.Drawing.Point(175, 28);
            this.lblProductosIcono.Name = "lblProductosIcono";
            this.lblProductosIcono.Size = new System.Drawing.Size(50, 43);
            this.lblProductosIcono.TabIndex = 0;
            this.lblProductosIcono.Text = "💳";
            // 
            // lblProductosValor
            // 
            this.lblProductosValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosValor.Location = new System.Drawing.Point(15, 40);
            this.lblProductosValor.Name = "lblProductosValor";
            this.lblProductosValor.Size = new System.Drawing.Size(100, 31);
            this.lblProductosValor.TabIndex = 1;
            this.lblProductosValor.Text = "11";
            // 
            // lblProductosTexto
            // 
            this.lblProductosTexto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosTexto.Location = new System.Drawing.Point(15, 15);
            this.lblProductosTexto.Name = "lblProductosTexto";
            this.lblProductosTexto.Size = new System.Drawing.Size(100, 23);
            this.lblProductosTexto.TabIndex = 2;
            this.lblProductosTexto.Text = "Productos Activos";
            // 
            // cmbEstados
            // 
            this.cmbEstados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cmbEstados.Location = new System.Drawing.Point(59, 212);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(194, 29);
            this.cmbEstados.TabIndex = 6;
            this.cmbEstados.Text = "Todos los estados";
            this.cmbEstados.SelectedValueChanged += new System.EventHandler(this.cambiarTabla);
            // 
            // lblDirectorioTitulo
            // 
            this.lblDirectorioTitulo.AutoSize = true;
            this.lblDirectorioTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorioTitulo.Location = new System.Drawing.Point(93, 269);
            this.lblDirectorioTitulo.Name = "lblDirectorioTitulo";
            this.lblDirectorioTitulo.Size = new System.Drawing.Size(175, 21);
            this.lblDirectorioTitulo.TabIndex = 8;
            this.lblDirectorioTitulo.Text = "Directorio de Clientes";
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.tablaUsuarios.Location = new System.Drawing.Point(49, 312);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersVisible = false;
            this.tablaUsuarios.RowHeadersWidth = 40;
            this.tablaUsuarios.RowTemplate.Height = 25;
            this.tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuarios.Size = new System.Drawing.Size(1136, 315);
            this.tablaUsuarios.TabIndex = 9;
            this.tablaUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tablaUsuarios_MouseDoubleClick);
            // 
            // clientYProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.lblDirectorioTitulo);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.pnlCardProductos);
            this.Controls.Add(this.pnlCardClientes);
            this.Controls.Add(this.pnlHeader);
            this.Name = "clientYProduct";
            this.Size = new System.Drawing.Size(1231, 649);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCardClientes.ResumeLayout(false);
            this.pnlCardProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.DataGridView tablaUsuarios;
    }
}