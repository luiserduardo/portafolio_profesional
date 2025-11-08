namespace acomprendedoresProyecto.ui.transaccion
{
    partial class transferencia
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtCodigoCartera = new System.Windows.Forms.TextBox();
            this.lblCodigoCartera = new System.Windows.Forms.Label();
            this.lblSeccionOrigen = new System.Windows.Forms.Label();
            this.cmbCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.lblCuentaOrigen = new System.Windows.Forms.Label();
            this.groupBoxInfoOrigen = new System.Windows.Forms.GroupBox();
            this.lblSaldoOrigenValor = new System.Windows.Forms.Label();
            this.lblTipoOrigenValor = new System.Windows.Forms.Label();
            this.lblSaldoOrigen = new System.Windows.Forms.Label();
            this.lblTipoOrigen = new System.Windows.Forms.Label();
            this.lblSeccionDestino = new System.Windows.Forms.Label();
            this.lblTipoBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.groupBoxInfoDestino = new System.Windows.Forms.GroupBox();
            this.lblTipoCuentaDestinoValor = new System.Windows.Forms.Label();
            this.lblNumeroCuentaDestinoValor = new System.Windows.Forms.Label();
            this.lblTitularDestinoValor = new System.Windows.Forms.Label();
            this.lblTipoCuentaDestino = new System.Windows.Forms.Label();
            this.lblNumeroCuentaDestino = new System.Windows.Forms.Label();
            this.lblTitularDestino = new System.Windows.Forms.Label();
            this.lblSeccionDetalles = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.panelMontoDisplay = new System.Windows.Forms.Panel();
            this.lblMontoDisplayValor = new System.Windows.Forms.Label();
            this.lblMontoDisplayTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbCuentaDestino = new System.Windows.Forms.ComboBox();
            this.groupBoxInfoOrigen.SuspendLayout();
            this.groupBoxInfoDestino.SuspendLayout();
            this.panelMontoDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(40, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💳 Realizar Transferencia";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(40, 40);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Transfiera dinero entre cuentas de forma segura";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigoCartera
            // 
            this.txtCodigoCartera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoCartera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoCartera.Location = new System.Drawing.Point(50, 111);
            this.txtCodigoCartera.Name = "txtCodigoCartera";
            this.txtCodigoCartera.ReadOnly = true;
            this.txtCodigoCartera.Size = new System.Drawing.Size(400, 25);
            this.txtCodigoCartera.TabIndex = 3;
            // 
            // lblCodigoCartera
            // 
            this.lblCodigoCartera.AutoSize = true;
            this.lblCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCartera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCodigoCartera.Location = new System.Drawing.Point(50, 89);
            this.lblCodigoCartera.Name = "lblCodigoCartera";
            this.lblCodigoCartera.Size = new System.Drawing.Size(208, 19);
            this.lblCodigoCartera.TabIndex = 2;
            this.lblCodigoCartera.Text = "Código de Cartera del Cliente";
            // 
            // lblSeccionOrigen
            // 
            this.lblSeccionOrigen.AutoSize = true;
            this.lblSeccionOrigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeccionOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSeccionOrigen.Location = new System.Drawing.Point(50, 175);
            this.lblSeccionOrigen.Name = "lblSeccionOrigen";
            this.lblSeccionOrigen.Size = new System.Drawing.Size(170, 21);
            this.lblSeccionOrigen.TabIndex = 4;
            this.lblSeccionOrigen.Text = "📤 Cuenta de Origen";
            // 
            // cmbCuentaOrigen
            // 
            this.cmbCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaOrigen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCuentaOrigen.FormattingEnabled = true;
            this.cmbCuentaOrigen.Location = new System.Drawing.Point(50, 230);
            this.cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            this.cmbCuentaOrigen.Size = new System.Drawing.Size(400, 28);
            this.cmbCuentaOrigen.TabIndex = 6;
            this.cmbCuentaOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbCuentaOrigen_SelectedIndexChanged_1);
            // 
            // lblCuentaOrigen
            // 
            this.lblCuentaOrigen.AutoSize = true;
            this.lblCuentaOrigen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCuentaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCuentaOrigen.Location = new System.Drawing.Point(50, 207);
            this.lblCuentaOrigen.Name = "lblCuentaOrigen";
            this.lblCuentaOrigen.Size = new System.Drawing.Size(213, 19);
            this.lblCuentaOrigen.TabIndex = 5;
            this.lblCuentaOrigen.Text = "Seleccione la cuenta de origen";
            // 
            // groupBoxInfoOrigen
            // 
            this.groupBoxInfoOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupBoxInfoOrigen.Controls.Add(this.lblSaldoOrigenValor);
            this.groupBoxInfoOrigen.Controls.Add(this.lblTipoOrigenValor);
            this.groupBoxInfoOrigen.Controls.Add(this.lblSaldoOrigen);
            this.groupBoxInfoOrigen.Controls.Add(this.lblTipoOrigen);
            this.groupBoxInfoOrigen.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBoxInfoOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.groupBoxInfoOrigen.Location = new System.Drawing.Point(50, 273);
            this.groupBoxInfoOrigen.Name = "groupBoxInfoOrigen";
            this.groupBoxInfoOrigen.Size = new System.Drawing.Size(400, 85);
            this.groupBoxInfoOrigen.TabIndex = 7;
            this.groupBoxInfoOrigen.TabStop = false;
            this.groupBoxInfoOrigen.Text = "Información de Cuenta Origen";
            this.groupBoxInfoOrigen.Visible = false;
            // 
            // lblSaldoOrigenValor
            // 
            this.lblSaldoOrigenValor.AutoSize = true;
            this.lblSaldoOrigenValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaldoOrigenValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSaldoOrigenValor.Location = new System.Drawing.Point(155, 50);
            this.lblSaldoOrigenValor.Name = "lblSaldoOrigenValor";
            this.lblSaldoOrigenValor.Size = new System.Drawing.Size(34, 15);
            this.lblSaldoOrigenValor.TabIndex = 3;
            this.lblSaldoOrigenValor.Text = "$0.00";
            // 
            // lblTipoOrigenValor
            // 
            this.lblTipoOrigenValor.AutoSize = true;
            this.lblTipoOrigenValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoOrigenValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTipoOrigenValor.Location = new System.Drawing.Point(155, 28);
            this.lblTipoOrigenValor.Name = "lblTipoOrigenValor";
            this.lblTipoOrigenValor.Size = new System.Drawing.Size(12, 15);
            this.lblTipoOrigenValor.TabIndex = 2;
            this.lblTipoOrigenValor.Text = "-";
            // 
            // lblSaldoOrigen
            // 
            this.lblSaldoOrigen.AutoSize = true;
            this.lblSaldoOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSaldoOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSaldoOrigen.Location = new System.Drawing.Point(15, 50);
            this.lblSaldoOrigen.Name = "lblSaldoOrigen";
            this.lblSaldoOrigen.Size = new System.Drawing.Size(101, 15);
            this.lblSaldoOrigen.TabIndex = 1;
            this.lblSaldoOrigen.Text = "Saldo Disponible:";
            // 
            // lblTipoOrigen
            // 
            this.lblTipoOrigen.AutoSize = true;
            this.lblTipoOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTipoOrigen.Location = new System.Drawing.Point(15, 28);
            this.lblTipoOrigen.Name = "lblTipoOrigen";
            this.lblTipoOrigen.Size = new System.Drawing.Size(34, 15);
            this.lblTipoOrigen.TabIndex = 0;
            this.lblTipoOrigen.Text = "Tipo:";
            // 
            // lblSeccionDestino
            // 
            this.lblSeccionDestino.AutoSize = true;
            this.lblSeccionDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeccionDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSeccionDestino.Location = new System.Drawing.Point(558, 19);
            this.lblSeccionDestino.Name = "lblSeccionDestino";
            this.lblSeccionDestino.Size = new System.Drawing.Size(177, 21);
            this.lblSeccionDestino.TabIndex = 9;
            this.lblSeccionDestino.Text = "📥 Cuenta de Destino";
            // 
            // lblTipoBusqueda
            // 
            this.lblTipoBusqueda.AutoSize = true;
            this.lblTipoBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTipoBusqueda.Location = new System.Drawing.Point(558, 51);
            this.lblTipoBusqueda.Name = "lblTipoBusqueda";
            this.lblTipoBusqueda.Size = new System.Drawing.Size(134, 19);
            this.lblTipoBusqueda.TabIndex = 10;
            this.lblTipoBusqueda.Text = "Buscar cuenta por:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBusqueda.Location = new System.Drawing.Point(558, 199);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(400, 27);
            this.txtBusqueda.TabIndex = 13;
            this.txtBusqueda.Visible = false;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblBusqueda.Location = new System.Drawing.Point(558, 177);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(113, 19);
            this.lblBusqueda.TabIndex = 12;
            this.lblBusqueda.Text = "Ingrese el dato:";
            this.lblBusqueda.Visible = false;
            // 
            // groupBoxInfoDestino
            // 
            this.groupBoxInfoDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupBoxInfoDestino.Controls.Add(this.lblTipoCuentaDestinoValor);
            this.groupBoxInfoDestino.Controls.Add(this.lblNumeroCuentaDestinoValor);
            this.groupBoxInfoDestino.Controls.Add(this.lblTitularDestinoValor);
            this.groupBoxInfoDestino.Controls.Add(this.lblTipoCuentaDestino);
            this.groupBoxInfoDestino.Controls.Add(this.lblNumeroCuentaDestino);
            this.groupBoxInfoDestino.Controls.Add(this.lblTitularDestino);
            this.groupBoxInfoDestino.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBoxInfoDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.groupBoxInfoDestino.Location = new System.Drawing.Point(558, 241);
            this.groupBoxInfoDestino.Name = "groupBoxInfoDestino";
            this.groupBoxInfoDestino.Size = new System.Drawing.Size(400, 110);
            this.groupBoxInfoDestino.TabIndex = 14;
            this.groupBoxInfoDestino.TabStop = false;
            this.groupBoxInfoDestino.Text = "Información de Cuenta Destino";
            this.groupBoxInfoDestino.Visible = false;
            // 
            // lblTipoCuentaDestinoValor
            // 
            this.lblTipoCuentaDestinoValor.AutoSize = true;
            this.lblTipoCuentaDestinoValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoCuentaDestinoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTipoCuentaDestinoValor.Location = new System.Drawing.Point(155, 75);
            this.lblTipoCuentaDestinoValor.Name = "lblTipoCuentaDestinoValor";
            this.lblTipoCuentaDestinoValor.Size = new System.Drawing.Size(12, 15);
            this.lblTipoCuentaDestinoValor.TabIndex = 5;
            this.lblTipoCuentaDestinoValor.Text = "-";
            // 
            // lblNumeroCuentaDestinoValor
            // 
            this.lblNumeroCuentaDestinoValor.AutoSize = true;
            this.lblNumeroCuentaDestinoValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroCuentaDestinoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblNumeroCuentaDestinoValor.Location = new System.Drawing.Point(155, 52);
            this.lblNumeroCuentaDestinoValor.Name = "lblNumeroCuentaDestinoValor";
            this.lblNumeroCuentaDestinoValor.Size = new System.Drawing.Size(12, 15);
            this.lblNumeroCuentaDestinoValor.TabIndex = 4;
            this.lblNumeroCuentaDestinoValor.Text = "-";
            // 
            // lblTitularDestinoValor
            // 
            this.lblTitularDestinoValor.AutoSize = true;
            this.lblTitularDestinoValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitularDestinoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTitularDestinoValor.Location = new System.Drawing.Point(155, 29);
            this.lblTitularDestinoValor.Name = "lblTitularDestinoValor";
            this.lblTitularDestinoValor.Size = new System.Drawing.Size(12, 15);
            this.lblTitularDestinoValor.TabIndex = 3;
            this.lblTitularDestinoValor.Text = "-";
            // 
            // lblTipoCuentaDestino
            // 
            this.lblTipoCuentaDestino.AutoSize = true;
            this.lblTipoCuentaDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoCuentaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTipoCuentaDestino.Location = new System.Drawing.Point(15, 75);
            this.lblTipoCuentaDestino.Name = "lblTipoCuentaDestino";
            this.lblTipoCuentaDestino.Size = new System.Drawing.Size(93, 15);
            this.lblTipoCuentaDestino.TabIndex = 2;
            this.lblTipoCuentaDestino.Text = "Tipo de Cuenta:";
            // 
            // lblNumeroCuentaDestino
            // 
            this.lblNumeroCuentaDestino.AutoSize = true;
            this.lblNumeroCuentaDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumeroCuentaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNumeroCuentaDestino.Location = new System.Drawing.Point(15, 52);
            this.lblNumeroCuentaDestino.Name = "lblNumeroCuentaDestino";
            this.lblNumeroCuentaDestino.Size = new System.Drawing.Size(115, 15);
            this.lblNumeroCuentaDestino.TabIndex = 1;
            this.lblNumeroCuentaDestino.Text = "Número de Cuenta:";
            // 
            // lblTitularDestino
            // 
            this.lblTitularDestino.AutoSize = true;
            this.lblTitularDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitularDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitularDestino.Location = new System.Drawing.Point(15, 29);
            this.lblTitularDestino.Name = "lblTitularDestino";
            this.lblTitularDestino.Size = new System.Drawing.Size(46, 15);
            this.lblTitularDestino.TabIndex = 0;
            this.lblTitularDestino.Text = "Titular:";
            // 
            // lblSeccionDetalles
            // 
            this.lblSeccionDetalles.AutoSize = true;
            this.lblSeccionDetalles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeccionDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSeccionDetalles.Location = new System.Drawing.Point(46, 395);
            this.lblSeccionDetalles.Name = "lblSeccionDetalles";
            this.lblSeccionDetalles.Size = new System.Drawing.Size(246, 21);
            this.lblSeccionDetalles.TabIndex = 15;
            this.lblSeccionDetalles.Text = "💰 Detalles de la Transferencia";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMonto.Location = new System.Drawing.Point(46, 450);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(400, 27);
            this.txtMonto.TabIndex = 17;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMonto.Location = new System.Drawing.Point(46, 428);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(155, 19);
            this.lblMonto.TabIndex = 16;
            this.lblMonto.Text = "Monto a Transferir ($)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescripcion.Location = new System.Drawing.Point(558, 389);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 27);
            this.txtDescripcion.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDescripcion.Location = new System.Drawing.Point(558, 367);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(165, 19);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción / Concepto";
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTransferir.ForeColor = System.Drawing.Color.White;
            this.btnTransferir.Location = new System.Drawing.Point(1013, 473);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(140, 45);
            this.btnTransferir.TabIndex = 22;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            // 
            // panelMontoDisplay
            // 
            this.panelMontoDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.panelMontoDisplay.Controls.Add(this.lblMontoDisplayValor);
            this.panelMontoDisplay.Controls.Add(this.lblMontoDisplayTitulo);
            this.panelMontoDisplay.Location = new System.Drawing.Point(576, 430);
            this.panelMontoDisplay.Name = "panelMontoDisplay";
            this.panelMontoDisplay.Size = new System.Drawing.Size(367, 88);
            this.panelMontoDisplay.TabIndex = 23;
            this.panelMontoDisplay.Visible = false;
            // 
            // lblMontoDisplayValor
            // 
            this.lblMontoDisplayValor.BackColor = System.Drawing.SystemColors.Control;
            this.lblMontoDisplayValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblMontoDisplayValor.ForeColor = System.Drawing.Color.Black;
            this.lblMontoDisplayValor.Location = new System.Drawing.Point(0, 35);
            this.lblMontoDisplayValor.Name = "lblMontoDisplayValor";
            this.lblMontoDisplayValor.Size = new System.Drawing.Size(400, 50);
            this.lblMontoDisplayValor.TabIndex = 1;
            this.lblMontoDisplayValor.Text = "$0.00";
            this.lblMontoDisplayValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoDisplayTitulo
            // 
            this.lblMontoDisplayTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblMontoDisplayTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMontoDisplayTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblMontoDisplayTitulo.Location = new System.Drawing.Point(0, 10);
            this.lblMontoDisplayTitulo.Name = "lblMontoDisplayTitulo";
            this.lblMontoDisplayTitulo.Size = new System.Drawing.Size(400, 20);
            this.lblMontoDisplayTitulo.TabIndex = 0;
            this.lblMontoDisplayTitulo.Text = "Monto a transferir";
            this.lblMontoDisplayTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(558, 78);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 92;
            this.txtBuscar.Text = "Buscar por código o DUI ...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1004, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 30);
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbCuentaDestino
            // 
            this.cmbCuentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaDestino.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCuentaDestino.FormattingEnabled = true;
            this.cmbCuentaDestino.Location = new System.Drawing.Point(562, 132);
            this.cmbCuentaDestino.Name = "cmbCuentaDestino";
            this.cmbCuentaDestino.Size = new System.Drawing.Size(400, 28);
            this.cmbCuentaDestino.TabIndex = 93;
            // 
            // transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cmbCuentaDestino);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelMontoDisplay);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblSeccionDetalles);
            this.Controls.Add(this.groupBoxInfoDestino);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTipoBusqueda);
            this.Controls.Add(this.lblSeccionDestino);
            this.Controls.Add(this.groupBoxInfoOrigen);
            this.Controls.Add(this.cmbCuentaOrigen);
            this.Controls.Add(this.lblCuentaOrigen);
            this.Controls.Add(this.lblSeccionOrigen);
            this.Controls.Add(this.txtCodigoCartera);
            this.Controls.Add(this.lblCodigoCartera);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "transferencia";
            this.Size = new System.Drawing.Size(1183, 540);
            this.Load += new System.EventHandler(this.transferencia_Load);
            this.groupBoxInfoOrigen.ResumeLayout(false);
            this.groupBoxInfoOrigen.PerformLayout();
            this.groupBoxInfoDestino.ResumeLayout(false);
            this.groupBoxInfoDestino.PerformLayout();
            this.panelMontoDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtCodigoCartera;
        private System.Windows.Forms.Label lblCodigoCartera;
        private System.Windows.Forms.Label lblSeccionOrigen;
        private System.Windows.Forms.ComboBox cmbCuentaOrigen;
        private System.Windows.Forms.Label lblCuentaOrigen;
        private System.Windows.Forms.GroupBox groupBoxInfoOrigen;
        private System.Windows.Forms.Label lblSaldoOrigenValor;
        private System.Windows.Forms.Label lblTipoOrigenValor;
        private System.Windows.Forms.Label lblSaldoOrigen;
        private System.Windows.Forms.Label lblTipoOrigen;
        private System.Windows.Forms.Label lblSeccionDestino;
        private System.Windows.Forms.Label lblTipoBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.GroupBox groupBoxInfoDestino;
        private System.Windows.Forms.Label lblTipoCuentaDestinoValor;
        private System.Windows.Forms.Label lblNumeroCuentaDestinoValor;
        private System.Windows.Forms.Label lblTitularDestinoValor;
        private System.Windows.Forms.Label lblTipoCuentaDestino;
        private System.Windows.Forms.Label lblNumeroCuentaDestino;
        private System.Windows.Forms.Label lblTitularDestino;
        private System.Windows.Forms.Label lblSeccionDetalles;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Panel panelMontoDisplay;
        private System.Windows.Forms.Label lblMontoDisplayValor;
        private System.Windows.Forms.Label lblMontoDisplayTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbCuentaDestino;
    }
}