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
using System.Data;


namespace PryClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creacion del objeto de la capa de la logica de la clase Clinica
        Clinica cl = new Clinica();

        //Método que registra una Clínica
        private void btnResgistrarCli_Click(object sender, EventArgs e)
        {
            //.Capturar los datos de la interfaz y guardar en variables
            int resul = 0;
            int cliNit;
            string cliNombre, cliDireccion, cliModalidad="";
            cliNit = int.Parse(txtNit.Text);
            cliNombre = txtNombre.Text;
            cliDireccion = txtDireccion.Text;

            try
            {



                if (rbtPrivada.Checked) //activo
                {
                    cliModalidad = "Privada";
                }
                else if (rbtPublica.Checked)
                {
                    cliModalidad = "Pública";
                }

                //2.Enviar variables a la capa de logica al metodo que permita ingresar una clinica

                resul = cl.registrarClinica(cliNit, cliNombre, cliDireccion, cliModalidad);

                if (resul == 1)
                {
                    MessageBox.Show("Clínica registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

       private void btnConsultaDatos_Click(object sender, EventArgs e)
        {
            //1. Creación del DataSet
            DataSet conjuntoDatos;

            //toca con la tabla atiende
            //2. Llenar dataSet 
            conjuntoDatos = cl.consultarDatos();

            //3.Indicar a la grilla cual es la fuente de datos
            dvgConsultaDatos.DataSource = conjuntoDatos;

            //4.
            dvgConsultaDatos.DataMember = "ResultadoDatos";
        }
    }
}
