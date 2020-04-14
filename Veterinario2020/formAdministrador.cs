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
     * 
     * 
     */
    public partial class FormAdministrador : Form
    {

        Conexion c6 = new Conexion();

        public DataTable datosUsuarios = new DataTable();//Aquí guardamos los datos del admin
        public FormAdministrador(DataTable dUsuarios)
        {
            InitializeComponent();
            datosUsuarios = dUsuarios;
            this.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();//Ponemos el nombre del usuario de título del form
            dataGridView1.DataSource = c6.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Ponemos todos los usuarios
            dataGridView2.DataSource = c6.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Ponemos todos las mascotas
        }

        private void formAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Al pulsar buscar, aparece el dni que coincida con el escrito o los que contengan los carácteres escritos
        private void buttonbdni_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c6.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono " +
                "FROM usuario WHERE administrador=FALSE AND dni LIKE '%"+textBoxdni.Text.ToUpper()+"%';");
        }

        //Al pulsar buscar, aparecen los nombres que coincidad
        private void buttonNombre_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c6.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono " +
                                                       "FROM usuario WHERE administrador=FALSE AND LOWER(CONCAT(nombre, ' ', apellido)) " +
                                                       "LIKE '%" + textBoxNombre.Text.ToLower() + "%';");
        }

        //Al pulsar aparecen los datos que coincidan con el chip introducido
        private void buttonChip_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c6.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, " +
                                                       "CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s " +
                                                       "WHERE m.propietario = s.dni AND m.n_chip LIKE '%"+textBoxchip.Text+"%';");
        }

        //Al pulsar aparecen los datos que coincidan con el nombre de la mascota introducido
        private void buttonNMaascota_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c6.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, " +
                                                       "CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s " +
                                                       "WHERE m.propietario = s.dni AND LOWER(m.nombre) LIKE '%" + textBoxnmascota.Text.ToLower() + "%';");
        }

        //Se abren los datos del usuario pulsado
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModificarUsuario fmu = new FormModificarUsuario(dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value.ToString(), dataGridView1, dataGridView2);
            
            fmu.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditarMascota fem = new FormEditarMascota(dataGridView2.Rows[e.RowIndex].Cells["Chip"].Value.ToString(), null, dataGridView2);

            fem.ShowDialog();
        }
    }
}
