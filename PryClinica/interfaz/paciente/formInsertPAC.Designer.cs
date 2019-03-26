namespace PryClinica.interfaz.paciente
{
    partial class formInsertPAC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResgistrarPac = new System.Windows.Forms.Button();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtApePac = new System.Windows.Forms.TextBox();
            this.txtNombrePac = new System.Windows.Forms.TextBox();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblApellidoPac = new System.Windows.Forms.Label();
            this.lblNombrePac = new System.Windows.Forms.Label();
            this.lblIdPac = new System.Windows.Forms.Label();
            this.lblGestionPac = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResgistrarPac);
            this.panel1.Controls.Add(this.cbxEstadoCivil);
            this.panel1.Controls.Add(this.txtApePac);
            this.panel1.Controls.Add(this.txtNombrePac);
            this.panel1.Controls.Add(this.txtIdPac);
            this.panel1.Controls.Add(this.lblEstadoCivil);
            this.panel1.Controls.Add(this.lblApellidoPac);
            this.panel1.Controls.Add(this.lblNombrePac);
            this.panel1.Controls.Add(this.lblIdPac);
            this.panel1.Controls.Add(this.lblGestionPac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 489);
            this.panel1.TabIndex = 1;
            // 
            // btnResgistrarPac
            // 
            this.btnResgistrarPac.Location = new System.Drawing.Point(108, 342);
            this.btnResgistrarPac.Name = "btnResgistrarPac";
            this.btnResgistrarPac.Size = new System.Drawing.Size(125, 23);
            this.btnResgistrarPac.TabIndex = 9;
            this.btnResgistrarPac.Text = "Registrar Paciente";
            this.btnResgistrarPac.UseVisualStyleBackColor = true;
            this.btnResgistrarPac.Click += new System.EventHandler(this.btnResgistrarPac_Click);
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "soltero(a)",
            "casado(a)",
            "viudo(a)",
            "divorciado(a)"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(152, 221);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoCivil.TabIndex = 8;
            // 
            // txtApePac
            // 
            this.txtApePac.Location = new System.Drawing.Point(152, 175);
            this.txtApePac.Name = "txtApePac";
            this.txtApePac.Size = new System.Drawing.Size(121, 20);
            this.txtApePac.TabIndex = 7;
            // 
            // txtNombrePac
            // 
            this.txtNombrePac.Location = new System.Drawing.Point(152, 128);
            this.txtNombrePac.Name = "txtNombrePac";
            this.txtNombrePac.Size = new System.Drawing.Size(121, 20);
            this.txtNombrePac.TabIndex = 6;
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(152, 90);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(121, 20);
            this.txtIdPac.TabIndex = 5;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(53, 230);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 4;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblApellidoPac
            // 
            this.lblApellidoPac.AutoSize = true;
            this.lblApellidoPac.Location = new System.Drawing.Point(53, 175);
            this.lblApellidoPac.Name = "lblApellidoPac";
            this.lblApellidoPac.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoPac.TabIndex = 3;
            this.lblApellidoPac.Text = "Apellido:";
            // 
            // lblNombrePac
            // 
            this.lblNombrePac.AutoSize = true;
            this.lblNombrePac.Location = new System.Drawing.Point(53, 128);
            this.lblNombrePac.Name = "lblNombrePac";
            this.lblNombrePac.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePac.TabIndex = 2;
            this.lblNombrePac.Text = "Nombre:";
            // 
            // lblIdPac
            // 
            this.lblIdPac.AutoSize = true;
            this.lblIdPac.Location = new System.Drawing.Point(50, 90);
            this.lblIdPac.Name = "lblIdPac";
            this.lblIdPac.Size = new System.Drawing.Size(73, 13);
            this.lblIdPac.TabIndex = 1;
            this.lblIdPac.Text = "Identificación:";
            // 
            // lblGestionPac
            // 
            this.lblGestionPac.AutoSize = true;
            this.lblGestionPac.Location = new System.Drawing.Point(126, 32);
            this.lblGestionPac.Name = "lblGestionPac";
            this.lblGestionPac.Size = new System.Drawing.Size(118, 13);
            this.lblGestionPac.TabIndex = 0;
            this.lblGestionPac.Text = "INSERTAR PACIENTE";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(345, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(496, 489);
            this.dgvDatos.TabIndex = 2;
            // 
            // formInsertPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInsertPAC";
            this.Text = "formInsertPAC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResgistrarPac;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.TextBox txtApePac;
        private System.Windows.Forms.TextBox txtNombrePac;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblApellidoPac;
        private System.Windows.Forms.Label lblNombrePac;
        private System.Windows.Forms.Label lblIdPac;
        private System.Windows.Forms.Label lblGestionPac;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}