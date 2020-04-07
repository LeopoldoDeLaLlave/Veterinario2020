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


    }
}
