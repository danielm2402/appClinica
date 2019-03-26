namespace PryClinica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gestión = new System.Windows.Forms.TabControl();
            this.Gestion = new System.Windows.Forms.TabPage();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.pnlMenuClinica = new System.Windows.Forms.Panel();
            this.btnEliminarCl = new System.Windows.Forms.Button();
            this.btnActualizarCl = new System.Windows.Forms.Button();
            this.btnRegistrarCl = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlSelected2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnActualizarPaciente = new System.Windows.Forms.Button();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlContenedor3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarCiudad = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConsultaDatos = new System.Windows.Forms.Button();
            this.dvgConsultaDatos = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvConFecha = new System.Windows.Forms.DataGridView();
            this.lblConsulaFecha = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaA = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEjecutarCon = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Gestión.SuspendLayout();
            this.Gestion.SuspendLayout();
            this.pnlMenuClinica.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaDatos)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConFecha)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.pnlCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gestión
            // 
            this.Gestión.Controls.Add(this.Gestion);
            this.Gestión.Controls.Add(this.tabPage2);
            this.Gestión.Controls.Add(this.tabPage3);
            this.Gestión.Controls.Add(this.tabPage1);
            this.Gestión.Controls.Add(this.tabPage4);
            this.Gestión.Controls.Add(this.tabPage5);
            this.Gestión.Controls.Add(this.tabPage6);
            this.Gestión.Location = new System.Drawing.Point(0, 46);
            this.Gestión.Name = "Gestión";
            this.Gestión.SelectedIndex = 0;
            this.Gestión.Size = new System.Drawing.Size(1014, 511);
            this.Gestión.TabIndex = 1;
            // 
            // Gestion
            // 
            this.Gestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Gestion.Controls.Add(this.pnlSelected);
            this.Gestion.Controls.Add(this.pnlMenuClinica);
            this.Gestion.Location = new System.Drawing.Point(4, 22);
            this.Gestion.Name = "Gestion";
            this.Gestion.Padding = new System.Windows.Forms.Padding(3);
            this.Gestion.Size = new System.Drawing.Size(1006, 485);
            this.Gestion.TabIndex = 0;
            this.Gestion.Text = "Clínica";
            // 
            // pnlSelected
            // 
            this.pnlSelected.Location = new System.Drawing.Point(165, 0);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(841, 489);
            this.pnlSelected.TabIndex = 2;
            // 
            // pnlMenuClinica
            // 
            this.pnlMenuClinica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlMenuClinica.Controls.Add(this.btnEliminarCl);
            this.pnlMenuClinica.Controls.Add(this.btnActualizarCl);
            this.pnlMenuClinica.Controls.Add(this.btnRegistrarCl);
            this.pnlMenuClinica.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuClinica.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuClinica.Name = "pnlMenuClinica";
            this.pnlMenuClinica.Size = new System.Drawing.Size(156, 479);
            this.pnlMenuClinica.TabIndex = 1;
            // 
            // btnEliminarCl
            // 
            this.btnEliminarCl.FlatAppearance.BorderSize = 0;
            this.btnEliminarCl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnEliminarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCl.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCl.Image = global::PryClinica.Properties.Resources.producto;
            this.btnEliminarCl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCl.Location = new System.Drawing.Point(3, 234);
            this.btnEliminarCl.Name = "btnEliminarCl";
            this.btnEliminarCl.Size = new System.Drawing.Size(148, 60);
            this.btnEliminarCl.TabIndex = 2;
            this.btnEliminarCl.Text = "      ELIMINAR";
            this.btnEliminarCl.UseVisualStyleBackColor = true;
            this.btnEliminarCl.Click += new System.EventHandler(this.btnEliminarCl_Click);
            // 
            // btnActualizarCl
            // 
            this.btnActualizarCl.FlatAppearance.BorderSize = 0;
            this.btnActualizarCl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnActualizarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCl.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCl.Image = global::PryClinica.Properties.Resources.producto;
            this.btnActualizarCl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCl.Location = new System.Drawing.Point(5, 168);
            this.btnActualizarCl.Name = "btnActualizarCl";
            this.btnActualizarCl.Size = new System.Drawing.Size(148, 60);
            this.btnActualizarCl.TabIndex = 1;
            this.btnActualizarCl.Text = "      ACTUALIZAR";
            this.btnActualizarCl.UseVisualStyleBackColor = true;
            this.btnActualizarCl.Click += new System.EventHandler(this.btnActualizarCl_Click_1);
            // 
            // btnRegistrarCl
            // 
            this.btnRegistrarCl.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnRegistrarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCl.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCl.Image = global::PryClinica.Properties.Resources.producto;
            this.btnRegistrarCl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCl.Location = new System.Drawing.Point(3, 102);
            this.btnRegistrarCl.Name = "btnRegistrarCl";
            this.btnRegistrarCl.Size = new System.Drawing.Size(148, 60);
            this.btnRegistrarCl.TabIndex = 0;
            this.btnRegistrarCl.Text = "      REGISTRAR";
            this.btnRegistrarCl.UseVisualStyleBackColor = true;
            this.btnRegistrarCl.Click += new System.EventHandler(this.btnRegistrarCl_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlSelected2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paciente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlSelected2
            // 
            this.pnlSelected2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlSelected2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelected2.Location = new System.Drawing.Point(168, 3);
            this.pnlSelected2.Name = "pnlSelected2";
            this.pnlSelected2.Size = new System.Drawing.Size(835, 479);
            this.pnlSelected2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnEliminarPaciente);
            this.panel1.Controls.Add(this.btnActualizarPaciente);
            this.panel1.Controls.Add(this.btnRegistrarPaciente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 479);
            this.panel1.TabIndex = 2;
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.FlatAppearance.BorderSize = 0;
            this.btnEliminarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnEliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPaciente.Image = global::PryClinica.Properties.Resources.producto;
            this.btnEliminarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(3, 234);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(148, 60);
            this.btnEliminarPaciente.TabIndex = 2;
            this.btnEliminarPaciente.Text = "      ELIMINAR";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnActualizarPaciente
            // 
            this.btnActualizarPaciente.FlatAppearance.BorderSize = 0;
            this.btnActualizarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnActualizarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPaciente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPaciente.Image = global::PryClinica.Properties.Resources.producto;
            this.btnActualizarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPaciente.Location = new System.Drawing.Point(5, 168);
            this.btnActualizarPaciente.Name = "btnActualizarPaciente";
            this.btnActualizarPaciente.Size = new System.Drawing.Size(148, 60);
            this.btnActualizarPaciente.TabIndex = 1;
            this.btnActualizarPaciente.Text = "      ACTUALIZAR";
            this.btnActualizarPaciente.UseVisualStyleBackColor = true;
            this.btnActualizarPaciente.Click += new System.EventHandler(this.btnActualizarPaciente_Click);
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnRegistrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPaciente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPaciente.Image = global::PryClinica.Properties.Resources.producto;
            this.btnRegistrarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(3, 102);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(148, 60);
            this.btnRegistrarPaciente.TabIndex = 0;
            this.btnRegistrarPaciente.Text = "      REGISTRAR";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlContenedor3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1006, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ciudad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlContenedor3
            // 
            this.pnlContenedor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlContenedor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor3.Location = new System.Drawing.Point(168, 3);
            this.pnlContenedor3.Name = "pnlContenedor3";
            this.pnlContenedor3.Size = new System.Drawing.Size(835, 479);
            this.pnlContenedor3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btnRegistrarCiudad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 479);
            this.panel2.TabIndex = 3;
            // 
            // btnRegistrarCiudad
            // 
            this.btnRegistrarCiudad.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnRegistrarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCiudad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCiudad.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCiudad.Image = global::PryClinica.Properties.Resources.producto;
            this.btnRegistrarCiudad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCiudad.Location = new System.Drawing.Point(3, 102);
            this.btnRegistrarCiudad.Name = "btnRegistrarCiudad";
            this.btnRegistrarCiudad.Size = new System.Drawing.Size(148, 60);
            this.btnRegistrarCiudad.TabIndex = 0;
            this.btnRegistrarCiudad.Text = "      REGISTRAR";
            this.btnRegistrarCiudad.UseVisualStyleBackColor = true;
            this.btnRegistrarCiudad.Click += new System.EventHandler(this.btnRegistrarCiudad_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 485);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Atención";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegistar);
            this.panel3.Controls.Add(this.txtPaciente);
            this.panel3.Controls.Add(this.txtNit);
            this.panel3.Controls.Add(this.dt);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(33, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 254);
            this.panel3.TabIndex = 0;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(510, 200);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistar.TabIndex = 8;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(235, 120);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(200, 20);
            this.txtPaciente.TabIndex = 7;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(235, 79);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(200, 20);
            this.txtNit.TabIndex = 6;
            // 
            // dt
            // 
            this.dt.CustomFormat = "DD/MM/YYYY hh:mi";
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt.Location = new System.Drawing.Point(235, 153);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 5;
            this.dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de Atención:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NIT Clínica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO DE LA ATENCIÓN DEL PACIENTE";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1006, 485);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Consultar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConsultaDatos);
            this.panel4.Controls.Add(this.dvgConsultaDatos);
            this.panel4.Location = new System.Drawing.Point(64, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 272);
            this.panel4.TabIndex = 0;
            // 
            // btnConsultaDatos
            // 
            this.btnConsultaDatos.Location = new System.Drawing.Point(251, 35);
            this.btnConsultaDatos.Name = "btnConsultaDatos";
            this.btnConsultaDatos.Size = new System.Drawing.Size(120, 23);
            this.btnConsultaDatos.TabIndex = 2;
            this.btnConsultaDatos.Text = "Consultar datos";
            this.btnConsultaDatos.UseVisualStyleBackColor = true;
            // 
            // dvgConsultaDatos
            // 
            this.dvgConsultaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsultaDatos.Location = new System.Drawing.Point(65, 81);
            this.dvgConsultaDatos.Name = "dvgConsultaDatos";
            this.dvgConsultaDatos.Size = new System.Drawing.Size(486, 166);
            this.dvgConsultaDatos.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1006, 485);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Consulta por Fecha";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvConFecha);
            this.panel5.Controls.Add(this.lblConsulaFecha);
            this.panel5.Controls.Add(this.dtpFechaAtencion);
            this.panel5.Controls.Add(this.lblFechaA);
            this.panel5.Location = new System.Drawing.Point(11, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(699, 293);
            this.panel5.TabIndex = 0;
            // 
            // dgvConFecha
            // 
            this.dgvConFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConFecha.Location = new System.Drawing.Point(45, 127);
            this.dgvConFecha.Name = "dgvConFecha";
            this.dgvConFecha.Size = new System.Drawing.Size(594, 150);
            this.dgvConFecha.TabIndex = 3;
            // 
            // lblConsulaFecha
            // 
            this.lblConsulaFecha.AutoSize = true;
            this.lblConsulaFecha.Location = new System.Drawing.Point(213, 25);
            this.lblConsulaFecha.Name = "lblConsulaFecha";
            this.lblConsulaFecha.Size = new System.Drawing.Size(205, 13);
            this.lblConsulaFecha.TabIndex = 2;
            this.lblConsulaFecha.Text = "CONSULTA POR FECHA DE ATENCIÓN";
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.Location = new System.Drawing.Point(216, 89);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAtencion.TabIndex = 1;
            // 
            // lblFechaA
            // 
            this.lblFechaA.AutoSize = true;
            this.lblFechaA.Location = new System.Drawing.Point(92, 95);
            this.lblFechaA.Name = "lblFechaA";
            this.lblFechaA.Size = new System.Drawing.Size(99, 13);
            this.lblFechaA.TabIndex = 0;
            this.lblFechaA.Text = "Fecha de atención:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1006, 485);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Consulta en VIVO";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEjecutarCon);
            this.panel6.Controls.Add(this.dgvConsulta);
            this.panel6.Location = new System.Drawing.Point(40, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(668, 253);
            this.panel6.TabIndex = 0;
            // 
            // btnEjecutarCon
            // 
            this.btnEjecutarCon.Location = new System.Drawing.Point(205, 38);
            this.btnEjecutarCon.Name = "btnEjecutarCon";
            this.btnEjecutarCon.Size = new System.Drawing.Size(161, 23);
            this.btnEjecutarCon.TabIndex = 1;
            this.btnEjecutarCon.Text = "Ejecutar consulta";
            this.btnEjecutarCon.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(56, 100);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(555, 123);
            this.dgvConsulta.TabIndex = 0;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.pnlCabecera.Controls.Add(this.btnMaxi);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1100, 40);
            this.pnlCabecera.TabIndex = 2;
            this.pnlCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseMove);
            // 
            // btnMaxi
            // 
            this.btnMaxi.FlatAppearance.BorderSize = 0;
            this.btnMaxi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaxi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.Location = new System.Drawing.Point(1014, 0);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(40, 40);
            this.btnMaxi.TabIndex = 1;
            this.btnMaxi.Text = "-";
            this.btnMaxi.UseVisualStyleBackColor = true;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1060, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1100, 611);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.Gestión);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Clínica";
            this.Gestión.ResumeLayout(false);
            this.Gestion.ResumeLayout(false);
            this.pnlMenuClinica.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsultaDatos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConFecha)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.pnlCabecera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Gestión;
        private System.Windows.Forms.TabPage Gestion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConsultaDatos;
        private System.Windows.Forms.DataGridView dvgConsultaDatos;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvConFecha;
        private System.Windows.Forms.Label lblConsulaFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.Label lblFechaA;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEjecutarCon;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Panel pnlMenuClinica;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Panel pnlSelected;
        private System.Windows.Forms.Button btnRegistrarCl;
        private System.Windows.Forms.Button btnEliminarCl;
        private System.Windows.Forms.Button btnActualizarCl;
        private System.Windows.Forms.Panel pnlSelected2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnActualizarPaciente;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.Panel pnlContenedor3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarCiudad;
    }
}

