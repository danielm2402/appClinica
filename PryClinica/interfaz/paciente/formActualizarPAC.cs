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
    public partial class formActualizarPAC : Form
    {
        clsPaciente objPaciente = new clsPaciente();
        public formActualizarPAC()
        {
            InitializeComponent();
            ActualizarPacientes();
        }
        private void ActualizarPacientes(){
            DataSet conjuntoDatos;
            conjuntoDatos = objPaciente.consultarPacientes();
            dgvActualizar.DataSource = conjuntoDatos;
            dgvActualizar.DataMember = "Resultado";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvActualizar.SelectedRows.Count > 0)
            {
                //asigna lo que trae le celda "nombre" al text de los edit o label en el caso de ID (id no se puede modificar)
                lbld.Text = dgvActualizar.CurrentRow.Cells["CC"].Value.ToString();
                txtNombre.Text = dgvActualizar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvActualizar.CurrentRow.Cells["Apellido"].Value.ToString();
                cbxEstadoCivil.SelectedItem = dgvActualizar.CurrentRow.Cells["EstadoCivil"].Value.ToString();     

            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnActualizarPAC_Click(object sender, EventArgs e)
        {
           long varID;
            string varNombre;
            string varApellido;
            string varEstado;

            try
            {
                varID = long.Parse(lbld.Text);
                varApellido = txtApellido.Text;
                varNombre = txtNombre.Text;
                varEstado = cbxEstadoCivil.SelectedItem.ToString();


                if (objPaciente.actualizarPaciente(varID,varNombre,varApellido,varEstado) == 1)
                {
                    //actualizamos el grid
                    ActualizarPacientes();

                    MessageBox.Show("Paciente Actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Paciente NO se actualizó", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    ;

            }
            catch (Exception varE)
            {

                MessageBox.Show(varE.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   
}
