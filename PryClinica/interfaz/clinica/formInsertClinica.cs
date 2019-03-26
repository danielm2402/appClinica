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

namespace PryClinica
{
    public partial class formInsertClinica : Form
    {
        Clinica objClinica = new Clinica();
        public formInsertClinica()
        {
            //iniciamos el form con el grid 
            InitializeComponent();
            DataSet conjuntoDatos;
            conjuntoDatos = objClinica.consultarClinicas();
            dgvDatos.DataSource = conjuntoDatos;
            dgvDatos.DataMember = "Resultado";
        }

        
        private void btnResgistrarCli_Click(object sender, EventArgs e)
        {
            int varNit;
            string varNombre;
            string varDireccion;
            string varModalidad="Privada";
            int varCodCiudad;
            try
            {
                varNit = int.Parse(txtNit.Text);
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

                if(objClinica.registrarClinica(varNit, varNombre, varDireccion, varModalidad, varCodCiudad) == 1){
                    //actualizamos el grid
                    DataSet conjuntoDatos;
                    conjuntoDatos = objClinica.consultarClinicas();
                    dgvDatos.DataSource = conjuntoDatos;
                    dgvDatos.DataMember = "Resultado";

                    MessageBox.Show("Clinica insertada correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else{
                    MessageBox.Show("Clinica no insertada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    ;

            }
            catch (Exception varE)
            {

                MessageBox.Show(varE.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNit_Click(object sender, EventArgs e)
        {

        }

      
    }
}
