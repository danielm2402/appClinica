namespace PryClinica.interfaz
{
    partial class formActualizarCL
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarCl = new System.Windows.Forms.Button();
            this.rbtPrivada = new System.Windows.Forms.RadioButton();
            this.rbtPublica = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEliminarClinica = new System.Windows.Forms.Label();
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
            this.pnlGrid.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
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
            this.pnlActualizarManual.Controls.Add(this.lblEliminarClinica);
            this.pnlActualizarManual.Controls.Add(this.lblID);
            this.pnlActualizarManual.Controls.Add(this.txtCodCiudad);
            this.pnlActualizarManual.Controls.Add(this.label2);
            this.pnlActualizarManual.Controls.Add(this.btnActualizarCl);
            this.pnlActualizarManual.Controls.Add(this.rbtPrivada);
            this.pnlActualizarManual.Controls.Add(this.rbtPublica);
            this.pnlActualizarManual.Controls.Add(this.txtDireccion);
            this.pnlActualizarManual.Controls.Add(this.txtNombre);
            this.pnlActualizarManual.Controls.Add(this.lblDireccion);
            this.pnlActualizarManual.Controls.Add(this.lblModalidad);
            this.pnlActualizarManual.Controls.Add(this.lblNombre);
            this.pnlActualizarManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActualizarManual.Location = new System.Drawing.Point(532, 0);
            this.pnlActualizarManual.Name = "pnlActualizarManual";
            this.pnlActualizarManual.Size = new System.Drawing.Size(309, 489);
            this.pnlActualizarManual.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(126, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 25;
            // 
            // txtCodCiudad
            // 
            this.txtCodCiudad.Location = new System.Drawing.Point(129, 170);
            this.txtCodCiudad.Name = "txtCodCiudad";
            this.txtCodCiudad.Size = new System.Drawing.Size(167, 20);
            this.txtCodCiudad.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Código Ciudad: ";
            // 
            // btnActualizarCl
            // 
            this.btnActualizarCl.Location = new System.Drawing.Point(93, 341);
            this.btnActualizarCl.Name = "btnActualizarCl";
            this.btnActualizarCl.Size = new System.Drawing.Size(121, 23);
            this.btnActualizarCl.TabIndex = 22;
            this.btnActualizarCl.Text = "Actualizar Clinica";
            this.btnActualizarCl.UseVisualStyleBackColor = true;
            this.btnActualizarCl.Click += new System.EventHandler(this.btnActualizarCl_Click);
            // 
            // rbtPrivada
            // 
            this.rbtPrivada.AutoSize = true;
            this.rbtPrivada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.rbtPrivada.Location = new System.Drawing.Point(129, 262);
            this.rbtPrivada.Name = "rbtPrivada";
            this.rbtPrivada.Size = new System.Drawing.Size(61, 17);
            this.rbtPrivada.TabIndex = 21;
            this.rbtPrivada.TabStop = true;
            this.rbtPrivada.Text = "Privada";
            this.rbtPrivada.UseVisualStyleBackColor = true;
          //  this.rbtPrivada.CheckedChanged += new System.EventHandler(this.rbtPrivada_CheckedChanged);
            // 
            // rbtPublica
            // 
            this.rbtPublica.AutoSize = true;
            this.rbtPublica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.rbtPublica.Location = new System.Drawing.Point(129, 238);
            this.rbtPublica.Name = "rbtPublica";
            this.rbtPublica.Size = new System.Drawing.Size(60, 17);
            this.rbtPublica.TabIndex = 20;
            this.rbtPublica.TabStop = true;
            this.rbtPublica.Text = "Pública";
            this.rbtPublica.UseVisualStyleBackColor = true;
//            this.rbtPublica.CheckedChanged += new System.EventHandler(this.rbtPublica_CheckedChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 119);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(6, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 17);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblModalidad.Location = new System.Drawing.Point(6, 229);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(83, 17);
            this.lblModalidad.TabIndex = 15;
            this.lblModalidad.Text = "Modalidad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(6, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEliminarClinica
            // 
            this.lblEliminarClinica.AutoSize = true;
            this.lblEliminarClinica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.lblEliminarClinica.Location = new System.Drawing.Point(89, 15);
            this.lblEliminarClinica.Name = "lblEliminarClinica";
            this.lblEliminarClinica.Size = new System.Drawing.Size(158, 21);
            this.lblEliminarClinica.TabIndex = 26;
            this.lblEliminarClinica.Text = "ELIMINAR CLÍNICA";
            // 
            // formActualizarCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(841, 489);
            this.Controls.Add(this.pnlActualizarManual);
            this.Controls.Add(this.pnlGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formActualizarCL";
            this.Text = "formActualizarCL";
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).EndInit();
            this.pnlActualizarManual.ResumeLayout(false);
            this.pnlActualizarManual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvActualizar;
        private System.Windows.Forms.Panel pnlActualizarManual;
        private System.Windows.Forms.TextBox txtCodCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarCl;
        private System.Windows.Forms.RadioButton rbtPrivada;
        private System.Windows.Forms.RadioButton rbtPublica;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEliminarClinica;
    }
}