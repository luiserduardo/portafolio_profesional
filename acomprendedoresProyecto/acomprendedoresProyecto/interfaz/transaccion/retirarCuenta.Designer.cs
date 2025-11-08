namespace acomprendedoresProyecto.ui.transaccion
{
    partial class retirarCuenta
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
            this.lblCuentaOrigen = new System.Windows.Forms.Label();
            this.cmbCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.lblMontoRetiro = new System.Windows.Forms.Label();
            this.txtMontoRetiro = new System.Windows.Forms.TextBox();
            this.panelAmountDisplay = new System.Windows.Forms.Panel();
            this.lblDisplayAmount = new System.Windows.Forms.Label();
            this.lblAmountLabel = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxInfoCuenta = new System.Windows.Forms.GroupBox();
            this.lblSaldoActualValor = new System.Windows.Forms.Label();
            this.lblTipoCuentaValor = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Regirar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelAmountDisplay.SuspendLayout();
            this.groupBoxInfoCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCuentaOrigen
            // 
            this.lblCuentaOrigen.AutoSize = true;
            this.lblCuentaOrigen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCuentaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCuentaOrigen.Location = new System.Drawing.Point(27, 136);
            this.lblCuentaOrigen.Name = "lblCuentaOrigen";
            this.lblCuentaOrigen.Size = new System.Drawing.Size(126, 19);
            this.lblCuentaOrigen.TabIndex = 2;
            this.lblCuentaOrigen.Text = "Cuenta de Origen";
            // 
            // cmbCuentaOrigen
            // 
            this.cmbCuentaOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cmbCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaOrigen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCuentaOrigen.FormattingEnabled = true;
            this.cmbCuentaOrigen.Location = new System.Drawing.Point(27, 161);
            this.cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            this.cmbCuentaOrigen.Size = new System.Drawing.Size(404, 28);
            this.cmbCuentaOrigen.TabIndex = 3;
            this.cmbCuentaOrigen.SelectedValueChanged += new System.EventHandler(this.generacionInformacion);
            // 
            // lblMontoRetiro
            // 
            this.lblMontoRetiro.AutoSize = true;
            this.lblMontoRetiro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontoRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMontoRetiro.Location = new System.Drawing.Point(31, 227);
            this.lblMontoRetiro.Name = "lblMontoRetiro";
            this.lblMontoRetiro.Size = new System.Drawing.Size(137, 19);
            this.lblMontoRetiro.TabIndex = 6;
            this.lblMontoRetiro.Text = "Monto a Retirar ($)";
            // 
            // txtMontoRetiro
            // 
            this.txtMontoRetiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtMontoRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoRetiro.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMontoRetiro.Location = new System.Drawing.Point(31, 252);
            this.txtMontoRetiro.Name = "txtMontoRetiro";
            this.txtMontoRetiro.Size = new System.Drawing.Size(400, 27);
            this.txtMontoRetiro.TabIndex = 7;
            // 
            // panelAmountDisplay
            // 
            this.panelAmountDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelAmountDisplay.Controls.Add(this.lblDisplayAmount);
            this.panelAmountDisplay.Controls.Add(this.lblAmountLabel);
            this.panelAmountDisplay.Location = new System.Drawing.Point(519, 227);
            this.panelAmountDisplay.Name = "panelAmountDisplay";
            this.panelAmountDisplay.Size = new System.Drawing.Size(599, 80);
            this.panelAmountDisplay.TabIndex = 8;
            this.panelAmountDisplay.Visible = false;
            // 
            // lblDisplayAmount
            // 
            this.lblDisplayAmount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDisplayAmount.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayAmount.Location = new System.Drawing.Point(100, 30);
            this.lblDisplayAmount.Name = "lblDisplayAmount";
            this.lblDisplayAmount.Size = new System.Drawing.Size(392, 45);
            this.lblDisplayAmount.TabIndex = 1;
            this.lblDisplayAmount.Text = "$0.00";
            this.lblDisplayAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountLabel
            // 
            this.lblAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.lblAmountLabel.Location = new System.Drawing.Point(71, 10);
            this.lblAmountLabel.Name = "lblAmountLabel";
            this.lblAmountLabel.Size = new System.Drawing.Size(430, 20);
            this.lblAmountLabel.TabIndex = 0;
            this.lblAmountLabel.Text = "Monto a retirar";
            this.lblAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 313);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 19);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescripcion.Location = new System.Drawing.Point(31, 338);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 27);
            this.txtDescripcion.TabIndex = 10;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(24, 64);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(323, 25);
            this.lblSubtitle.TabIndex = 14;
            this.lblSubtitle.Text = "Retire dinero de su cuenta de forma segura";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(50, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 40);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "💸 Realizar Retiro";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfoCuenta
            // 
            this.groupBoxInfoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupBoxInfoCuenta.Controls.Add(this.lblSaldoActualValor);
            this.groupBoxInfoCuenta.Controls.Add(this.lblTipoCuentaValor);
            this.groupBoxInfoCuenta.Controls.Add(this.lblSaldoActual);
            this.groupBoxInfoCuenta.Controls.Add(this.label1);
            this.groupBoxInfoCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.groupBoxInfoCuenta.Location = new System.Drawing.Point(519, 136);
            this.groupBoxInfoCuenta.Name = "groupBoxInfoCuenta";
            this.groupBoxInfoCuenta.Size = new System.Drawing.Size(599, 61);
            this.groupBoxInfoCuenta.TabIndex = 15;
            this.groupBoxInfoCuenta.TabStop = false;
            this.groupBoxInfoCuenta.Text = "Información de la Cuenta";
            // 
            // lblSaldoActualValor
            // 
            this.lblSaldoActualValor.AutoSize = true;
            this.lblSaldoActualValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaldoActualValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSaldoActualValor.Location = new System.Drawing.Point(478, 26);
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
            this.lblSaldoActual.Location = new System.Drawing.Point(375, 25);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(78, 15);
            this.lblSaldoActual.TabIndex = 1;
            this.lblSaldoActual.Text = "Saldo Actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Cuenta:";
            // 
            // Regirar
            // 
            this.Regirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.Regirar.FlatAppearance.BorderSize = 0;
            this.Regirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regirar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regirar.ForeColor = System.Drawing.Color.White;
            this.Regirar.Location = new System.Drawing.Point(633, 458);
            this.Regirar.Name = "Regirar";
            this.Regirar.Size = new System.Drawing.Size(120, 40);
            this.Regirar.TabIndex = 83;
            this.Regirar.Text = "Agregar";
            this.Regirar.UseVisualStyleBackColor = false;
            this.Regirar.Click += new System.EventHandler(this.Regirar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(439, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // retirarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Regirar);
            this.Controls.Add(this.groupBoxInfoCuenta);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panelAmountDisplay);
            this.Controls.Add(this.txtMontoRetiro);
            this.Controls.Add(this.lblMontoRetiro);
            this.Controls.Add(this.cmbCuentaOrigen);
            this.Controls.Add(this.lblCuentaOrigen);
            this.Name = "retirarCuenta";
            this.Size = new System.Drawing.Size(1183, 540);
            this.Load += new System.EventHandler(this.retirar_Load);
            this.panelAmountDisplay.ResumeLayout(false);
            this.groupBoxInfoCuenta.ResumeLayout(false);
            this.groupBoxInfoCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCuentaOrigen;
        private System.Windows.Forms.ComboBox cmbCuentaOrigen;
        private System.Windows.Forms.Label lblMontoRetiro;
        private System.Windows.Forms.TextBox txtMontoRetiro;
        private System.Windows.Forms.Panel panelAmountDisplay;
        private System.Windows.Forms.Label lblAmountLabel;
        private System.Windows.Forms.Label lblDisplayAmount;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfoCuenta;
        private System.Windows.Forms.Label lblSaldoActualValor;
        private System.Windows.Forms.Label lblTipoCuentaValor;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Regirar;
        private System.Windows.Forms.Button btnCancelar;
    }
}