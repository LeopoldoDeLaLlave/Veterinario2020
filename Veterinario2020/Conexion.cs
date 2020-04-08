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

        //Obtenemos todos los datos de un usuario a partir de su DNI
        public DataTable obtenerTablaUsuario(String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM usuario WHERE dni ='" + dni + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuarios = new DataTable();
                usuarios.Load(resultado);
                conexion.Close();
                return usuarios;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        //Obtenemos las mascotas y sus datos de un usuario
        public DataTable obtenerTablaMascotas(String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota WHERE `propietario`='" + dni + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        //Obtenemos las vacunas de un perro
        public DataTable obtenerVacunas(String chip)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT fecha AS Fecha, tipo_vacuna AS Vacuna  FROM cita WHERE `chip_mascota`='" + chip + 
                    "' AND motivo = 'Vacuna'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
