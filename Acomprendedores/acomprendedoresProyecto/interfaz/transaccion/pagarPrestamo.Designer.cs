namespace acomprendedoresProyecto.ui.transaccion
{
    partial class pagarPrestamo
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.txtCodigoCartera = new System.Windows.Forms.TextBox();
            this.lblCodigoCartera = new System.Windows.Forms.Label();
            this.btnRealizarPago = new System.Windows.Forms.Button();
            this.lblCuentaPago = new System.Windows.Forms.Label();
            this.cmbCuentaPago = new System.Windows.Forms.ComboBox();
            this.panelMontoDisplay = new System.Windows.Forms.Panel();
            this.lblMontoValor = new System.Windows.Forms.Label();
            this.lblMontoTitulo = new System.Windows.Forms.Label();
            this.panelMontoPersonalizado = new System.Windows.Forms.Panel();
            this.txtMontoPersonalizado = new System.Windows.Forms.TextBox();
            this.lblMontoPersonalizado = new System.Windows.Forms.Label();
            this.panelOpcionesPago = new System.Windows.Forms.Panel();
            this.radioOtro = new System.Windows.Forms.RadioButton();
            this.lblOtroMonto = new System.Windows.Forms.Label();
            this.lblOtro = new System.Windows.Forms.Label();
            this.radioTotal = new System.Windows.Forms.RadioButton();
            this.lblTotalMonto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.radioCuota = new System.Windows.Forms.RadioButton();
            this.lblCuotaMonto = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.radioMinimo = new System.Windows.Forms.RadioButton();
            this.lblMinimoMonto = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblOpcionesPago = new System.Windows.Forms.Label();
            this.panelInfoPrestamo = new System.Windows.Forms.Panel();
            this.lblTasaInteresValor = new System.Windows.Forms.Label();
            this.lblTasaInteres = new System.Windows.Forms.Label();
            this.lblFechaLimiteValor = new System.Windows.Forms.Label();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.lblCuotaMensualValor = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblSaldoPendienteValor = new System.Windows.Forms.Label();
            this.lblSaldoPendiente = new System.Windows.Forms.Label();
            this.lblMontoOriginalValor = new System.Windows.Forms.Label();
            this.lblMontoOriginal = new System.Windows.Forms.Label();
            this.lblTipoPrestamoValor = new System.Windows.Forms.Label();
            this.lblTipoPrestamo = new System.Windows.Forms.Label();
            this.lblDetallesPrestamo = new System.Windows.Forms.Label();
            this.lblSeleccionePrestamo = new System.Windows.Forms.Label();
            this.cmbPrestamo = new System.Windows.Forms.ComboBox();
            this.lblMisPrestamos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelMontoDisplay.SuspendLayout();
            this.panelMontoPersonalizado.SuspendLayout();
            this.panelOpcionesPago.SuspendLayout();
            this.panelInfoPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Controls.Add(this.txtCodigoCartera);
            this.panelContainer.Controls.Add(this.lblCodigoCartera);
            this.panelContainer.Controls.Add(this.btnRealizarPago);
            this.panelContainer.Controls.Add(this.lblCuentaPago);
            this.panelContainer.Controls.Add(this.cmbCuentaPago);
            this.panelContainer.Controls.Add(this.panelMontoDisplay);
            this.panelContainer.Controls.Add(this.panelMontoPersonalizado);
            this.panelContainer.Controls.Add(this.panelOpcionesPago);
            this.panelContainer.Controls.Add(this.lblOpcionesPago);
            this.panelContainer.Controls.Add(this.panelInfoPrestamo);
            this.panelContainer.Controls.Add(this.lblSeleccionePrestamo);
            this.panelContainer.Controls.Add(this.cmbPrestamo);
            this.panelContainer.Controls.Add(this.lblMisPrestamos);
            this.panelContainer.Controls.Add(this.lblTitulo);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1183, 540);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // txtCodigoCartera
            // 
            this.txtCodigoCartera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoCartera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoCartera.Location = new System.Drawing.Point(710, 135);
            this.txtCodigoCartera.Name = "txtCodigoCartera";
            this.txtCodigoCartera.ReadOnly = true;
            this.txtCodigoCartera.Size = new System.Drawing.Size(409, 25);
            this.txtCodigoCartera.TabIndex = 18;
            // 
            // lblCodigoCartera
            // 
            this.lblCodigoCartera.AutoSize = true;
            this.lblCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCartera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCodigoCartera.Location = new System.Drawing.Point(758, 111);
            this.lblCodigoCartera.Name = "lblCodigoCartera";
            this.lblCodigoCartera.Size = new System.Drawing.Size(208, 19);
            this.lblCodigoCartera.TabIndex = 17;
            this.lblCodigoCartera.Text = "Código de Cartera del Cliente";
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.btnRealizarPago.FlatAppearance.BorderSize = 0;
            this.btnRealizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRealizarPago.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPago.Location = new System.Drawing.Point(930, 480);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(180, 38);
            this.btnRealizarPago.TabIndex = 16;
            this.btnRealizarPago.Text = "Realizar Pago";
            this.btnRealizarPago.UseVisualStyleBackColor = false;
            this.btnRealizarPago.Click += new System.EventHandler(this.btnRealizarPago_Click);
            // 
            // lblCuentaPago
            // 
            this.lblCuentaPago.AutoSize = true;
            this.lblCuentaPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCuentaPago.ForeColor = System.Drawing.Color.Black;
            this.lblCuentaPago.Location = new System.Drawing.Point(29, 179);
            this.lblCuentaPago.Name = "lblCuentaPago";
            this.lblCuentaPago.Size = new System.Drawing.Size(116, 15);
            this.lblCuentaPago.TabIndex = 12;
            this.lblCuentaPago.Text = "Cuenta para el Pago";
            // 
            // cmbCuentaPago
            // 
            this.cmbCuentaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCuentaPago.FormattingEnabled = true;
            this.cmbCuentaPago.Location = new System.Drawing.Point(29, 204);
            this.cmbCuentaPago.Name = "cmbCuentaPago";
            this.cmbCuentaPago.Size = new System.Drawing.Size(653, 23);
            this.cmbCuentaPago.TabIndex = 11;
            // 
            // panelMontoDisplay
            // 
            this.panelMontoDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMontoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMontoDisplay.Controls.Add(this.lblMontoValor);
            this.panelMontoDisplay.Controls.Add(this.lblMontoTitulo);
            this.panelMontoDisplay.Location = new System.Drawing.Point(35, 432);
            this.panelMontoDisplay.Name = "panelMontoDisplay";
            this.panelMontoDisplay.Size = new System.Drawing.Size(650, 86);
            this.panelMontoDisplay.TabIndex = 10;
            this.panelMontoDisplay.Visible = false;
            // 
            // lblMontoValor
            // 
            this.lblMontoValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMontoValor.ForeColor = System.Drawing.Color.Black;
            this.lblMontoValor.Location = new System.Drawing.Point(0, 35);
            this.lblMontoValor.Name = "lblMontoValor";
            this.lblMontoValor.Size = new System.Drawing.Size(648, 40);
            this.lblMontoValor.TabIndex = 1;
            this.lblMontoValor.Text = "$0.00";
            this.lblMontoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoTitulo
            // 
            this.lblMontoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMontoTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblMontoTitulo.Location = new System.Drawing.Point(0, 12);
            this.lblMontoTitulo.Name = "lblMontoTitulo";
            this.lblMontoTitulo.Size = new System.Drawing.Size(648, 18);
            this.lblMontoTitulo.TabIndex = 0;
            this.lblMontoTitulo.Text = "Monto a pagar";
            this.lblMontoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMontoPersonalizado
            // 
            this.panelMontoPersonalizado.Controls.Add(this.txtMontoPersonalizado);
            this.panelMontoPersonalizado.Controls.Add(this.lblMontoPersonalizado);
            this.panelMontoPersonalizado.Location = new System.Drawing.Point(35, 360);
            this.panelMontoPersonalizado.Name = "panelMontoPersonalizado";
            this.panelMontoPersonalizado.Size = new System.Drawing.Size(650, 60);
            this.panelMontoPersonalizado.TabIndex = 9;
            this.panelMontoPersonalizado.Visible = false;
            // 
            // txtMontoPersonalizado
            // 
            this.txtMontoPersonalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoPersonalizado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontoPersonalizado.Location = new System.Drawing.Point(20, 25);
            this.txtMontoPersonalizado.Name = "txtMontoPersonalizado";
            this.txtMontoPersonalizado.Size = new System.Drawing.Size(579, 23);
            this.txtMontoPersonalizado.TabIndex = 1;
            // 
            // lblMontoPersonalizado
            // 
            this.lblMontoPersonalizado.AutoSize = true;
            this.lblMontoPersonalizado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMontoPersonalizado.ForeColor = System.Drawing.Color.Black;
            this.lblMontoPersonalizado.Location = new System.Drawing.Point(17, 7);
            this.lblMontoPersonalizado.Name = "lblMontoPersonalizado";
            this.lblMontoPersonalizado.Size = new System.Drawing.Size(120, 15);
            this.lblMontoPersonalizado.TabIndex = 0;
            this.lblMontoPersonalizado.Text = "Ingrese el Monto ($)";
            // 
            // panelOpcionesPago
            // 
            this.panelOpcionesPago.Controls.Add(this.radioOtro);
            this.panelOpcionesPago.Controls.Add(this.lblOtroMonto);
            this.panelOpcionesPago.Controls.Add(this.lblOtro);
            this.panelOpcionesPago.Controls.Add(this.radioTotal);
            this.panelOpcionesPago.Controls.Add(this.lblTotalMonto);
            this.panelOpcionesPago.Controls.Add(this.lblTotal);
            this.panelOpcionesPago.Controls.Add(this.radioCuota);
            this.panelOpcionesPago.Controls.Add(this.lblCuotaMonto);
            this.panelOpcionesPago.Controls.Add(this.lblCuota);
            this.panelOpcionesPago.Controls.Add(this.radioMinimo);
            this.panelOpcionesPago.Controls.Add(this.lblMinimoMonto);
            this.panelOpcionesPago.Controls.Add(this.lblMinimo);
            this.panelOpcionesPago.Location = new System.Drawing.Point(32, 264);
            this.panelOpcionesPago.Name = "panelOpcionesPago";
            this.panelOpcionesPago.Size = new System.Drawing.Size(650, 90);
            this.panelOpcionesPago.TabIndex = 8;
            this.panelOpcionesPago.Visible = false;
            // 
            // radioOtro
            // 
            this.radioOtro.AutoSize = true;
            this.radioOtro.Location = new System.Drawing.Point(500, 22);
            this.radioOtro.Name = "radioOtro";
            this.radioOtro.Size = new System.Drawing.Size(14, 13);
            this.radioOtro.TabIndex = 11;
            this.radioOtro.TabStop = true;
            this.radioOtro.UseVisualStyleBackColor = true;
            this.radioOtro.CheckedChanged += new System.EventHandler(this.radioOtro_CheckedChanged);
            // 
            // lblOtroMonto
            // 
            this.lblOtroMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOtroMonto.ForeColor = System.Drawing.Color.Black;
            this.lblOtroMonto.Location = new System.Drawing.Point(479, 40);
            this.lblOtroMonto.Name = "lblOtroMonto";
            this.lblOtroMonto.Size = new System.Drawing.Size(150, 25);
            this.lblOtroMonto.TabIndex = 10;
            this.lblOtroMonto.Text = "Personalizado";
            this.lblOtroMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtro
            // 
            this.lblOtro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOtro.ForeColor = System.Drawing.Color.Black;
            this.lblOtro.Location = new System.Drawing.Point(520, 15);
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(109, 25);
            this.lblOtro.TabIndex = 9;
            this.lblOtro.Text = "Otro Monto";
            this.lblOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioTotal
            // 
            this.radioTotal.AutoSize = true;
            this.radioTotal.Location = new System.Drawing.Point(338, 22);
            this.radioTotal.Name = "radioTotal";
            this.radioTotal.Size = new System.Drawing.Size(14, 13);
            this.radioTotal.TabIndex = 8;
            this.radioTotal.TabStop = true;
            this.radioTotal.UseVisualStyleBackColor = true;
            // 
            // lblTotalMonto
            // 
            this.lblTotalMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalMonto.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMonto.Location = new System.Drawing.Point(319, 40);
            this.lblTotalMonto.Name = "lblTotalMonto";
            this.lblTotalMonto.Size = new System.Drawing.Size(150, 25);
            this.lblTotalMonto.TabIndex = 7;
            this.lblTotalMonto.Text = "$0.00";
            this.lblTotalMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(358, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Pago Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioCuota
            // 
            this.radioCuota.AutoSize = true;
            this.radioCuota.Location = new System.Drawing.Point(183, 24);
            this.radioCuota.Name = "radioCuota";
            this.radioCuota.Size = new System.Drawing.Size(14, 13);
            this.radioCuota.TabIndex = 5;
            this.radioCuota.TabStop = true;
            this.radioCuota.UseVisualStyleBackColor = true;
            // 
            // lblCuotaMonto
            // 
            this.lblCuotaMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCuotaMonto.ForeColor = System.Drawing.Color.Black;
            this.lblCuotaMonto.Location = new System.Drawing.Point(159, 40);
            this.lblCuotaMonto.Name = "lblCuotaMonto";
            this.lblCuotaMonto.Size = new System.Drawing.Size(150, 25);
            this.lblCuotaMonto.TabIndex = 4;
            this.lblCuotaMonto.Text = "$0.00";
            this.lblCuotaMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuota
            // 
            this.lblCuota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCuota.ForeColor = System.Drawing.Color.Black;
            this.lblCuota.Location = new System.Drawing.Point(203, 15);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(106, 25);
            this.lblCuota.TabIndex = 3;
            this.lblCuota.Text = " Cuota Mensual";
            this.lblCuota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioMinimo
            // 
            this.radioMinimo.AutoSize = true;
            this.radioMinimo.Location = new System.Drawing.Point(23, 22);
            this.radioMinimo.Name = "radioMinimo";
            this.radioMinimo.Size = new System.Drawing.Size(14, 13);
            this.radioMinimo.TabIndex = 2;
            this.radioMinimo.TabStop = true;
            this.radioMinimo.UseVisualStyleBackColor = true;
            // 
            // lblMinimoMonto
            // 
            this.lblMinimoMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMinimoMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMinimoMonto.Location = new System.Drawing.Point(23, 40);
            this.lblMinimoMonto.Name = "lblMinimoMonto";
            this.lblMinimoMonto.Size = new System.Drawing.Size(126, 25);
            this.lblMinimoMonto.TabIndex = 1;
            this.lblMinimoMonto.Text = "$0.00";
            this.lblMinimoMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinimo
            // 
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMinimo.ForeColor = System.Drawing.Color.Black;
            this.lblMinimo.Location = new System.Drawing.Point(34, 15);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(95, 25);
            this.lblMinimo.TabIndex = 0;
            this.lblMinimo.Text = "Pago Mínimo";
            this.lblMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpcionesPago
            // 
            this.lblOpcionesPago.AutoSize = true;
            this.lblOpcionesPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOpcionesPago.ForeColor = System.Drawing.Color.Black;
            this.lblOpcionesPago.Location = new System.Drawing.Point(32, 239);
            this.lblOpcionesPago.Name = "lblOpcionesPago";
            this.lblOpcionesPago.Size = new System.Drawing.Size(105, 15);
            this.lblOpcionesPago.TabIndex = 7;
            this.lblOpcionesPago.Text = "Opciones de Pago";
            this.lblOpcionesPago.Visible = false;
            // 
            // panelInfoPrestamo
            // 
            this.panelInfoPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelInfoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfoPrestamo.Controls.Add(this.lblTasaInteresValor);
            this.panelInfoPrestamo.Controls.Add(this.lblTasaInteres);
            this.panelInfoPrestamo.Controls.Add(this.lblFechaLimiteValor);
            this.panelInfoPrestamo.Controls.Add(this.lblFechaLimite);
            this.panelInfoPrestamo.Controls.Add(this.lblCuotaMensualValor);
            this.panelInfoPrestamo.Controls.Add(this.lblCuotaMensual);
            this.panelInfoPrestamo.Controls.Add(this.lblSaldoPendienteValor);
            this.panelInfoPrestamo.Controls.Add(this.lblSaldoPendiente);
            this.panelInfoPrestamo.Controls.Add(this.lblMontoOriginalValor);
            this.panelInfoPrestamo.Controls.Add(this.lblMontoOriginal);
            this.panelInfoPrestamo.Controls.Add(this.lblTipoPrestamoValor);
            this.panelInfoPrestamo.Controls.Add(this.lblTipoPrestamo);
            this.panelInfoPrestamo.Controls.Add(this.lblDetallesPrestamo);
            this.panelInfoPrestamo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfoPrestamo.Location = new System.Drawing.Point(710, 239);
            this.panelInfoPrestamo.Name = "panelInfoPrestamo";
            this.panelInfoPrestamo.Size = new System.Drawing.Size(454, 200);
            this.panelInfoPrestamo.TabIndex = 6;
            this.panelInfoPrestamo.Visible = false;
            // 
            // lblTasaInteresValor
            // 
            this.lblTasaInteresValor.AutoSize = true;
            this.lblTasaInteresValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTasaInteresValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTasaInteresValor.Location = new System.Drawing.Point(333, 168);
            this.lblTasaInteresValor.Name = "lblTasaInteresValor";
            this.lblTasaInteresValor.Size = new System.Drawing.Size(23, 15);
            this.lblTasaInteresValor.TabIndex = 12;
            this.lblTasaInteresValor.Text = "0%";
            // 
            // lblTasaInteres
            // 
            this.lblTasaInteres.AutoSize = true;
            this.lblTasaInteres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTasaInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTasaInteres.Location = new System.Drawing.Point(15, 168);
            this.lblTasaInteres.Name = "lblTasaInteres";
            this.lblTasaInteres.Size = new System.Drawing.Size(87, 15);
            this.lblTasaInteres.TabIndex = 11;
            this.lblTasaInteres.Text = "Tasa de Interés:";
            // 
            // lblFechaLimiteValor
            // 
            this.lblFechaLimiteValor.AutoSize = true;
            this.lblFechaLimiteValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaLimiteValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaLimiteValor.Location = new System.Drawing.Point(308, 143);
            this.lblFechaLimiteValor.Name = "lblFechaLimiteValor";
            this.lblFechaLimiteValor.Size = new System.Drawing.Size(12, 15);
            this.lblFechaLimiteValor.TabIndex = 10;
            this.lblFechaLimiteValor.Text = "-";
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblFechaLimite.Location = new System.Drawing.Point(15, 143);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(123, 15);
            this.lblFechaLimite.TabIndex = 9;
            this.lblFechaLimite.Text = "Fecha Límite de Pago:";
            // 
            // lblCuotaMensualValor
            // 
            this.lblCuotaMensualValor.AutoSize = true;
            this.lblCuotaMensualValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuotaMensualValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCuotaMensualValor.Location = new System.Drawing.Point(318, 118);
            this.lblCuotaMensualValor.Name = "lblCuotaMensualValor";
            this.lblCuotaMensualValor.Size = new System.Drawing.Size(34, 15);
            this.lblCuotaMensualValor.TabIndex = 8;
            this.lblCuotaMensualValor.Text = "$0.00";
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuotaMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCuotaMensual.Location = new System.Drawing.Point(15, 118);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(90, 15);
            this.lblCuotaMensual.TabIndex = 7;
            this.lblCuotaMensual.Text = "Cuota Mensual:";
            // 
            // lblSaldoPendienteValor
            // 
            this.lblSaldoPendienteValor.AutoSize = true;
            this.lblSaldoPendienteValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSaldoPendienteValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSaldoPendienteValor.Location = new System.Drawing.Point(318, 93);
            this.lblSaldoPendienteValor.Name = "lblSaldoPendienteValor";
            this.lblSaldoPendienteValor.Size = new System.Drawing.Size(38, 15);
            this.lblSaldoPendienteValor.TabIndex = 6;
            this.lblSaldoPendienteValor.Text = "$0.00";
            // 
            // lblSaldoPendiente
            // 
            this.lblSaldoPendiente.AutoSize = true;
            this.lblSaldoPendiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaldoPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSaldoPendiente.Location = new System.Drawing.Point(15, 93);
            this.lblSaldoPendiente.Name = "lblSaldoPendiente";
            this.lblSaldoPendiente.Size = new System.Drawing.Size(95, 15);
            this.lblSaldoPendiente.TabIndex = 5;
            this.lblSaldoPendiente.Text = "Saldo Pendiente:";
            // 
            // lblMontoOriginalValor
            // 
            this.lblMontoOriginalValor.AutoSize = true;
            this.lblMontoOriginalValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMontoOriginalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMontoOriginalValor.Location = new System.Drawing.Point(318, 68);
            this.lblMontoOriginalValor.Name = "lblMontoOriginalValor";
            this.lblMontoOriginalValor.Size = new System.Drawing.Size(34, 15);
            this.lblMontoOriginalValor.TabIndex = 4;
            this.lblMontoOriginalValor.Text = "$0.00";
            // 
            // lblMontoOriginal
            // 
            this.lblMontoOriginal.AutoSize = true;
            this.lblMontoOriginal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMontoOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMontoOriginal.Location = new System.Drawing.Point(15, 68);
            this.lblMontoOriginal.Name = "lblMontoOriginal";
            this.lblMontoOriginal.Size = new System.Drawing.Size(91, 15);
            this.lblMontoOriginal.TabIndex = 3;
            this.lblMontoOriginal.Text = "Monto Original:";
            // 
            // lblTipoPrestamoValor
            // 
            this.lblTipoPrestamoValor.AutoSize = true;
            this.lblTipoPrestamoValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoPrestamoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoPrestamoValor.Location = new System.Drawing.Point(267, 43);
            this.lblTipoPrestamoValor.Name = "lblTipoPrestamoValor";
            this.lblTipoPrestamoValor.Size = new System.Drawing.Size(12, 15);
            this.lblTipoPrestamoValor.TabIndex = 2;
            this.lblTipoPrestamoValor.Text = "-";
            // 
            // lblTipoPrestamo
            // 
            this.lblTipoPrestamo.AutoSize = true;
            this.lblTipoPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTipoPrestamo.Location = new System.Drawing.Point(15, 43);
            this.lblTipoPrestamo.Name = "lblTipoPrestamo";
            this.lblTipoPrestamo.Size = new System.Drawing.Size(103, 15);
            this.lblTipoPrestamo.TabIndex = 1;
            this.lblTipoPrestamo.Text = "Tipo de Préstamo:";
            // 
            // lblDetallesPrestamo
            // 
            this.lblDetallesPrestamo.AutoSize = true;
            this.lblDetallesPrestamo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetallesPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.lblDetallesPrestamo.Location = new System.Drawing.Point(15, 12);
            this.lblDetallesPrestamo.Name = "lblDetallesPrestamo";
            this.lblDetallesPrestamo.Size = new System.Drawing.Size(179, 19);
            this.lblDetallesPrestamo.TabIndex = 0;
            this.lblDetallesPrestamo.Text = "📊 Detalles del Préstamo";
            // 
            // lblSeleccionePrestamo
            // 
            this.lblSeleccionePrestamo.AutoSize = true;
            this.lblSeleccionePrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionePrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionePrestamo.Location = new System.Drawing.Point(32, 78);
            this.lblSeleccionePrestamo.Name = "lblSeleccionePrestamo";
            this.lblSeleccionePrestamo.Size = new System.Drawing.Size(136, 15);
            this.lblSeleccionePrestamo.TabIndex = 5;
            this.lblSeleccionePrestamo.Text = "Seleccione el Préstamo";
            // 
            // cmbPrestamo
            // 
            this.cmbPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPrestamo.FormattingEnabled = true;
            this.cmbPrestamo.Location = new System.Drawing.Point(35, 135);
            this.cmbPrestamo.Name = "cmbPrestamo";
            this.cmbPrestamo.Size = new System.Drawing.Size(650, 23);
            this.cmbPrestamo.TabIndex = 4;
            this.cmbPrestamo.SelectedIndexChanged += new System.EventHandler(this.prestamo);
            // 
            // lblMisPrestamos
            // 
            this.lblMisPrestamos.AutoSize = true;
            this.lblMisPrestamos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMisPrestamos.ForeColor = System.Drawing.Color.Black;
            this.lblMisPrestamos.Location = new System.Drawing.Point(32, 106);
            this.lblMisPrestamos.Name = "lblMisPrestamos";
            this.lblMisPrestamos.Size = new System.Drawing.Size(87, 15);
            this.lblMisPrestamos.TabIndex = 3;
            this.lblMisPrestamos.Text = "Mis Préstamos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(38, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "🏦 Pagar Préstamo";
            // 
            // pagarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
            this.Name = "pagarPrestamo";
            this.Size = new System.Drawing.Size(1183, 540);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelMontoDisplay.ResumeLayout(false);
            this.panelMontoPersonalizado.ResumeLayout(false);
            this.panelMontoPersonalizado.PerformLayout();
            this.panelOpcionesPago.ResumeLayout(false);
            this.panelOpcionesPago.PerformLayout();
            this.panelInfoPrestamo.ResumeLayout(false);
            this.panelInfoPrestamo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMisPrestamos;
        private System.Windows.Forms.ComboBox cmbPrestamo;
        private System.Windows.Forms.Label lblSeleccionePrestamo;
        private System.Windows.Forms.Panel panelInfoPrestamo;
        private System.Windows.Forms.Label lblDetallesPrestamo;
        private System.Windows.Forms.Label lblTipoPrestamo;
        private System.Windows.Forms.Label lblTipoPrestamoValor;
        private System.Windows.Forms.Label lblMontoOriginal;
        private System.Windows.Forms.Label lblMontoOriginalValor;
        private System.Windows.Forms.Label lblSaldoPendiente;
        private System.Windows.Forms.Label lblSaldoPendienteValor;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label lblCuotaMensualValor;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.Label lblFechaLimiteValor;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.Label lblTasaInteresValor;
        private System.Windows.Forms.Label lblOpcionesPago;
        private System.Windows.Forms.Panel panelOpcionesPago;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMinimoMonto;
        private System.Windows.Forms.RadioButton radioMinimo;
        private System.Windows.Forms.RadioButton radioCuota;
        private System.Windows.Forms.Label lblCuotaMonto;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.RadioButton radioTotal;
        private System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton radioOtro;
        private System.Windows.Forms.Label lblOtroMonto;
        private System.Windows.Forms.Label lblOtro;
        private System.Windows.Forms.Panel panelMontoPersonalizado;
        private System.Windows.Forms.Label lblMontoPersonalizado;
        private System.Windows.Forms.TextBox txtMontoPersonalizado;
        private System.Windows.Forms.Panel panelMontoDisplay;
        private System.Windows.Forms.Label lblMontoTitulo;
        private System.Windows.Forms.Label lblMontoValor;
        private System.Windows.Forms.ComboBox cmbCuentaPago;
        private System.Windows.Forms.Label lblCuentaPago;
        private System.Windows.Forms.Button btnRealizarPago;
        private System.Windows.Forms.TextBox txtCodigoCartera;
        private System.Windows.Forms.Label lblCodigoCartera;
    }
}