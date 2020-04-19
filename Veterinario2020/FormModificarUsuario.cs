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
     * Form con los datos del usuario seleccionado donde estos se pueden editar o eliminar al usuario
     */
    public partial class FormModificarUsuario : Form
    {
        Conexion c = new Conexion();

        public DataTable datosUsuario = new DataTable();//Aquí guardamos los datos del cliente

        String dni = "";

        DataGridView aux = new DataGridView();//Para actualizar los datos del datagridview de clientes
        DataGridView dgmascotas = new DataGridView();//Para actualizar los datos del datagridview de las mascotas 
        public FormModificarUsuario(String d, DataGridView dg, DataGridView dg2)
        {

            dni = d;
            datosUsuario = c.obtenerDatos("SELECT nombre, apellido, telefono, email, direccion FROM usuario WHERE dni = '"+dni+"';");
            aux = dg;
            dgmascotas = dg2;          
            InitializeComponent();
            dataGridView1.DataSource = c.obtenerDatos("SELECT n_chip AS Chip, nombre AS Nombre FROM mascota WHERE propietario='" + dni+"'; ");//Ponemos todas las mascotas que tiene ese usuario
            ponerDatos();
            this.Text = datosUsuario.Rows[0]["nombre"].ToString() + " " + datosUsuario.Rows[0]["apellido"].ToString();//Ponemos el nombre del usuario de título del form

            dataGridView2.DataSource = c.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Revisión' AND fecha>CURDATE()");//Ponemos las revisiones libres

            dataGridView3.DataSource = c.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Vacuna' AND fecha>CURDATE()");//Ponemos las revisiones libres

            dataGridView4.DataSource = c.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Peluquería' AND fecha>CURDATE()");//Ponemos las revisiones libres

            dataGridView5.DataSource = c.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, hora AS Hora FROM cita  WHERE chip_mascota IS NULL AND motivo = 'Otros' AND fecha>CURDATE()");//Ponemos las revisiones libres

            dataGridView6.DataSource = c.obtenerDatos("SELECT n_cita AS Numero, DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, hora AS Hora, m.nombre AS mascota, c.motivo AS Motivo FROM mascota m, cita c " +
                    "WHERE m.n_chip = c.chip_mascota AND m.propietario = '" + dni + "' AND fecha>CURDATE()");//Ponemos las próximas citas

            dataGridView7.DataSource = c.obtenerDatos("SELECT m.nombre AS mascota, c.n_cita AS Numero, DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, hora AS Hora, c.motivo AS Motivo, c.tipo_vacuna AS Vacuna,c.comentarios AS Comentarios," +
                "c.precio AS Precio FROM mascota m, cita c WHERE m.n_chip = c.chip_mascota AND m.propietario = '" + dni + "' AND fecha<CURDATE()");//Ponemos las citas que ha tenido un usuario
        }


        //Pones los datos en el form de modificar usuario
        private void ponerDatos()
        {
            textBoxNombre.Text = datosUsuario.Rows[0]["nombre"].ToString();
            textBoxApellido.Text = datosUsuario.Rows[0]["apellido"].ToString();
            textBoxTelefono.Text = datosUsuario.Rows[0]["telefono"].ToString();
            textBoxdni.Text = dni;
            textBoxDir.Text = datosUsuario.Rows[0]["direccion"].ToString();
            textBoxEmail.Text = datosUsuario.Rows[0]["email"].ToString();
        }

        private void buttonCambios_Click(object sender, EventArgs e)
        {
            if (!c.comprobarId("SELECT * FROM usuario WHERE dni='" + textBoxdni.Text.ToUpper() + "';") || String.Equals(textBoxdni.Text, dni))//Si el dni ya está registrado sale mensaje de error
            {
                if (textBoxNombre.Text.Length >= 2 && textBoxApellido.Text.Length >= 2 && textBoxTelefono.Text.Length > 6 && textBoxDir.Text.Length > 6
                && textBoxEmail.Text.Length > 5)
                {
                    c.modificaTabla("UPDATE usuario SET nombre='" + textBoxNombre.Text + "', apellido='" + textBoxApellido.Text +
                        "', telefono = '" + textBoxTelefono.Text + "', dni='" + textBoxdni.Text + "',direccion='" + textBoxDir.Text
                        + "', email='" + textBoxEmail.Text + "' WHERE dni = '" + dni + "';");

                    MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    aux.DataSource = c.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Actualizamos el datagridview con usuarios
                    dgmascotas.DataSource = c.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Actualizamos el datagridview de las mascotas
                }
                else
                {
                    MessageBox.Show("Datos no válidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DNI ya registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Nos lleva a una ventana para confirmar el borrar al usuario
        private void buttonBorrarUsuario_Click(object sender, EventArgs e)
        {
            FormConfirmarEliminar fce = new FormConfirmarEliminar(dni, aux, dgmascotas);
            fce.ShowDialog();
            this.Hide();
        }

        //Abre una ficha con los datos del animal que se pueden modificar y también se puede borrar al animal
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormEditarMascota fem = new FormEditarMascota(dataGridView1.Rows[e.RowIndex].Cells["Chip"].Value.ToString(), dataGridView1, dgmascotas);
                fem.ShowDialog();
            }
            catch
            {

            }
        }

        //Al pulsar se abre el form para añadir mascota
        private void buttonaddmascota_Click(object sender, EventArgs e)
        {


            if (dataGridView1.RowCount<=7)
            {
                FormAddPet fap = new FormAddPet(dni, dataGridView1, dgmascotas);
                fap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se puede tener hasta un máximo de 8 mascotas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Al pulsar sobre una de las fechas del datagrid view, sale un cuadro para reservarlo
        //Son las citas de revisión
       private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormElegirCita fec = new FormElegirCita((DataTable)(dataGridView1.DataSource), dataGridView2.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dataGridView2.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Revisión", dataGridView2, dataGridView6, 1, dni);
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
                FormElegirCita fec = new FormElegirCita((DataTable)(dataGridView1.DataSource), dataGridView3.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dataGridView3.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Vacuna", dataGridView3, dataGridView6, 1, dni);
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
                FormElegirCita fec = new FormElegirCita((DataTable)(dataGridView1.DataSource), dataGridView4.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dataGridView4.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Peluquería", dataGridView4, dataGridView6, 1, dni);
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
                FormElegirCita fec = new FormElegirCita((DataTable)(dataGridView1.DataSource), dataGridView5.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dataGridView5.Rows[e.RowIndex].Cells["Hora"].Value.ToString(), "Otros", dataGridView5, dataGridView6, 1, dni);
                fec.ShowDialog();
            }
            catch
            {

            }

        }

        //Al pulsar sobre una cita se abre la opción de borrarla
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormAnularCita fac = new FormAnularCita(dni,
                                                    dataGridView6.Rows[e.RowIndex].Cells["Fecha"].Value.ToString(),
                                                    dataGridView6.Rows[e.RowIndex].Cells["Hora"].Value.ToString(),
                                                    Int32.Parse(dataGridView6.Rows[e.RowIndex].Cells["Numero"].Value.ToString()),
                                                    dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6);
                fac.ShowDialog();

            }
            catch
            {

            }

        }

        //Al pulsar sobre una celda abre un form con información modificable de esa cita
        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//or si da el el cabecero de la tabla
            {
                FormInfoCita fic = new FormInfoCita(dataGridView7, e.RowIndex, dni);
                fic.ShowDialog();
            }
            catch
            {

            }
            
        }

    }
}
