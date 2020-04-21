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
     * El administrador puede buscar usuarios y mascotas y abrir fichas para editarlos, también puede generar nuevas citas.
     * 
     */
    public partial class FormAdministrador : Form
    {

        Conexion c6 = new Conexion();

        public DataTable datosUsuarios = new DataTable();//Aquí guardamos los datos del admin

        /*
         * DataTable dUsuarios: datos del admin
         */
        public FormAdministrador(DataTable dUsuarios)
        {
            InitializeComponent();
            datosUsuarios = dUsuarios;
            this.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();//Ponemos el nombre del usuario de título del form
            dgTodosUsuarios.DataSource = c6.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Ponemos todos los usuarios
            dgTodasMascotas.DataSource = c6.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Ponemos todos las mascotas

            dateTimePickerCitas.MaxDate = DateTime.Now.AddMonths(3); //La fecha máxima de creación de cita es el tres meses después de la creación
            dateTimePickerCitas.MinDate = DateTime.Now.AddDays(1); //La fecha mínima de creación de cita es el día siguiente a la fecha de creación
            
        }

        //Para cerrar la apicación al pulsar la x
        private void formAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Al pulsar buscar, aparece el dni que coincida con el escrito o los que contengan los carácteres escritos
        private void buttonbdni_Click(object sender, EventArgs e)
        {
            dgTodosUsuarios.DataSource = c6.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono " +
                "FROM usuario WHERE administrador=FALSE AND dni LIKE '%"+textBoxdni.Text.ToUpper()+"%';");
        }

        //Al pulsar buscar, aparecen los nombres que coincidan
        private void buttonNombre_Click(object sender, EventArgs e)
        {
            dgTodosUsuarios.DataSource = c6.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono " +
                                                       "FROM usuario WHERE administrador=FALSE AND LOWER(CONCAT(nombre, ' ', apellido)) " +
                                                       "LIKE '%" + textBoxNombre.Text.ToLower() + "%';");
        }

        //Al pulsar aparecen los datos que coincidan con el chip introducido
        private void buttonChip_Click(object sender, EventArgs e)
        {
            dgTodasMascotas.DataSource = c6.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, " +
                                                       "CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s " +
                                                       "WHERE m.propietario = s.dni AND m.n_chip LIKE '%"+textBoxchip.Text+"%';");
        }

        //Al pulsar aparecen los datos que coincidan con el nombre de la mascota introducido
        private void buttonNMaascota_Click(object sender, EventArgs e)
        {
            dgTodasMascotas.DataSource = c6.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, " +
                                                       "CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s " +
                                                       "WHERE m.propietario = s.dni AND LOWER(m.nombre) LIKE '%" + textBoxnmascota.Text.ToLower() + "%';");
        }

        //Se abren los datos del usuario pulsado
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                FormModificarUsuario fmu = new FormModificarUsuario(dgTodosUsuarios.Rows[e.RowIndex].Cells["DNI"].Value.ToString(), dgTodosUsuarios, dgTodasMascotas);
                fmu.ShowDialog();
            }
            catch
            {

            }
            
        }

        //Se abren los datos de la mascota
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormEditarMascota fem = new FormEditarMascota(dgTodasMascotas.Rows[e.RowIndex].Cells["Chip"].Value.ToString(), null, dgTodasMascotas);
                fem.ShowDialog();
            }
            catch
            {

            }
            
        }

        //Abre un form para añadir un usuario
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser fas = new FormAddUser(dgTodosUsuarios);
            fas.ShowDialog();
        }

        //Al pulsarlo, se crea una cita con los datos dados
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePickerCitas.Value != null && comboBoxHoras.Text != "" && comboBoxMotivo.Text != "")//Si están rellenos los valores
            {
                String fecha = Convert.ToDateTime(dateTimePickerCitas.Value.ToString().Substring(0, 10)).ToString("yyyy-MM-dd");//Para que no de fallo al introducirlo en l base de datos
                if (!c6.comprobarId("Select * FROM cita WHERE fecha ='"+fecha+"' AND motivo ='"+comboBoxMotivo.Text+"' AND hora ='"+comboBoxHoras.Text+"';"))//Si esa cita no existe ya
                {
                    c6.modificaTabla("INSERT INTO cita VALUES (NULL,'"+fecha+"', NULL,'"+comboBoxMotivo.Text+"', NULL, NULL, NULL,'"+comboBoxHoras.Text+"');");
                    MessageBox.Show("Cita creada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cita ya existente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar completados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
