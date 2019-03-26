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
    public partial class formEliminarPAC : Form
    {
        clsPaciente objPaciente = new clsPaciente();
        public formEliminarPAC()
        {
            InitializeComponent();
            ActualizarPacientes();
        }

        private void ActualizarPacientes()
        {
            DataSet conjuntoDatos;
            conjuntoDatos = objPaciente.consultarPacientes();
            dgvEliminar.DataSource = conjuntoDatos;
            dgvEliminar.DataMember = "Resultado";
        }

        private void btnEliminarPAC_Click(object sender, EventArgs e)
        {
            if (dgvEliminar.SelectedRows.Count > 0)
            {
                long varID = long.Parse(dgvEliminar.CurrentRow.Cells["CC"].Value.ToString());

                if (objPaciente.eliminarPaciente(varID) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    ActualizarPacientes();

                    MessageBox.Show("Paciente Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Paciente no pudo ser Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Por favor, seleccione la fila a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int varID = int.Parse(txtID.Text);
                if (objPaciente.eliminarPaciente(varID) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    ActualizarPacientes();

                    MessageBox.Show("Paciente Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Paciente no pudo ser Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception varError)
            {

                MessageBox.Show(varError.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarPac_Click_1(object sender, EventArgs e)
        {
            if (dgvEliminar.SelectedRows.Count > 0)
            {
                int varID = int.Parse(dgvEliminar.CurrentRow.Cells["CC"].Value.ToString());

                if (objPaciente.eliminarPaciente(varID) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    ActualizarPacientes();

                    MessageBox.Show("Clinica Eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Clinica no pudo ser Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Por favor, seleccione la fila a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
