﻿using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario2020
{
    /*
     * Autor:Javier de la Llave
     * 
     * Interfaz del usuario donde apareceran sus datos, sus mascotas, las citas que ha tenido, y podrá obtener cita
     */

    public partial class FormUsuario : Form
    {



        Conexion c2 = new Conexion();

        public DataTable datosUsuarios = new DataTable();//Aquí guardamos los datos de los usuarios
        public DataTable datosMascotas = new DataTable();//Aquí guardamos los datos de las mascotas
        

        /*
         * dUsuarios: Recibe todos los datos del usuario en forma de datatable
         */
        public FormUsuario(DataTable dUsuarios)
        {
            InitializeComponent();
            datosUsuarios = dUsuarios;//Obtenemos los datos de los usuarios
            this.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();//Ponemos el nombre del usuario de título del form
            ponerDatos();
            ponerMascotas();
        
            dataGridView1.DataSource = c2.obtenerCitasAsignadas(datosUsuarios.Rows[0]["dni"].ToString());//Ponemos el historial de citas

            dataGridView2.DataSource = c2.obtenerRevisiones();//Ponemos las revisiones libres

            dataGridView3.DataSource = c2.obtenerVacunas();//Ponemos las revisiones libres

            dataGridView4.DataSource = c2.obtenerPeluqueria();//Ponemos las revisiones libres

            dataGridView5.DataSource = c2.obtenerOtros();//Ponemos las revisiones libres
        }

        //Pone en pantalla los datos de los usuarios
        private void ponerDatos()
        {
            labelNombre.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();
            labelTelefono.Text = datosUsuarios.Rows[0]["telefono"].ToString();
            labelDir.Text = datosUsuarios.Rows[0]["direccion"].ToString();
            labelDni.Text = datosUsuarios.Rows[0]["dni"].ToString();
            labelEmail.Text = datosUsuarios.Rows[0]["email"].ToString();
            labelAlta.Text = datosUsuarios.Rows[0]["fecha_alta"].ToString();
        }

        //Crea una lista con los nombres de las mascotas.
        private void ponerMascotas()
        {
            datosMascotas = c2.obtenerTablaMascotas(datosUsuarios.Rows[0]["dni"].ToString());//Obtenemos los datos de las mascotas del usuario que está en sesión
            int numColumnas = datosMascotas.Rows.Count;//Obtenemos el número de mascotas que tiene
            
            //Vamos poniendo los nombres de las mascotas uno debajo de otro
            for (int i = 0; i < numColumnas; i++)
            {
                if (i == 0)
                {
                    lMascota1.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 1)
                {
                    lMascota2.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 2)
                {
                    lMascota3.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 3)
                {
                    lMascota4.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 4)
                {
                    lMascota5.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 5)
                {
                    lMascota6.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 6)
                {
                    lMascota7.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else
                {
                    lMascota8.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }


        //Abre la ficha con los datos de la mascota pulsada
        private void abrirDatosMascota(int indiceMascota)
        {

            FormDatosMascota fdm = new FormDatosMascota(indiceMascota, datosMascotas, datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString());
            fdm.ShowDialog();
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota1_Click(object sender, EventArgs e)
        {
            if (lMascota1.Text.Length>0)
            {
                abrirDatosMascota(0);
            }
            
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota2_Click(object sender, EventArgs e)
        {
            if (lMascota2.Text.Length > 0)
            {
                abrirDatosMascota(1);
            }
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota3_Click(object sender, EventArgs e)
        {
            if (lMascota3.Text.Length > 0)
            {
                abrirDatosMascota(2);
            }
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota4_Click(object sender, EventArgs e)
        {
            if (lMascota4.Text.Length > 0)
            {
                abrirDatosMascota(3);
            }
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota5_Click(object sender, EventArgs e)
        {
            if (lMascota5.Text.Length > 0)
            {
                abrirDatosMascota(4);
            }
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota6_Click(object sender, EventArgs e)
        {
            if (lMascota6.Text.Length > 0)
            {
                abrirDatosMascota(5);
            }
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota7_Click(object sender, EventArgs e)
        {
            if (lMascota7.Text.Length > 0)
            {
                abrirDatosMascota(6);
            }
        }

        //Llama al método que abre la ficha de la mascota, solo la abrirá si hay nombre en el label
        private void lMascota8_Click(object sender, EventArgs e)
        {
            if (lMascota8.Text.Length > 0)
            {
                abrirDatosMascota(7);
            }
        }

   
    }
}
