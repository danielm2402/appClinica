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

namespace PryClinica.interfaz
{
    public partial class formActualizarCL : Form
    {
        Clinica objClinica = new Clinica();
        public formActualizarCL()
        {
            InitializeComponent();
            DataSet conjuntoDatos;
            conjuntoDatos = objClinica.consultarClinicas();
            dgvActualizar.DataSource = conjuntoDatos;
            dgvActualizar.DataMember = "Resultado";
        }
       
        private void btnActualizarCl_Click(object sender, EventArgs e)
        {

            int varNit;
            string varNombre;
            string varDireccion;
            string varModalidad = "Privada";
            int varCodCiudad;
            try
            {
                varNit = int.Parse(lblID.Text);
                varDireccion = txtDireccion.Text;
                varCodCiudad = int.Parse(txtCodCiudad.Text);
                varNombre = txtNombre.Text;
                if (rbtPrivada.Checked)
                {
                    varModalidad = "Privada";
                }
                else if (rbtPublica.Checked)
                {
                    varModalidad = "Publica";
                }

                if (objClinica.actualizarClinica(varNit,varNombre,varDireccion,varModalidad,varCodCiudad) == 1)
                {
                    //Refrescamos la vista del grid con los datos actualizados
                    DataSet conjuntoDatos;
                    conjuntoDatos = objClinica.consultarClinicas();
                    dgvActualizar.DataSource = conjuntoDatos;
                    dgvActualizar.DataMember = "Resultado";

                    MessageBox.Show("Clinica Actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Clinica no pudo ser actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    

            }
            catch (Exception varE)
            {

                MessageBox.Show(varE.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si se seleccionó la fila completa, haga
            if(dgvActualizar.SelectedRows.Count > 0)
            {
                //asigna lo que trae le celda "nombre" al text de los edit o label en el caso de ID (id no se puede modificar)
                lblID.Text= dgvActualizar.CurrentRow.Cells["Nit"].Value.ToString();
                txtNombre.Text = dgvActualizar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgvActualizar.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCodCiudad.Text = dgvActualizar.CurrentRow.Cells["CODIGOCIUDAD"].Value.ToString();

            }
            else{
                MessageBox.Show("Seleccione la fila a editar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

       
    }
}
