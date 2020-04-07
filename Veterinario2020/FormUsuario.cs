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
    public partial class FormUsuario : Form
    {


        VentanaLogin vl = new VentanaLogin();
        public DataTable datosUsuarios = new DataTable();
        Conexion c2 = new Conexion();
        public DataTable datosMascotas = new DataTable();


        public FormUsuario(DataTable dUsuarios)
        {
            InitializeComponent();
            datosUsuarios = dUsuarios;
            this.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();
            ponerDatos();
            ponerMascotas();

        }

        private void ponerDatos()
        {
            labelNombre.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();
            labelTelefono.Text = datosUsuarios.Rows[0]["telefono"].ToString();
            labelDir.Text = datosUsuarios.Rows[0]["direccion"].ToString();
            labelDni.Text = datosUsuarios.Rows[0]["dni"].ToString();
            labelEmail.Text = datosUsuarios.Rows[0]["email"].ToString();
            labelAlta.Text = datosUsuarios.Rows[0]["fecha_alta"].ToString();
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }

        private void ponerMascotas()
        {
            datosMascotas = c2.obtenerTablaMascotas(datosUsuarios.Rows[0]["dni"].ToString());
            int numColumnas = datosMascotas.Rows.Count;
            for(int i = 0; i<numColumnas; i++)
            {
                if (i==0)
                {
                    lMascota1.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if(i == 1)
                {
                    lMascota2.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }else if (i == 2)
                {
                    lMascota3.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if(i == 3)
                {
                    lMascota4.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }else if (i == 4)
                {
                    lMascota5.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if (i == 5)
                {
                    lMascota6.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
                else if(i == 6)
                {
                    lMascota7.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }else
                {
                    lMascota8.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }


            }

        }
    }
}
