using PryClinica.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryClinica.logica
{
    class clsPaciente
    {
        //Creación de un objeto de la capa de datos para poder manipular los metodos que se encuentran alla
        Datos dt = new Datos();

        //Método que recibe los datos de la interfaz
        public int registrarPaciente(long pacId, string pacNombre, string pacApellido, string pacEstadoCivil)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "insert into Paciente(pacId, pacNombre, pacApellido, pacEstadoCivil) VALUES (" +
                pacId + ",'" + pacNombre + "','" + pacApellido + "','" +pacEstadoCivil + "')";

            return dt.ejecutarDML(consulta);
        }


        public int actualizarPaciente(long pacId, string pacNombre, string pacApellido, string pacEstadoCivil)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "update Paciente set pacNombre=" + "'" + pacNombre + "'" + ",pacApellido='" + pacApellido + "',pacEstadoCivil='" + pacEstadoCivil + "' where pacId=" + pacId + "";

            return dt.ejecutarDML(consulta);
        }


        public int eliminarPaciente(long pacId)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "delete from Paciente where pacId=" + pacId + "";

            return dt.ejecutarDML(consulta);
        }

        public DataSet consultarPacientes()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select pacid CC, pacNombre Nombre, pacApellido Apellido, pacEstadoCivil EstadoCivil from Paciente;";


            miDs = dt.ejecutarSELECT(consulta);

            return miDs;
        }
    }
}
