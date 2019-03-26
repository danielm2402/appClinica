using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PryClinica.logica;
using System.Data;
using PryClinica.interfaz.clinica;
using PryClinica.interfaz;
using PryClinica.interfaz.paciente;
using PryClinica.interfaz.ciudad;

namespace PryClinica
{
    public partial class Form1 : Form
    {


        clsAtiente objAtiende = new clsAtiente();
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RelesaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Form1()
        {
            InitializeComponent();
            // inicia con un form por defecto, en este caso insertar
            formInsertClinica frmInClinica = new formInsertClinica();
            AbrirFormGenerico(frmInClinica, pnlSelected);
            dt.Format = DateTimePickerFormat.Custom;
            dt.CustomFormat = "dd-MM-yyyy hh:mm:ss";
        }
    

      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            RelesaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlGestionar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizarCl_Click(object sender, EventArgs e)
        {

        }

   
        private void AbrirFormGenerico(object formhijo, Panel parPanel)
        {
            if (parPanel.Controls.Count > 0)
            {
                parPanel.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            parPanel.Controls.Add(fh);
            parPanel.Tag = fh;
            fh.Show();
        }

        private void btnRegistrarCl_Click(object sender, EventArgs e)
        {
            // si se saca el objeto no se reinicia al hacer cambios de vistas
            formInsertClinica frmInClinica = new formInsertClinica();
            AbrirFormGenerico(frmInClinica, pnlSelected);
      
           
        }

        private void btnActualizarCl_Click_1(object sender, EventArgs e)
        {
            formActualizarCL frmAcClinica = new formActualizarCL();
            AbrirFormGenerico(frmAcClinica , pnlSelected);
        }

        private void btnEliminarCl_Click(object sender, EventArgs e)
        {
            formEliminarCL frmElClinica = new formEliminarCL();
            AbrirFormGenerico(frmElClinica, pnlSelected);
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            formInsertPAC frmInClinica = new formInsertPAC();
          
            AbrirFormGenerico(frmInClinica, pnlSelected2);
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            formActualizarPAC frmAcPaciente = new formActualizarPAC();
            AbrirFormGenerico(frmAcPaciente, pnlSelected2);
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            formEliminarPAC frmElPaciente = new formEliminarPAC();
            AbrirFormGenerico(frmElPaciente, pnlSelected2);

        }

        private void btnRegistrarCiudad_Click(object sender, EventArgs e)
        {
            formRegistrarCiudad frmRegistrarCiudad = new formRegistrarCiudad();
            AbrirFormGenerico(frmRegistrarCiudad, pnlContenedor3);
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                long varIDPaciente;
                int varNit;
                string fechaAtencion;

                varNit = int.Parse(txtNit.Text);
                varIDPaciente = long.Parse(txtPaciente.Text);
                fechaAtencion = dt.Value.ToString();

                if (objAtiende.registrarAtencion(fechaAtencion,varNit,varIDPaciente) == 1)
                {
                    MessageBox.Show("Atención insertada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Atención no insertada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception varError)
            {

                MessageBox.Show( varError.Message,"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
