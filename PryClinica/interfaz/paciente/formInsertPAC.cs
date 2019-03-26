using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryClinica.logica;

namespace PryClinica.interfaz.paciente
{
    public partial class formInsertPAC : Form
    {
        clsPaciente objPaciente = new clsPaciente();
        public formInsertPAC()
        {
            InitializeComponent();
            ActualizarPacientes();
        }

        private void btnResgistrarPac_Click(object sender, EventArgs e)
        {
            long varID;
            string varNombre;
            string varApellido;
            string varEstado;
         
            try
            {
                varID = long.Parse(txtIdPac.Text);
                varApellido = txtApePac.Text;
                varNombre = txtNombrePac.Text;
                varEstado = cbxEstadoCivil.SelectedItem.ToString();
                

                if (objPaciente.registrarPaciente(varID, varNombre, varApellido, varEstado) == 1)
                {
                    //actualizamos el grid
                    ActualizarPacientes();

                    MessageBox.Show("Paciente insertado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Paciente no insertada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    ;

            }
            catch (Exception varE)
            {

                MessageBox.Show(varE.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActualizarPacientes()
        {
            DataSet conjuntoDatos;
            conjuntoDatos = objPaciente.consultarPacientes();
            dgvDatos.DataSource = conjuntoDatos;
            dgvDatos.DataMember = "Resultado";
        }


    }
}
