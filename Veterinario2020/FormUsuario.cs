using MySqlX.XDevAPI.Relational;
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

        public DataTable datosUsuarios = new DataTable();//Aquí guardamos los datos del usario que ha abierto sesió
        public DataTable datosMascotas = new DataTable();//Aquí guardamos los datos de las mascotas del usuario que ha abierto sesión


        /*
         * DataTable dUsuarios: Recibe todos los datos del usuario en forma de datatable
         */
        public FormUsuario(DataTable dUsuarios)
        {
            InitializeComponent();
            datosUsuarios = dUsuarios;//Obtenemos los datos del usuario que ha abierto sesión
            prepararForm();
        }

        /*
         * Coloca los elementos en el form de usuarios
         */
        private void prepararForm()
        {
            this.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();//Ponemos el nombre del usuario de título del form
            ponerDatos();
            ponerMascotas();

            dgHistorialCitas.DataSource = c2.obtenerDatos("SELECT DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, m.nombre AS mascota, c.motivo AS Motivo, c.precio AS Precio FROM mascota m, cita c " +
                    "WHERE m.n_chip = c.chip_mascota AND m.propietario = '" + datosUsuarios.Rows[0]["dni"].ToString() + "' AND fecha<CURDATE()");//Ponemos el historial de citas pasadas

            dgProxCitas.DataSource = c2.obtenerDatos("SELECT n_cita AS Numero, DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, hora AS Hora, m.nombre AS mascota, c.motivo AS Motivo FROM mascota m, cita c " +
                    "WHERE m.n_chip = c.chip_mascota AND m.propietario = '" + datosUsuarios.Rows[0]["dni"].ToString() + "' AND fecha>CURDATE()");//Ponemos las próximas citas

            dgRevisionesLibres.DataSource = c2.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Revisión' AND fecha>CURDATE()");//Ponemos las revisiones libres

            dgVacunasLibres.DataSource = c2.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Vacuna' AND fecha>CURDATE()");//Ponemos las vacunas libres

            dgPeluqueriaLibre.DataSource = c2.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Peluquería' AND fecha>CURDATE()");//Ponemos la peluquería libre

            dgOtrosLibres.DataSource = c2.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Otros' AND fecha>CURDATE()");//Ponemos otos libres
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
            datosMascotas = c2.obtenerDatos("SELECT * FROM mascota WHERE `propietario`='" + datosUsuarios.Rows[0]["dni"].ToString() + "'");//Obtenemos los datos de las mascotas del usuario que está en sesión
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
                else if (i == 7)
                {
                    lMascota8.Text = datosMascotas.Rows[i]["nombre"].ToString();
                }
            }
        }

        //Para la aplicación al pulsar x
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
            if (lMascota1.Text.Length > 0)
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

        //Al pulsar sobre una de las fechas del datagrid view, sale un cuadro para reservarlo
        //Son las citas de revisión
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormElegirCita fec = new FormElegirCita(datosMascotas, dgRevisionesLibres.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dgRevisionesLibres.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Revisión", dgRevisionesLibres, dgProxCitas, 0, null);
                fec.ShowDialog();
            }
            catch
            {

            }

        }

        //Al pulsar sobre una de las fechas del datagrid view, sale un cuadro para reservarlo
        //Son las citas de vacunas
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormElegirCita fec = new FormElegirCita(datosMascotas, dgVacunasLibres.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dgVacunasLibres.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Vacuna", dgVacunasLibres, dgProxCitas, 0, null);
                fec.ShowDialog();
            }
            catch
            {

            }

        }

        //Al pulsar sobre una de las fechas del datagrid view, sale un cuadro para reservarlo
        //Son las citas de peluquería
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                FormElegirCita fec = new FormElegirCita(datosMascotas, dgPeluqueriaLibre.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dgPeluqueriaLibre.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Peluquería", dgPeluqueriaLibre, dgProxCitas, 0, null);
                fec.ShowDialog();
            }
            catch
            {

            }

        }

        //Al pulsar sobre una de las fechas del datagrid view, sale un cuadro para reservarlo
        //Son las citas de Otros
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormElegirCita fec = new FormElegirCita(datosMascotas, dgOtrosLibres.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dgOtrosLibres.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Otros", dgOtrosLibres, dgProxCitas, 0, null);
                fec.ShowDialog();
            }
            catch
            {

            }

        }

        //AL pulsar aparece la opción de anular la cita
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormAnularCita fac = new FormAnularCita(datosUsuarios.Rows[0]["dni"].ToString(),
                                                    dgProxCitas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dgProxCitas.Rows[e.RowIndex].Cells["Hora"].Value.ToString(),
                                                    Int32.Parse(dgProxCitas.Rows[e.RowIndex].Cells["Numero"].Value.ToString()),
                                                    dgRevisionesLibres, dgVacunasLibres, dgPeluqueriaLibre, dgOtrosLibres, dgProxCitas);
                fac.ShowDialog();
                
            }
            catch
            {

            }

        }

        //Al pulsar el botón se cierra la sesión y se abre la ventana de login
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaLogin vl = new VentanaLogin();
            vl.Show();
        }

        //Al pulsar se abre un form para cambiar la contraseña
        private void buttonPass_Click(object sender, EventArgs e)
        {
            FormChangePass fcp = new FormChangePass(datosUsuarios.Rows[0]["dni"].ToString());
            fcp.ShowDialog();
        }

    }
}
