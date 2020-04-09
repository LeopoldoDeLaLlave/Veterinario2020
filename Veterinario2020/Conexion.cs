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
                    new MySqlCommand("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, tipo_vacuna AS Vacuna  FROM cita WHERE `chip_mascota`='" + chip +
                    "' AND motivo = 'Vacuna' AND tipo_vacuna IS NOT NULL", conexion);
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


        //Obtenemos las citas que ha tenido un usuario
        public DataTable obtenerCitasAsignadas(String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, m.nombre AS mascota, c.motivo AS Motivo, c.precio AS Precio FROM mascota m, cita c " +
                    "WHERE m.n_chip = c.chip_mascota AND m.propietario = '" +dni+"'", conexion);
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

        //Obtenemos citas disponibles de revisiones
        public DataTable obtenerRevisiones()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Revisión'", conexion);
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


        //Obtenemos citas disponibles de vacunas
        public DataTable obtenerVacunas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Vacuna'", conexion);
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


        //Obtenemos citas disponibles de peluquería
        public DataTable obtenerPeluqueria()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Peluquería'", conexion);
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

        //Obtenemos citas disponibles de otros
        public DataTable obtenerOtros()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Otros'", conexion);
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

        //Obtenemos el chiip del animal a traves del nombre del animal y el dni del dueño
        public String obtenerChip(String nombre, String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT n_chipFROM mascota  WHERE nombre = '"+nombre+"' AND dni ="+ dni + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
                return "";
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        //Reserva una cita
        public void ReservaCita(String chip, String h, String f)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("UPDATE cita SET chip_mascota = '" +chip + "' where fecha='" + f + "' AND hora='"+h+"';", conexion);
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
