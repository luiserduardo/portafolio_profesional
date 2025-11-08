namespace acomprendedoresProyecto.ui.transaccion
{
    partial class deposito
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.txtcodigoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBoxInfoCuenta = new System.Windows.Forms.GroupBox();
            this.lblSaldoActualValor = new System.Windows.Forms.Label();
            this.lblTipoCuentaValor = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtMontoDeposito = new System.Windows.Forms.TextBox();
            this.lblMontoDeposito = new System.Windows.Forms.Label();
            this.cmbNumeroCuenta = new System.Windows.Forms.ComboBox();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.txtCodigoCartera = new System.Windows.Forms.TextBox();
            this.lblCodigoCartera = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelContenido.SuspendLayout();
            this.groupBoxInfoCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(33, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "💰 Realizar Depósito";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenido.Controls.Add(this.txtcodigoCliente);
            this.panelContenido.Controls.Add(this.label1);
            this.panelContenido.Controls.Add(this.btnProcesar);
            this.panelContenido.Controls.Add(this.groupBoxInfoCuenta);
            this.panelContenido.Controls.Add(this.txtDescripcion);
            this.panelContenido.Controls.Add(this.lblDescripcion);
            this.panelContenido.Controls.Add(this.txtMontoDeposito);
            this.panelContenido.Controls.Add(this.lblMontoDeposito);
            this.panelContenido.Controls.Add(this.cmbNumeroCuenta);
            this.panelContenido.Controls.Add(this.lblNumeroCuenta);
            this.panelContenido.Controls.Add(this.txtCodigoCartera);
            this.panelContenido.Controls.Add(this.lblCodigoCartera);
            this.panelContenido.Controls.Add(this.txtCodigoEmpleado);
            this.panelContenido.Controls.Add(this.lblCodigoEmpleado);
            this.panelContenido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenido.Location = new System.Drawing.Point(0, 87);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(34, 26, 34, 26);
            this.panelContenido.Size = new System.Drawing.Size(1180, 431);
            this.panelContenido.TabIndex = 1;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // txtcodigoCliente
            // 
            this.txtcodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcodigoCliente.Location = new System.Drawing.Point(37, 138);
            this.txtcodigoCliente.Name = "txtcodigoCliente";
            this.txtcodigoCliente.ReadOnly = true;
            this.txtcodigoCliente.Size = new System.Drawing.Size(527, 25);
            this.txtcodigoCliente.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(37, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Código de cliente";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(900, 350);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(229, 40);
            this.btnProcesar.TabIndex = 84;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBoxInfoCuenta
            // 
            this.groupBoxInfoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupBoxInfoCuenta.Controls.Add(this.lblSaldoActualValor);
            this.groupBoxInfoCuenta.Controls.Add(this.lblTipoCuentaValor);
            this.groupBoxInfoCuenta.Controls.Add(this.lblSaldoActual);
            this.groupBoxInfoCuenta.Controls.Add(this.lblTipoCuenta);
            this.groupBoxInfoCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.groupBoxInfoCuenta.Location = new System.Drawing.Point(38, 316);
            this.groupBoxInfoCuenta.Name = "groupBoxInfoCuenta";
            this.groupBoxInfoCuenta.Size = new System.Drawing.Size(526, 78);
            this.groupBoxInfoCuenta.TabIndex = 12;
            this.groupBoxInfoCuenta.TabStop = false;
            this.groupBoxInfoCuenta.Text = "Información de la Cuenta";
            // 
            // lblSaldoActualValor
            // 
            this.lblSaldoActualValor.AutoSize = true;
            this.lblSaldoActualValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaldoActualValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSaldoActualValor.Location = new System.Drawing.Point(111, 48);
            this.lblSaldoActualValor.Name = "lblSaldoActualValor";
            this.lblSaldoActualValor.Size = new System.Drawing.Size(34, 15);
            this.lblSaldoActualValor.TabIndex = 3;
            this.lblSaldoActualValor.Text = "$0.00";
            // 
            // lblTipoCuentaValor
            // 
            this.lblTipoCuentaValor.AutoSize = true;
            this.lblTipoCuentaValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoCuentaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTipoCuentaValor.Location = new System.Drawing.Point(111, 26);
            this.lblTipoCuentaValor.Name = "lblTipoCuentaValor";
            this.lblTipoCuentaValor.Size = new System.Drawing.Size(12, 15);
            this.lblTipoCuentaValor.TabIndex = 2;
            this.lblTipoCuentaValor.Text = "-";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSaldoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSaldoActual.Location = new System.Drawing.Point(17, 48);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(78, 15);
            this.lblSaldoActual.TabIndex = 1;
            this.lblSaldoActual.Text = "Saldo Actual:";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTipoCuenta.Location = new System.Drawing.Point(17, 26);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(93, 15);
            this.lblTipoCuenta.TabIndex = 0;
            this.lblTipoCuenta.Text = "Tipo de Cuenta:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(602, 143);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(527, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDescripcion.Location = new System.Drawing.Point(602, 121);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 19);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtMontoDeposito
            // 
            this.txtMontoDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtMontoDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoDeposito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMontoDeposito.Location = new System.Drawing.Point(602, 69);
            this.txtMontoDeposito.Name = "txtMontoDeposito";
            this.txtMontoDeposito.Size = new System.Drawing.Size(527, 25);
            this.txtMontoDeposito.TabIndex = 7;
            // 
            // lblMontoDeposito
            // 
            this.lblMontoDeposito.AutoSize = true;
            this.lblMontoDeposito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontoDeposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMontoDeposito.Location = new System.Drawing.Point(602, 47);
            this.lblMontoDeposito.Name = "lblMontoDeposito";
            this.lblMontoDeposito.Size = new System.Drawing.Size(156, 19);
            this.lblMontoDeposito.TabIndex = 6;
            this.lblMontoDeposito.Text = "Monto a Depositar ($)";
            // 
            // cmbNumeroCuenta
            // 
            this.cmbNumeroCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cmbNumeroCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroCuenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNumeroCuenta.FormattingEnabled = true;
            this.cmbNumeroCuenta.Items.AddRange(new object[] {
            "Seleccione una cuenta",
            "CTA001 - Cuenta Corriente",
            "CTA002 - Cuenta de Ahorros",
            "CTA003 - Cuenta Corriente"});
            this.cmbNumeroCuenta.Location = new System.Drawing.Point(38, 272);
            this.cmbNumeroCuenta.Name = "cmbNumeroCuenta";
            this.cmbNumeroCuenta.Size = new System.Drawing.Size(527, 25);
            this.cmbNumeroCuenta.TabIndex = 5;
            this.cmbNumeroCuenta.SelectedIndexChanged += new System.EventHandler(this.generacionInformacion);
            this.cmbNumeroCuenta.SelectedValueChanged += new System.EventHandler(this.generacionInformacion);
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNumeroCuenta.Location = new System.Drawing.Point(38, 250);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(130, 19);
            this.lblNumeroCuenta.TabIndex = 4;
            this.lblNumeroCuenta.Text = "Cuenta de Destino";
            // 
            // txtCodigoCartera
            // 
            this.txtCodigoCartera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoCartera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoCartera.Location = new System.Drawing.Point(37, 69);
            this.txtCodigoCartera.Name = "txtCodigoCartera";
            this.txtCodigoCartera.ReadOnly = true;
            this.txtCodigoCartera.Size = new System.Drawing.Size(527, 25);
            this.txtCodigoCartera.TabIndex = 3;
            // 
            // lblCodigoCartera
            // 
            this.lblCodigoCartera.AutoSize = true;
            this.lblCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCartera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCodigoCartera.Location = new System.Drawing.Point(37, 47);
            this.lblCodigoCartera.Name = "lblCodigoCartera";
            this.lblCodigoCartera.Size = new System.Drawing.Size(208, 19);
            this.lblCodigoCartera.TabIndex = 2;
            this.lblCodigoCartera.Text = "Código de Cartera del Cliente";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(38, 200);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(527, 25);
            this.txtCodigoEmpleado.TabIndex = 1;
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(38, 178);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(150, 19);
            this.lblCodigoEmpleado.TabIndex = 0;
            this.lblCodigoEmpleado.Text = "Código de Empleado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(443, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(471, 29);
            this.txtBuscar.TabIndex = 90;
            this.txtBuscar.Text = "Buscar por código o DUI ...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(944, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 30);
            this.btnBuscar.TabIndex = 89;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "deposito";
            this.Size = new System.Drawing.Size(1183, 540);
            this.Load += new System.EventHandler(this.deposito_Load);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.groupBoxInfoCuenta.ResumeLayout(false);
            this.groupBoxInfoCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoCartera;
        private System.Windows.Forms.Label lblCodigoCartera;
        private System.Windows.Forms.ComboBox cmbNumeroCuenta;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.TextBox txtMontoDeposito;
        private System.Windows.Forms.Label lblMontoDeposito;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox groupBoxInfoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblTipoCuentaValor;
        private System.Windows.Forms.Label lblSaldoActualValor;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtcodigoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}