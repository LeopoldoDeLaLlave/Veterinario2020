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
         * Recibe el dni y la contraseña introducidos por el usuario y comprueba si coinciden
         */
        public Boolean comprobarLogin(String dni, String contrasena)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM usuario WHERE dni = @dni AND contrasena = @contrasena", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@contrasena", contrasena);
                MySqlDataReader resultado = consulta.ExecuteReader();
            
                if (resultado.Read())
                {
                    conexion.Close();
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
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
