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
                "FROM usuario WHERE administrador=FALSE AND LOWER(CONCAT(nombre, ' ', apellido)) LIKE '%" + textBoxNombre.Text.ToLower() + "%';");
        }
    }
}
