namespace PryClinica.interfaz.clinica
{
    partial class formEliminarCL
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
            this.btnEliminarCL = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.btnEliminarCL);
            panel1.Controls.Add(this.dgvEliminar);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(549, 489);
            panel1.TabIndex = 0;
            // 
            // btnEliminarCL
            // 
            this.btnEliminarCL.Location = new System.Drawing.Point(12, 436);
            this.btnEliminarCL.Name = "btnEliminarCL";
            this.btnEliminarCL.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarCL.TabIndex = 13;
            this.btnEliminarCL.Text = "Eliminar Clínica";
            this.btnEliminarCL.UseVisualStyleBackColor = true;
            this.btnEliminarCL.Click += new System.EventHandler(this.btnEliminarCL_Click);
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(110, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Clínica";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNit);
            this.panel2.Controls.Add(this.lblNit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(549, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 489);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Eliminar por NIT";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(110, 132);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(121, 20);
            this.txtNit.TabIndex = 12;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNit.Location = new System.Drawing.Point(37, 135);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(31, 17);
            this.lblNit.TabIndex = 11;
            this.lblNit.Text = "NIT: ";
            // 
            // formEliminarCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEliminarCL";
            this.Text = "formEliminarCL";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Button btnEliminarCL;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
    }
}