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
     * En este form se puede reservar una cita elegiendo la mascota
     * 
     */
    
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
                c4.modificaTabla("UPDATE cita SET chip_mascota = '" + foundRows[0][0].ToString() + "' where fecha='" + fecha + "' AND hora='" + hora + "'" +
                    "AND motivo = '" + motivo + "'");

                this.Hide();


                //Actualizamos los datagridview
                if (String.Compare(motivo, "Revisión") == 0)
                {
                    aux.DataSource = c4.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Revisión' AND fecha>CURDATE()");//Ponemos las revisiones libres
                }
                else if (String.Compare(motivo, "Vacuna") == 0)
                {
                    aux.DataSource = c4.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Vacuna'");//Ponemos las revisiones libres
                }
                else if(String.Compare(motivo, "Peluquería") == 0)
                {
                    aux.DataSource = c4.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Peluquería'");//Ponemos las revisiones libres
                }
                else if(String.Compare(motivo, "Otros") == 0)
                {
                    aux.DataSource = c4.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Otros'");//Ponemos las revisiones libres
                }


                citasFuturas.DataSource = c4.obtenerDatos("SELECT n_cita AS Numero, DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, hora AS Hora, m.nombre AS mascota, c.motivo AS Motivo FROM mascota m, cita c " +
                    "WHERE m.n_chip = c.chip_mascota AND m.propietario = '" + foundRows[0][1].ToString() + "' AND fecha>CURDATE()");//Actualizamos las próximas citas
                
            }         
            else
            {
                MessageBox.Show("Hay que seleccionar una mascota", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
