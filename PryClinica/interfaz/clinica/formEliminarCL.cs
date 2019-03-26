using PryClinica.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryClinica.interfaz.clinica
{
    public partial class formEliminarCL : Form
    {
        Clinica objClinica = new Clinica();
        public formEliminarCL()
        {
            InitializeComponent();
            //Crear otra vez el objeto para refrescar al cambiar vistas
            Clinica objClinica = new Clinica();
            // Llenamos el grid con todos los datos de la tabla Clinica
            DataSet conjuntoDatos;
            conjuntoDatos = objClinica.consultarClinicas();
            dgvEliminar.DataSource = conjuntoDatos;
            dgvEliminar.DataMember = "Resultado";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEliminar.SelectedRows.Count > 0)
            {
                int varNit = int.Parse(dgvEliminar.CurrentRow.Cells["Nit"].Value.ToString());
                
                if (objClinica.eliminarClinica(varNit) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    DataSet conjuntoDatos;
                    conjuntoDatos = objClinica.consultarClinicas();
                    dgvEliminar.DataSource = conjuntoDatos;
                    dgvEliminar.DataMember = "Resultado";

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

      

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int varNit = int.Parse(txtNit.Text);
                if (objClinica.eliminarClinica(varNit) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    DataSet conjuntoDatos;
                    conjuntoDatos = objClinica.consultarClinicas();
                    dgvEliminar.DataSource = conjuntoDatos;
                    dgvEliminar.DataMember = "Resultado";

                    MessageBox.Show("Clinica Eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Clinica no pudo ser Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception varError)
            {

                MessageBox.Show(varError.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCL_Click(object sender, EventArgs e)
        {
            if (dgvEliminar.SelectedRows.Count > 0)
            {
                int varID = int.Parse(dgvEliminar.CurrentRow.Cells["NIT"].Value.ToString());

                if (objClinica.eliminarClinica(varID) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    DataSet conjuntoDatos;
                    conjuntoDatos = objClinica.consultarClinicas();
                    dgvEliminar.DataSource = conjuntoDatos;
                    dgvEliminar.DataMember = "Resultado";


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
