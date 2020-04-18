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
                    new MySqlCommand("SELECT * FROM usuario WHERE dni = @dni", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                MySqlDataReader resultado = consulta.ExecuteReader();
            
                if (resultado.Read())
                {
                    string passwordHash = resultado.GetString("contrasena");
                    
                    conexion.Close();
                    return BCrypt.Net.BCrypt.Verify(contrasena, passwordHash); //Si la contraseña introducida coincide con la de la base de datos sin el hash devuelve true
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


        /*
        * Recibe el dni y la contraseña introducidos por el usuario y comprueba si coinciden
         */
        public void addUser(String nombre, String apellido, String dni, String email, String dir, String telefono, String pass)
        {
            //Cramos una variable con la fecha actual para guardarla en fecha de registro
            DateTime now = DateTime.Now;
            String fecha = Convert.ToDateTime(now.ToString().Substring(0, 10)).ToString("yyyy-MM-dd");

            try
            {
                //"INSERT INTO profesor VALUES (@dni, FALSE, @nombre, @apellido, @email, @telefono, @dir,'"+fecha+"', @pass), " String nombre, String apellido, String dni, String email, String dir, String telefono, String pass
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuario VALUES (@dni, FALSE, @nombre, @apellido, @email, @telefono, @dir,'" + fecha + "', @pass)", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@pass", pass);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@dir", dir);
                consulta.Parameters.AddWithValue("@telefono", telefono);

                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
            }
            catch (MySqlException e)
            {
                
            }
        }

        /*
         * Recibe un una consulta y si hay datos que coinciden devuelve true
        */
        public Boolean comprobarId(String str)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand(str, conexion);
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

    }
}
