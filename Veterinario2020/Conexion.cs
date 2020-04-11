using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Veterinario2020
{

    /*
     * Autor: Javier de la Llave
     * 
     * Está clase se encarga de realizar la conexión con la base de datos
     */
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                //Nos conectamos a la base de datos
                conexion = new MySqlConnection("Server = 192.168.182.137; Database = veterinario; Uid = root; Pwd=; Port=3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }


        /*
         * Recibe una consulta y devuelve una tabla con el resultado de esa consulta
         */
        public DataTable obtenerDatos(String str)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand(str, conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(resultado);
                conexion.Close();
                return tabla;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        //Recibe código para modificar la tabla
        public void modificaTabla(String str)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand(str, conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();

            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


    }
}
