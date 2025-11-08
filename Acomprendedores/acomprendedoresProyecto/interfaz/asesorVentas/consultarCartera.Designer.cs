namespace acomprendedoresProyecto.pantallas.asesorVentas.consultarCartera
{
    partial class consultarCartera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.panelInfoCliente = new System.Windows.Forms.Panel();
            this.lblTelefonoValor = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreoValor = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDUIValor = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoCarteraValor = new System.Windows.Forms.Label();
            this.lblCodigoCartera = new System.Windows.Forms.Label();
            this.lblCodigoValor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelInfoCliente.SuspendLayout();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1327, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consultar Cartera Virtual";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.lblBuscarCliente);
            this.panelBusqueda.Location = new System.Drawing.Point(25, 90);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1286, 90);
            this.panelBusqueda.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(27, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(710, 29);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar por código o DUI ...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(870, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBuscarCliente.Location = new System.Drawing.Point(21, 15);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(103, 19);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Buscar Cliente";
            // 
            // panelInfoCliente
            // 
            this.panelInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelInfoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfoCliente.Controls.Add(this.lblTelefonoValor);
            this.panelInfoCliente.Controls.Add(this.lblTelefono);
            this.panelInfoCliente.Controls.Add(this.lblCorreoValor);
            this.panelInfoCliente.Controls.Add(this.lblCorreo);
            this.panelInfoCliente.Controls.Add(this.lblDUIValor);
            this.panelInfoCliente.Controls.Add(this.lblDUI);
            this.panelInfoCliente.Controls.Add(this.lblNombreValor);
            this.panelInfoCliente.Controls.Add(this.lblNombre);
            this.panelInfoCliente.Controls.Add(this.lblCodigoCarteraValor);
            this.panelInfoCliente.Controls.Add(this.lblCodigoCartera);
            this.panelInfoCliente.Controls.Add(this.lblCodigoValor);
            this.panelInfoCliente.Controls.Add(this.lblCodigo);
            this.panelInfoCliente.Controls.Add(this.lblInfoCliente);
            this.panelInfoCliente.Location = new System.Drawing.Point(25, 200);
            this.panelInfoCliente.Name = "panelInfoCliente";
            this.panelInfoCliente.Size = new System.Drawing.Size(1286, 115);
            this.panelInfoCliente.TabIndex = 2;
            this.panelInfoCliente.Visible = false;
            // 
            // lblTelefonoValor
            // 
            this.lblTelefonoValor.AutoSize = true;
            this.lblTelefonoValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefonoValor.Location = new System.Drawing.Point(819, 77);
            this.lblTelefonoValor.Name = "lblTelefonoValor";
            this.lblTelefonoValor.Size = new System.Drawing.Size(12, 15);
            this.lblTelefonoValor.TabIndex = 12;
            this.lblTelefonoValor.Text = "-";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblTelefono.Location = new System.Drawing.Point(819, 60);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(54, 13);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreoValor
            // 
            this.lblCorreoValor.AutoSize = true;
            this.lblCorreoValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreoValor.Location = new System.Drawing.Point(430, 77);
            this.lblCorreoValor.Name = "lblCorreoValor";
            this.lblCorreoValor.Size = new System.Drawing.Size(12, 15);
            this.lblCorreoValor.TabIndex = 10;
            this.lblCorreoValor.Text = "-";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCorreo.Location = new System.Drawing.Point(430, 60);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(105, 13);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblDUIValor
            // 
            this.lblDUIValor.AutoSize = true;
            this.lblDUIValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDUIValor.Location = new System.Drawing.Point(23, 77);
            this.lblDUIValor.Name = "lblDUIValor";
            this.lblDUIValor.Size = new System.Drawing.Size(12, 15);
            this.lblDUIValor.TabIndex = 8;
            this.lblDUIValor.Text = "-";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblDUI.Location = new System.Drawing.Point(23, 60);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(29, 13);
            this.lblDUI.TabIndex = 7;
            this.lblDUI.Text = "DUI:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreValor.Location = new System.Drawing.Point(430, 38);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(12, 15);
            this.lblNombreValor.TabIndex = 6;
            this.lblNombreValor.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblNombre.Location = new System.Drawing.Point(430, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblCodigoCarteraValor
            // 
            this.lblCodigoCarteraValor.AutoSize = true;
            this.lblCodigoCarteraValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCarteraValor.Location = new System.Drawing.Point(819, 38);
            this.lblCodigoCarteraValor.Name = "lblCodigoCarteraValor";
            this.lblCodigoCarteraValor.Size = new System.Drawing.Size(12, 15);
            this.lblCodigoCarteraValor.TabIndex = 4;
            this.lblCodigoCarteraValor.Text = "-";
            // 
            // lblCodigoCartera
            // 
            this.lblCodigoCartera.AutoSize = true;
            this.lblCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCodigoCartera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCodigoCartera.Location = new System.Drawing.Point(819, 21);
            this.lblCodigoCartera.Name = "lblCodigoCartera";
            this.lblCodigoCartera.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoCartera.TabIndex = 3;
            this.lblCodigoCartera.Text = "Código Cartera:";
            // 
            // lblCodigoValor
            // 
            this.lblCodigoValor.AutoSize = true;
            this.lblCodigoValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigoValor.Location = new System.Drawing.Point(23, 38);
            this.lblCodigoValor.Name = "lblCodigoValor";
            this.lblCodigoValor.Size = new System.Drawing.Size(12, 15);
            this.lblCodigoValor.TabIndex = 2;
            this.lblCodigoValor.Text = "-";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCodigo.Location = new System.Drawing.Point(23, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(48, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblInfoCliente
            // 
            this.lblInfoCliente.AutoSize = true;
            this.lblInfoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblInfoCliente.Location = new System.Drawing.Point(10, 0);
            this.lblInfoCliente.Name = "lblInfoCliente";
            this.lblInfoCliente.Size = new System.Drawing.Size(153, 15);
            this.lblInfoCliente.TabIndex = 0;
            this.lblInfoCliente.Text = "📝 Información del Cliente";
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelProductos.Controls.Add(this.tabla);
            this.panelProductos.Controls.Add(this.button1);
            this.panelProductos.Controls.Add(this.dataGridViewProductos);
            this.panelProductos.Controls.Add(this.btnTarjetas);
            this.panelProductos.Controls.Add(this.btnPrestamos);
            this.panelProductos.Controls.Add(this.btnCuentas);
            this.panelProductos.Controls.Add(this.lblProductos);
            this.panelProductos.Location = new System.Drawing.Point(25, 330);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(1289, 301);
            this.panelProductos.TabIndex = 3;
            this.panelProductos.Visible = false;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.tabla.Location = new System.Drawing.Point(10, 80);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowHeadersWidth = 40;
            this.tabla.RowTemplate.Height = 25;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(1276, 207);
            this.tabla.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(468, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Historial transacción";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(10, 80);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1163, 207);
            this.dataGridViewProductos.TabIndex = 4;
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTarjetas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarjetas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTarjetas.ForeColor = System.Drawing.Color.White;
            this.btnTarjetas.Location = new System.Drawing.Point(310, 35);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(130, 35);
            this.btnTarjetas.TabIndex = 3;
            this.btnTarjetas.Text = "💳 Tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = false;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Location = new System.Drawing.Point(160, 35);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(130, 35);
            this.btnPrestamos.TabIndex = 2;
            this.btnPrestamos.Text = "🏦 Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCuentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCuentas.Location = new System.Drawing.Point(10, 35);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(130, 35);
            this.btnCuentas.TabIndex = 1;
            this.btnCuentas.Text = "💰 Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = false;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProductos.Location = new System.Drawing.Point(6, 10);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(189, 20);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "💼 Productos Financieros";
            // 
            // consultarCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelInfoCliente);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelHeader);
            this.Name = "consultarCartera";
            this.Size = new System.Drawing.Size(1327, 649);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelInfoCliente.ResumeLayout(false);
            this.panelInfoCliente.PerformLayout();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelInfoCliente;
        private System.Windows.Forms.Label lblInfoCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoValor;
        private System.Windows.Forms.Label lblCodigoCartera;
        private System.Windows.Forms.Label lblCodigoCarteraValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblDUIValor;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCorreoValor;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTelefonoValor;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView tabla;
    }
}