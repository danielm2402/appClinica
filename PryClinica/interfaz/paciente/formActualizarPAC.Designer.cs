namespace PryClinica.interfaz.paciente
{
    partial class formActualizarPAC
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvActualizar = new System.Windows.Forms.DataGridView();
            this.pnlActualizarManual = new System.Windows.Forms.Panel();
            this.lbld = new System.Windows.Forms.Label();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEliminarClinica = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarPAC = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).BeginInit();
            this.pnlActualizarManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.btnEditar);
            this.pnlGrid.Controls.Add(this.dgvActualizar);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(532, 489);
            this.pnlGrid.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvActualizar
            // 
            this.dgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizar.Location = new System.Drawing.Point(12, 12);
            this.dgvActualizar.Name = "dgvActualizar";
            this.dgvActualizar.Size = new System.Drawing.Size(514, 400);
            this.dgvActualizar.TabIndex = 0;
            // 
            // pnlActualizarManual
            // 
            this.pnlActualizarManual.Controls.Add(this.lbld);
            this.pnlActualizarManual.Controls.Add(this.cbxEstadoCivil);
            this.pnlActualizarManual.Controls.Add(this.lblEliminarClinica);
            this.pnlActualizarManual.Controls.Add(this.lblID);
            this.pnlActualizarManual.Controls.Add(this.label2);
            this.pnlActualizarManual.Controls.Add(this.btnActualizarPAC);
            this.pnlActualizarManual.Controls.Add(this.txtApellido);
            this.pnlActualizarManual.Controls.Add(this.txtNombre);
            this.pnlActualizarManual.Controls.Add(this.lblDireccion);
            this.pnlActualizarManual.Controls.Add(this.lblNombre);
            this.pnlActualizarManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActualizarManual.Location = new System.Drawing.Point(532, 0);
            this.pnlActualizarManual.Name = "pnlActualizarManual";
            this.pnlActualizarManual.Size = new System.Drawing.Size(309, 489);
            this.pnlActualizarManual.TabIndex = 2;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lbld.Location = new System.Drawing.Point(126, 86);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(0, 13);
            this.lbld.TabIndex = 28;
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "soltero(a)",
            "casado(a)",
            "viudo(a)",
            "divorciado(a)"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(129, 214);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoCivil.TabIndex = 27;
            // 
            // lblEliminarClinica
            // 
            this.lblEliminarClinica.AutoSize = true;
            this.lblEliminarClinica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblEliminarClinica.Location = new System.Drawing.Point(89, 15);
            this.lblEliminarClinica.Name = "lblEliminarClinica";
            this.lblEliminarClinica.Size = new System.Drawing.Size(193, 21);
            this.lblEliminarClinica.TabIndex = 26;
            this.lblEliminarClinica.Text = "ACTUALIZAR PACIENTE";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(126, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estado Civil";
            // 
            // btnActualizarPAC
            // 
            this.btnActualizarPAC.Location = new System.Drawing.Point(93, 304);
            this.btnActualizarPAC.Name = "btnActualizarPAC";
            this.btnActualizarPAC.Size = new System.Drawing.Size(121, 23);
            this.btnActualizarPAC.TabIndex = 22;
            this.btnActualizarPAC.Text = "Actualizar Paciente";
            this.btnActualizarPAC.UseVisualStyleBackColor = true;
            this.btnActualizarPAC.Click += new System.EventHandler(this.btnActualizarPAC_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(129, 167);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(6, 167);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 17);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(6, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // formActualizarPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.pnlActualizarManual);
            this.Controls.Add(this.pnlGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formActualizarPAC";
            this.Text = "formActualizarPAC";
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).EndInit();
            this.pnlActualizarManual.ResumeLayout(false);
            this.pnlActualizarManual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvActualizar;
        private System.Windows.Forms.Panel pnlActualizarManual;
        private System.Windows.Forms.Label lblEliminarClinica;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarPAC;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
    }
}