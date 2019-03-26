using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PryClinica.datos;
using System.Data;

namespace PryClinica.logica
{
    class clsAtiente
    {
        //Creación de un objeto de la capa de datos para poder manipular los metodos que se encuentran alla
        Datos dt = new Datos();

        //Método que recibe los datos de la interfaz
        public int registrarAtencion(string parFechaAtencion, int parNit, long parIdPaciente)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "insert into Atiende(atiFechaAtencion, cliNit, pacId) VALUES (to_date('" + parFechaAtencion+ "','dd/mon/yyyy hh:mi A.M.')," + parNit + "," + parIdPaciente + ")";

            return dt.ejecutarDML(consulta);
        }



  
    }
}
