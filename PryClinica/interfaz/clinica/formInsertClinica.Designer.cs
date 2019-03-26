namespace PryClinica
{
    partial class formInsertClinica
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
            this.pnlGestionar = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtCodCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResgistrarCli = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.rbtPublica = new System.Windows.Forms.RadioButton();
            this.rbtPrivada = new System.Windows.Forms.RadioButton();
            this.pnlGestionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestionar
            // 
            this.pnlGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlGestionar.Controls.Add(this.dgvDatos);
            this.pnlGestionar.Controls.Add(this.txtCodCiudad);
            this.pnlGestionar.Controls.Add(this.label2);
            this.pnlGestionar.Controls.Add(this.btnResgistrarCli);
            this.pnlGestionar.Controls.Add(this.rbtPrivada);
            this.pnlGestionar.Controls.Add(this.rbtPublica);
            this.pnlGestionar.Controls.Add(this.txtDireccion);
            this.pnlGestionar.Controls.Add(this.txtNombre);
            this.pnlGestionar.Controls.Add(this.txtNit);
            this.pnlGestionar.Controls.Add(this.lblDireccion);
            this.pnlGestionar.Controls.Add(this.lblModalidad);
            this.pnlGestionar.Controls.Add(this.lblNombre);
            this.pnlGestionar.Controls.Add(this.lblNit);
            this.pnlGestionar.Controls.Add(this.label1);
            this.pnlGestionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGestionar.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionar.Name = "pnlGestionar";
            this.pnlGestionar.Size = new System.Drawing.Size(841, 489);
            this.pnlGestionar.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDatos.Location = new System.Drawing.Point(333, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(508, 489);
            this.dgvDatos.TabIndex = 13;
            // 
            // txtCodCiudad
            // 
            this.txtCodCiudad.Location = new System.Drawing.Point(135, 245);
            this.txtCodCiudad.Name = "txtCodCiudad";
            this.txtCodCiudad.Size = new System.Drawing.Size(167, 20);
            this.txtCodCiudad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código Ciudad: ";
            // 
            // btnResgistrarCli
            // 
            this.btnResgistrarCli.Location = new System.Drawing.Point(135, 391);
            this.btnResgistrarCli.Name = "btnResgistrarCli";
            this.btnResgistrarCli.Size = new System.Drawing.Size(121, 23);
            this.btnResgistrarCli.TabIndex = 10;
            this.btnResgistrarCli.Text = "Registrar Clínica";
            this.btnResgistrarCli.UseVisualStyleBackColor = true;
            this.btnResgistrarCli.Click += new System.EventHandler(this.btnResgistrarCli_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(135, 194);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(135, 98);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(167, 20);
            this.txtNit.TabIndex = 5;
            this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(12, 194);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 145);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNit.Location = new System.Drawing.Point(12, 105);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(34, 17);
            this.lblNit.TabIndex = 1;
            this.lblNit.Text = "NIT: ";
            this.lblNit.Click += new System.EventHandler(this.lblNit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERTAR CLÍNICA";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblModalidad.Location = new System.Drawing.Point(12, 311);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(83, 17);
            this.lblModalidad.TabIndex = 3;
            this.lblModalidad.Text = "Modalidad:";
            // 
            // rbtPublica
            // 
            this.rbtPublica.AutoSize = true;
            this.rbtPublica.Location = new System.Drawing.Point(135, 311);
            this.rbtPublica.Name = "rbtPublica";
            this.rbtPublica.Size = new System.Drawing.Size(60, 17);
            this.rbtPublica.TabIndex = 8;
            this.rbtPublica.TabStop = true;
            this.rbtPublica.Text = "Pública";
            this.rbtPublica.UseVisualStyleBackColor = true;
            // 
            // rbtPrivada
            // 
            this.rbtPrivada.AutoSize = true;
            this.rbtPrivada.Location = new System.Drawing.Point(216, 311);
            this.rbtPrivada.Name = "rbtPrivada";
            this.rbtPrivada.Size = new System.Drawing.Size(61, 17);
            this.rbtPrivada.TabIndex = 9;
            this.rbtPrivada.TabStop = true;
            this.rbtPrivada.Text = "Privada";
            this.rbtPrivada.UseVisualStyleBackColor = true;
            // 
            // formInsertClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.pnlGestionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInsertClinica";
            this.Text = "Form2";
            this.pnlGestionar.ResumeLayout(false);
            this.pnlGestionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionar;
        private System.Windows.Forms.Button btnResgistrarCli;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.RadioButton rbtPrivada;
        private System.Windows.Forms.RadioButton rbtPublica;
        private System.Windows.Forms.Label lblModalidad;
    }
}