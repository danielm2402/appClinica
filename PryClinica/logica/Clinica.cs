using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Adcionar datos para que se pueda reconocer la clase
using PryClinica.datos;
using System.Data;


namespace PryClinica.logica
{
    class Clinica
    {

        //Creación de un objeto de la capa de datos para poder manipular los metodos que se encuentran alla
        Datos dt = new Datos();

        //Método que recibe los datos de la interfaz
        public int registrarClinica(int cliNit, string cliNombre, string cliDireccion, string cliModalidad, int cliCiudad)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "insert into Clinica(cliNit, cliNombre, cliDireccion, cliModalidad, ciucod) VALUES ("+ 
                cliNit + ",'" + cliNombre + "','"+ cliDireccion + "','" + cliModalidad +"'"+","+cliCiudad+")";

            return dt.ejecutarDML(consulta);
        }


        public int actualizarClinica(int cliNit, string cliNombre, string cliDireccion, string cliModalidad, int cliCiudad)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "update Clinica set clinombre=" + "'" + cliNombre + "'" + ",clidireccion='" + cliDireccion + "',climodalidad='" + cliModalidad + "',ciucod=" + cliCiudad + " where clinit=" + cliNit+"";

            return dt.ejecutarDML(consulta);
        }


        public int eliminarClinica(int cliNit)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "delete from Clinica where clinit="+cliNit+"";

            return dt.ejecutarDML(consulta);
        }

        public DataSet consultarClinicas()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = " select clinit Nit, clinombre Nombre, clidireccion Direccion, climodalidad Modalidad, ciucod CodigoCiudad from Clinica; ";
            
  
            miDs = dt.ejecutarSELECT(consulta);

            return miDs;
        }
    }
}
