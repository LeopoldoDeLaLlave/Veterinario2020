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
    public partial class FormElegirCita : Form
    {

        Conexion c4 = new Conexion();

        DataTable mascotas = new DataTable();//Datos de las mascotas del usuario
        string fecha = "";//fecha seleccionada
        string hora = "";//Hora seleccionado
        string motivo = "";//Motivo de la cita
        DataGridView aux = new DataGridView(); //guardaremos el datagridview usado para actualizarlo
        DataGridView citasFuturas = new DataGridView(); //Al reservar una cita actuaizamos las próximas citas

        /*
         * DataTable dm: todas las mascotas del usuario que está usando la aplicación
         * 
         * string f: fecha de lacita seleccionada
         * 
         * string h: hora de la cita seleccionada
         * 
         * string mot: motivo cita seleccionada
         * 
         * DataGridView dg: datagridview usado
         * 
         * DataGridView dg2: datagridview con las próximas citas
         */
        public FormElegirCita(DataTable dm, string f, string h, string mot, DataGridView dg, DataGridView dg2)
        {
            mascotas = dm;
            fecha = f;
            hora = h;
            motivo = mot;
            aux=dg;
            citasFuturas = dg2;


            InitializeComponent();
            fillCombo();

            labelDatos.Text =fecha + ", a las " + hora;
        }

        //Pone en un combobox los nombres de las mascotas
        void fillCombo()
        {

            int numColumnas = mascotas.Rows.Count;//Obtenemos el número de mascotas que tiene
            for (int i = 0; i < numColumnas; i++)
            {
                comboBox1.Items.Add(mascotas.Rows[i]["nombre"].ToString());
            }
        }

        //Comprueba que se ha introducido una mascota y le reserva la cita
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "" )
            {
                DataRow[] foundRows;
                foundRows = mascotas.Select("nombre = '" + comboBox1.Text + "'");//Datos de la mascota seleccionada
                c4.ReservaCita(foundRows[0][0].ToString(), hora,fecha, motivo);

                this.Hide();


                //Actualizamos los datagridview
                if (String.Compare(motivo, "Revisión") == 0)
                {
                    aux.DataSource = c4.obtenerRevisiones();//Ponemos las revisiones libres
                }else if (String.Compare(motivo, "Vacuna") == 0)
                {
                    aux.DataSource = c4.obtenerVacunas();//Ponemos las revisiones libres
                }
                else if(String.Compare(motivo, "Peluquería") == 0)
                {
                    aux.DataSource = c4.obtenerPeluqueria();//Ponemos las revisiones libres
                }
                else if(String.Compare(motivo, "Otros") == 0)
                {
                    aux.DataSource = c4.obtenerOtros();//Ponemos las revisiones libres
                }


                citasFuturas.DataSource = c4.obtenerProximasCitas(foundRows[0][1].ToString());//Actualizamos las revisiones libres
            }         
            else
            {
                MessageBox.Show("Hay que seleccionar una mascota", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

  
    }
}
