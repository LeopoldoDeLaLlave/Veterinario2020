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
     * Autor: Javier de la Llave
     * 
     * En esta clase se puede anular una cita previamente reservada
     */ 
     
    public partial class FormAnularCita : Form
    {

        Conexion c5 = new Conexion();

        String dni = "";
        String fecha = "";
        String hora = "";
        int nCita = 0;
        DataGridView revisiones = new DataGridView();
        DataGridView vacunas = new DataGridView();
        DataGridView peluqueria = new DataGridView();
        DataGridView otros = new DataGridView();
        DataGridView proximasCitas = new DataGridView();


        /*
         * String: Dni del usuario que va a anular la reserva
         * 
         * String f: Fecha de la cita
         * 
         * String h: hora de la cita
         * 
         * int c: número de la cita
         * 
         * dg1: datagridview con las revisiones
         * 
         * dg2: datagridview con las vacunas
         * 
         * dg3: datagridview con la peluquería
         * 
         * dg4: datagridview con Otros
         * 
         * dg5: datagridview con citas futuras
         */
        public FormAnularCita(String d, String f, String h, int c, DataGridView dg1, DataGridView dg2, DataGridView dg3, DataGridView dg4, DataGridView dg5)
        {
            dni = d;
            fecha = f;
            hora = h;
            nCita = c;
            revisiones = dg1;
            vacunas = dg2;
            peluqueria = dg3;
            otros = dg4;
            proximasCitas = dg5;
            InitializeComponent();

            label1.Text = fecha + ", a las " + hora;
        }

        /*
         * Cancela la cita y actualiza los datagridview correspondientes
         */
        private void button1_Click(object sender, EventArgs e)
        {
            c5.anularCita(nCita);

            //Actualizamos los datagridview con las citas disponibles
            revisiones.DataSource = c5.obtenerRevisiones();//Ponemos las revisiones libres

            vacunas.DataSource = c5.obtenerVacunas();//Ponemos las revisiones libres

            peluqueria.DataSource = c5.obtenerPeluqueria();//Ponemos las revisiones libres

            otros.DataSource = c5.obtenerOtros();//Ponemos las revisiones libres
            
            //Actualizamos el datagridview con las citas programadas
            proximasCitas.DataSource = c5.obtenerProximasCitas(dni);//Actualizamos las revisiones libres

            this.Hide();
        }
    }
}
