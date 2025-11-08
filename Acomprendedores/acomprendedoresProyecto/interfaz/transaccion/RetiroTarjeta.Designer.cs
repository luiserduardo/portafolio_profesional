namespace acomprendedoresProyecto.interfaz.transaccion
{
    partial class RetiroTarjeta
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
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneTarjeta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxInfoCuenta = new System.Windows.Forms.GroupBox();
            this.lblSaldoActualValor = new System.Windows.Forms.Label();
            this.lblTipoCuentaValor = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtCodigoCartera = new System.Windows.Forms.TextBox();
            this.lblCodigoCartera = new System.Windows.Forms.Label();
            this.tiporedlda = new System.Windows.Forms.Label();
            this.TipoRedlb = new System.Windows.Forms.Label();
            this.groupBoxInfoCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMonto.Location = new System.Drawing.Point(594, 218);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(380, 29);
            this.txtMonto.TabIndex = 15;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMonto.Location = new System.Drawing.Point(593, 183);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(121, 20);
            this.lblMonto.TabIndex = 14;
            this.lblMonto.Text = "Monto a retirar:";
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Location = new System.Drawing.Point(103, 209);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(380, 29);
            this.cmbTarjetas.TabIndex = 11;
            this.cmbTarjetas.SelectedValueChanged += new System.EventHandler(this.generarInformacion);
            // 
            // lblSeleccioneTarjeta
            // 
            this.lblSeleccioneTarjeta.AutoSize = true;
            this.lblSeleccioneTarjeta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSeleccioneTarjeta.Location = new System.Drawing.Point(99, 179);
            this.lblSeleccioneTarjeta.Name = "lblSeleccioneTarjeta";
            this.lblSeleccioneTarjeta.Size = new System.Drawing.Size(184, 20);
            this.lblSeleccioneTarjeta.TabIndex = 10;
            this.lblSeleccioneTarjeta.Text = "Seleccione tarjeta débito:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(597, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 87;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.Color.White;
            this.btnRetirar.Location = new System.Drawing.Point(791, 307);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(120, 40);
            this.btnRetirar.TabIndex = 86;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(97, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(323, 25);
            this.lblSubtitle.TabIndex = 89;
            this.lblSubtitle.Text = "Retire dinero de su cuenta de forma segura";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(123, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 40);
            this.lblTitle.TabIndex = 88;
            this.lblTitle.Text = "💸 Realizar Retiro";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfoCuenta
            // 
            this.groupBoxInfoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupBoxInfoCuenta.Controls.Add(this.tiporedlda);
            this.groupBoxInfoCuenta.Controls.Add(this.TipoRedlb);
            this.groupBoxInfoCuenta.Controls.Add(this.lblSaldoActualValor);
            this.groupBoxInfoCuenta.Controls.Add(this.lblTipoCuentaValor);
            this.groupBoxInfoCuenta.Controls.Add(this.lblSaldoActual);
            this.groupBoxInfoCuenta.Controls.Add(this.lblTipoCuenta);
            this.groupBoxInfoCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.groupBoxInfoCuenta.Location = new System.Drawing.Point(101, 281);
            this.groupBoxInfoCuenta.Name = "groupBoxInfoCuenta";
            this.groupBoxInfoCuenta.Size = new System.Drawing.Size(382, 112);
            this.groupBoxInfoCuenta.TabIndex = 92;
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
            // txtCodigoCartera
            // 
            this.txtCodigoCartera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoCartera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoCartera.Location = new System.Drawing.Point(101, 139);
            this.txtCodigoCartera.Name = "txtCodigoCartera";
            this.txtCodigoCartera.ReadOnly = true;
            this.txtCodigoCartera.Size = new System.Drawing.Size(382, 25);
            this.txtCodigoCartera.TabIndex = 91;
            // 
            // lblCodigoCartera
            // 
            this.lblCodigoCartera.AutoSize = true;
            this.lblCodigoCartera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCartera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCodigoCartera.Location = new System.Drawing.Point(101, 117);
            this.lblCodigoCartera.Name = "lblCodigoCartera";
            this.lblCodigoCartera.Size = new System.Drawing.Size(208, 19);
            this.lblCodigoCartera.TabIndex = 90;
            this.lblCodigoCartera.Text = "Código de Cartera del Cliente";
            // 
            // tiporedlda
            // 
            this.tiporedlda.AutoSize = true;
            this.tiporedlda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tiporedlda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.tiporedlda.Location = new System.Drawing.Point(111, 76);
            this.tiporedlda.Name = "tiporedlda";
            this.tiporedlda.Size = new System.Drawing.Size(34, 15);
            this.tiporedlda.TabIndex = 5;
            this.tiporedlda.Text = "$0.00";
            // 
            // TipoRedlb
            // 
            this.TipoRedlb.AutoSize = true;
            this.TipoRedlb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TipoRedlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TipoRedlb.Location = new System.Drawing.Point(17, 76);
            this.TipoRedlb.Name = "TipoRedlb";
            this.TipoRedlb.Size = new System.Drawing.Size(56, 15);
            this.TipoRedlb.TabIndex = 4;
            this.TipoRedlb.Text = "Tipo red:";
            // 
            // RetiroTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxInfoCuenta);
            this.Controls.Add(this.txtCodigoCartera);
            this.Controls.Add(this.lblCodigoCartera);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cmbTarjetas);
            this.Controls.Add(this.lblSeleccioneTarjeta);
            this.Name = "RetiroTarjeta";
            this.Size = new System.Drawing.Size(1183, 540);
            this.Load += new System.EventHandler(this.RetiroTarjeta_Load);
            this.groupBoxInfoCuenta.ResumeLayout(false);
            this.groupBoxInfoCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.Label lblSeleccioneTarjeta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfoCuenta;
        private System.Windows.Forms.Label lblSaldoActualValor;
        private System.Windows.Forms.Label lblTipoCuentaValor;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.TextBox txtCodigoCartera;
        private System.Windows.Forms.Label lblCodigoCartera;
        private System.Windows.Forms.Label tiporedlda;
        private System.Windows.Forms.Label TipoRedlb;
    }
}