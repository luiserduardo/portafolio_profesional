namespace acomprendedoresProyecto.pantallas.empleados
{
    partial class EdicionUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEda = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCorreos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDireccio = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtsSalarioMensual = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTelefo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtFechas = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.comboEstadoFamiliar = new System.Windows.Forms.ComboBox();
            this.comboPuesto = new System.Windows.Forms.ComboBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1075, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edición de empleados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label12.Location = new System.Drawing.Point(32, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 21);
            this.label12.TabIndex = 60;
            this.label12.Text = "Código Usuario";
            // 
            // txtCodigos
            // 
            this.txtCodigos.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCodigos.Location = new System.Drawing.Point(237, 100);
            this.txtCodigos.Name = "txtCodigos";
            this.txtCodigos.ReadOnly = true;
            this.txtCodigos.Size = new System.Drawing.Size(280, 22);
            this.txtCodigos.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(32, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 21);
            this.label13.TabIndex = 61;
            this.label13.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNombres.Location = new System.Drawing.Point(237, 155);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(280, 22);
            this.txtNombres.TabIndex = 73;
            this.txtNombres.Leave += new System.EventHandler(this.txtNombres_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label14.Location = new System.Drawing.Point(32, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "Apellidos";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtApellido.Location = new System.Drawing.Point(237, 206);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 22);
            this.txtApellido.TabIndex = 74;
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label15.Location = new System.Drawing.Point(32, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 21);
            this.label15.TabIndex = 65;
            this.label15.Text = "DUI";
            // 
            // txtDu
            // 
            this.txtDu.BackColor = System.Drawing.Color.White;
            this.txtDu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDu.Location = new System.Drawing.Point(237, 259);
            this.txtDu.Name = "txtDu";
            this.txtDu.Size = new System.Drawing.Size(280, 22);
            this.txtDu.TabIndex = 83;
            this.txtDu.Leave += new System.EventHandler(this.txtDu_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label16.Location = new System.Drawing.Point(32, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 21);
            this.label16.TabIndex = 62;
            this.label16.Text = "Fecha nacimiento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label17.Location = new System.Drawing.Point(32, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 66;
            this.label17.Text = "Edad";
            // 
            // txtEda
            // 
            this.txtEda.BackColor = System.Drawing.Color.LightGray;
            this.txtEda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtEda.Location = new System.Drawing.Point(237, 360);
            this.txtEda.Name = "txtEda";
            this.txtEda.ReadOnly = true;
            this.txtEda.Size = new System.Drawing.Size(280, 22);
            this.txtEda.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label18.Location = new System.Drawing.Point(32, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 21);
            this.label18.TabIndex = 67;
            this.label18.Text = "Correo";
            // 
            // txtCorreos
            // 
            this.txtCorreos.BackColor = System.Drawing.Color.White;
            this.txtCorreos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCorreos.Location = new System.Drawing.Point(237, 418);
            this.txtCorreos.Name = "txtCorreos";
            this.txtCorreos.Size = new System.Drawing.Size(280, 22);
            this.txtCorreos.TabIndex = 76;
            this.txtCorreos.Leave += new System.EventHandler(this.txtCorreos_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label19.Location = new System.Drawing.Point(563, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 21);
            this.label19.TabIndex = 63;
            this.label19.Text = "Dirección:";
            // 
            // txtDireccio
            // 
            this.txtDireccio.BackColor = System.Drawing.Color.White;
            this.txtDireccio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDireccio.Location = new System.Drawing.Point(760, 96);
            this.txtDireccio.Name = "txtDireccio";
            this.txtDireccio.Size = new System.Drawing.Size(280, 22);
            this.txtDireccio.TabIndex = 77;
            this.txtDireccio.Leave += new System.EventHandler(this.txtDireccio_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label20.Location = new System.Drawing.Point(563, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 21);
            this.label20.TabIndex = 68;
            this.label20.Text = "Salario mensual";
            // 
            // txtsSalarioMensual
            // 
            this.txtsSalarioMensual.BackColor = System.Drawing.Color.White;
            this.txtsSalarioMensual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsSalarioMensual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsSalarioMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtsSalarioMensual.Location = new System.Drawing.Point(760, 161);
            this.txtsSalarioMensual.Name = "txtsSalarioMensual";
            this.txtsSalarioMensual.Size = new System.Drawing.Size(280, 22);
            this.txtsSalarioMensual.TabIndex = 78;
            this.txtsSalarioMensual.Leave += new System.EventHandler(this.txtsSalarioMensual_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label21.Location = new System.Drawing.Point(563, 205);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 21);
            this.label21.TabIndex = 69;
            this.label21.Text = "Teléfono";
            // 
            // txtTelefo
            // 
            this.txtTelefo.BackColor = System.Drawing.Color.White;
            this.txtTelefo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTelefo.Location = new System.Drawing.Point(760, 210);
            this.txtTelefo.Name = "txtTelefo";
            this.txtTelefo.Size = new System.Drawing.Size(280, 22);
            this.txtTelefo.TabIndex = 79;
            this.txtTelefo.Leave += new System.EventHandler(this.txtTelefo_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(386, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 82;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(542, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 83;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtFechas
            // 
            this.txtFechas.CalendarMonthBackground = System.Drawing.Color.White;
            this.txtFechas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechas.Location = new System.Drawing.Point(237, 313);
            this.txtFechas.MaxDate = new System.DateTime(2025, 10, 12, 0, 0, 0, 0);
            this.txtFechas.Name = "txtFechas";
            this.txtFechas.Size = new System.Drawing.Size(280, 22);
            this.txtFechas.TabIndex = 89;
            this.txtFechas.Value = new System.DateTime(2025, 10, 12, 0, 0, 0, 0);
            this.txtFechas.ValueChanged += new System.EventHandler(this.calcularEdad);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label23.Location = new System.Drawing.Point(32, 477);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 21);
            this.label23.TabIndex = 84;
            this.label23.Text = "Estado familiar";
            // 
            // comboEstadoFamiliar
            // 
            this.comboEstadoFamiliar.BackColor = System.Drawing.Color.White;
            this.comboEstadoFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoFamiliar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadoFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboEstadoFamiliar.FormattingEnabled = true;
            this.comboEstadoFamiliar.Items.AddRange(new object[] {
            "Casado/a",
            "Viudo/a",
            "Soltero/a"});
            this.comboEstadoFamiliar.Location = new System.Drawing.Point(237, 477);
            this.comboEstadoFamiliar.Name = "comboEstadoFamiliar";
            this.comboEstadoFamiliar.Size = new System.Drawing.Size(280, 21);
            this.comboEstadoFamiliar.TabIndex = 85;
            // 
            // comboPuesto
            // 
            this.comboPuesto.BackColor = System.Drawing.Color.White;
            this.comboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPuesto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboPuesto.FormattingEnabled = true;
            this.comboPuesto.Items.AddRange(new object[] {
            "Administrador",
            "Ventas"});
            this.comboPuesto.Location = new System.Drawing.Point(760, 319);
            this.comboPuesto.Name = "comboPuesto";
            this.comboPuesto.Size = new System.Drawing.Size(280, 21);
            this.comboPuesto.TabIndex = 90;
            // 
            // txtProfesion
            // 
            this.txtProfesion.BackColor = System.Drawing.Color.White;
            this.txtProfesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfesion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProfesion.Location = new System.Drawing.Point(760, 374);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(280, 22);
            this.txtProfesion.TabIndex = 88;
            this.txtProfesion.Leave += new System.EventHandler(this.txtProfesion_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label24.Location = new System.Drawing.Point(563, 374);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 21);
            this.label24.TabIndex = 87;
            this.label24.Text = "Profesión";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label25.Location = new System.Drawing.Point(563, 317);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 21);
            this.label25.TabIndex = 86;
            this.label25.Text = "Puesto";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.White;
            this.txtDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDepartamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDepartamento.FormattingEnabled = true;
            this.txtDepartamento.Items.AddRange(new object[] {
            "Sistemas",
            "Ventas",
            "Servicio al cliente",
            "Gerencia"});
            this.txtDepartamento.Location = new System.Drawing.Point(760, 263);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(280, 21);
            this.txtDepartamento.TabIndex = 81;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label26.Location = new System.Drawing.Point(563, 258);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 21);
            this.label26.TabIndex = 71;
            this.label26.Text = "Departamento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label22.Location = new System.Drawing.Point(564, 419);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 21);
            this.label22.TabIndex = 91;
            this.label22.Text = "Estado";
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.Color.White;
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.estado.Location = new System.Drawing.Point(760, 421);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(280, 21);
            this.estado.TabIndex = 92;
            // 
            // EdicionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1075, 598);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comboPuesto);
            this.Controls.Add(this.txtFechas);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.comboEstadoFamiliar);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtDu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtTelefo);
            this.Controls.Add(this.txtsSalarioMensual);
            this.Controls.Add(this.txtDireccio);
            this.Controls.Add(this.txtCorreos);
            this.Controls.Add(this.txtEda);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigos);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EdicionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Empleados";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEda;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCorreos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDireccio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtsSalarioMensual;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTelefo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker txtFechas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboEstadoFamiliar;
        private System.Windows.Forms.ComboBox comboPuesto;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox txtDepartamento;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox estado;
    }
}