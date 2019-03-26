using PryClinica.datos;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PryClinica.logica
{
    class clsCiudad
    {
        //Creación de un objeto de la capa de datos para poder manipular los metodos que se encuentran alla
        Datos dt = new Datos();

        //Método que recibe los datos de la interfaz
        public int registrarCiudad(int ciuId, string ciuNombre)
        {
            //Consulta que permite registrar una clinica
            string consulta;

            consulta = "insert into Ciudad(ciuCod, ciuNombre) VALUES (" +
                ciuId + ",'" + ciuNombre + "')";

            return dt.ejecutarDML(consulta);
        }


      
        public DataSet consultarCiudades()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select ciuCod CODIGO, ciuNombre Nombre from Ciudad;";


            miDs = dt.ejecutarSELECT(consulta);

            return miDs;
        }
    }
}
