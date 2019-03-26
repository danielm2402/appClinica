namespace PryClinica.interfaz.paciente
{
    partial class formEliminarPAC
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
            System.Windows.Forms.Panel panel1;
            this.btnEliminarPac = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.btnEliminarPac);
            panel1.Controls.Add(this.dgvEliminar);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(549, 489);
            panel1.TabIndex = 1;
            // 
            // btnEliminarPac
            // 
            this.btnEliminarPac.Location = new System.Drawing.Point(31, 436);
            this.btnEliminarPac.Name = "btnEliminarPac";
            this.btnEliminarPac.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarPac.TabIndex = 14;
            this.btnEliminarPac.Text = "Eliminar Paciente";
            this.btnEliminarPac.UseVisualStyleBackColor = true;
            this.btnEliminarPac.Click += new System.EventHandler(this.btnEliminarPac_Click_1);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.AllowUserToAddRows = false;
            this.dgvEliminar.AllowUserToDeleteRows = false;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(12, 12);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.ReadOnly = true;
            this.dgvEliminar.Size = new System.Drawing.Size(531, 401);
            this.dgvEliminar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.lblNit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(549, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 489);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Eliminar por ID";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(89, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Paciente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 12;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNit.Location = new System.Drawing.Point(44, 90);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(23, 17);
            this.lblNit.TabIndex = 11;
            this.lblNit.Text = "ID:";
            // 
            // formEliminarPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEliminarPAC";
            this.Text = "formEliminarPAC";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPac;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNit;
    }
}