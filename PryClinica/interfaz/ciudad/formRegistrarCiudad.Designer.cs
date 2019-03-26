namespace PryClinica.interfaz.ciudad
{
    partial class formRegistrarCiudad
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarCiu = new System.Windows.Forms.Button();
            this.txtNombreCiu = new System.Windows.Forms.TextBox();
            this.txtCodigoCiu = new System.Windows.Forms.TextBox();
            this.lblNombreCiu = new System.Windows.Forms.Label();
            this.lblCodigoCiu = new System.Windows.Forms.Label();
            this.lblGestionarCiu = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegistrarCiu);
            this.panel2.Controls.Add(this.txtNombreCiu);
            this.panel2.Controls.Add(this.txtCodigoCiu);
            this.panel2.Controls.Add(this.lblNombreCiu);
            this.panel2.Controls.Add(this.lblCodigoCiu);
            this.panel2.Controls.Add(this.lblGestionarCiu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 489);
            this.panel2.TabIndex = 1;
            // 
            // btnRegistrarCiu
            // 
            this.btnRegistrarCiu.Location = new System.Drawing.Point(118, 271);
            this.btnRegistrarCiu.Name = "btnRegistrarCiu";
            this.btnRegistrarCiu.Size = new System.Drawing.Size(112, 23);
            this.btnRegistrarCiu.TabIndex = 5;
            this.btnRegistrarCiu.Text = "Registrar Ciudad";
            this.btnRegistrarCiu.UseVisualStyleBackColor = true;
            this.btnRegistrarCiu.Click += new System.EventHandler(this.btnRegistrarCiu_Click);
            // 
            // txtNombreCiu
            // 
            this.txtNombreCiu.Location = new System.Drawing.Point(158, 171);
            this.txtNombreCiu.Name = "txtNombreCiu";
            this.txtNombreCiu.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCiu.TabIndex = 4;
            // 
            // txtCodigoCiu
            // 
            this.txtCodigoCiu.Location = new System.Drawing.Point(158, 102);
            this.txtCodigoCiu.Name = "txtCodigoCiu";
            this.txtCodigoCiu.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCiu.TabIndex = 3;
            // 
            // lblNombreCiu
            // 
            this.lblNombreCiu.AutoSize = true;
            this.lblNombreCiu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNombreCiu.Location = new System.Drawing.Point(33, 171);
            this.lblNombreCiu.Name = "lblNombreCiu";
            this.lblNombreCiu.Size = new System.Drawing.Size(65, 17);
            this.lblNombreCiu.TabIndex = 2;
            this.lblNombreCiu.Text = "Nombre:";
            // 
            // lblCodigoCiu
            // 
            this.lblCodigoCiu.AutoSize = true;
            this.lblCodigoCiu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblCodigoCiu.Location = new System.Drawing.Point(30, 102);
            this.lblCodigoCiu.Name = "lblCodigoCiu";
            this.lblCodigoCiu.Size = new System.Drawing.Size(62, 17);
            this.lblCodigoCiu.TabIndex = 1;
            this.lblCodigoCiu.Text = "Código:";
            // 
            // lblGestionarCiu
            // 
            this.lblGestionarCiu.AutoSize = true;
            this.lblGestionarCiu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarCiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblGestionarCiu.Location = new System.Drawing.Point(114, 27);
            this.lblGestionarCiu.Name = "lblGestionarCiu";
            this.lblGestionarCiu.Size = new System.Drawing.Size(167, 21);
            this.lblGestionarCiu.TabIndex = 0;
            this.lblGestionarCiu.Text = "REGISTRAR CIUDAD";
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AllowUserToAddRows = false;
            this.dgvCiudades.AllowUserToDeleteRows = false;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCiudades.Location = new System.Drawing.Point(545, 0);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.ReadOnly = true;
            this.dgvCiudades.Size = new System.Drawing.Size(296, 489);
            this.dgvCiudades.TabIndex = 2;
            // 
            // formRegistrarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegistrarCiudad";
            this.Text = "formRegistrarCiudad";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarCiu;
        private System.Windows.Forms.TextBox txtNombreCiu;
        private System.Windows.Forms.TextBox txtCodigoCiu;
        private System.Windows.Forms.Label lblNombreCiu;
        private System.Windows.Forms.Label lblCodigoCiu;
        private System.Windows.Forms.Label lblGestionarCiu;
        private System.Windows.Forms.DataGridView dgvCiudades;
    }
}