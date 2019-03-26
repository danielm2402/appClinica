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

namespace PryClinica.interfaz.ciudad
{
    public partial class formRegistrarCiudad : Form
    {
        clsCiudad objCiudad = new clsCiudad();
        public formRegistrarCiudad()
        {
            
            InitializeComponent();
            ActualizarCiudades();
        }

        private void btnRegistrarCiu_Click(object sender, EventArgs e)
        {
            int varID;
            string varNombre;
           

            try
            {
                varID = int.Parse(txtCodigoCiu.Text);
                varNombre = txtNombreCiu.Text;

                if (varID > 0)
                {
                    if (objCiudad.registrarCiudad(varID, varNombre) == 1)
                    {
                        //actualizamos el grid
                        ActualizarCiudades();

                        MessageBox.Show("Ciudad insertada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Ciudad no insertada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ciudad no insertada, ID no puede ser negativo o igual a cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
     

            }
            catch (Exception varE)
            {

                MessageBox.Show(varE.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCiudades()
        {
            DataSet conjuntoDatos;
            conjuntoDatos = objCiudad.consultarCiudades();
            dgvCiudades.DataSource = conjuntoDatos;
            dgvCiudades.DataMember = "Resultado";
        }
    }
}
