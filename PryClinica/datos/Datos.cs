using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

// Insertar "librerias", son necesarias para que se reconozcan las palabras clave
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace PryClinica.datos
{
    class Datos
    {
        //Creacion de la cadena de conexión
        string cadenaConexion = "Data Source=localhost; User ID = system; Password=oracle";

        //Creación del Método que permite ejecutar un insert, update or delete.
        //retorna el numero de fila afectadas

        public int ejecutarDML (string consulta)
        {
            int filasAfectadas;
            //1.Creación de la conexión
            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            //2.Creación de un objeto tipo comando || es necesario para poder ejecutar un sentencia insert, update or delete.
            //recibe la consulta, que puede ser cualquier dml y la conexión que trabaja con la cadena de conexión
            OracleCommand comando = new OracleCommand(consulta, miConexion);


            //3.Abrir la conexión
            miConexion.Open();

            //4. Ejecución del comando, devuelve el # de filas afectadas
            //comando.ExecuteNonQuery(); || Método: algo que no es select.
            filasAfectadas = comando.ExecuteNonQuery();

            //5.Cerrar conexión
            miConexion.Close();


            return filasAfectadas;
        }
        public DataSet ejecutarSELECT(string consulta)
        {
            //Creacion de DataSet vacio
            DataSet ds = new DataSet();

            //Creación de adaptador || se usa pa ejecutar consultas de tipo Select

            OracleDataAdapter adaptador = new OracleDataAdapter(consulta,cadenaConexion);

            //Llenar el dataset a traves del adaptador ||fill: llena con registros el dataSet
            adaptador.Fill(ds, "Resultado");
            return ds;
        }
    }
}
