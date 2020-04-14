using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario2020
{
    public partial class FormAddUser : Form
    {
        Conexion c = new Conexion();
        DataGridView tablaUsuarios = new DataGridView();
        public FormAddUser(DataGridView dg)
        {
            tablaUsuarios = dg;
            InitializeComponent();
        }

        //Inserta el usuario creado en la base de dados
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Length>1 && textBoxApellido.Text.Length>1 && textBoxdni.Text.Length>5 && textBoxDir.Text.Length>5 && textBoxPass.Text.Length>3)
            {
                string myHash = BCrypt.Net.BCrypt.HashPassword(textBoxPass.Text, BCrypt.Net.BCrypt.GenerateSalt());

                
                c.addUser(textBoxNombre.Text, textBoxApellido.Text, textBoxdni.Text.ToUpper(),textBoxEmail.Text,textBoxDir.Text, textBoxTelefono.Text, myHash);
                tablaUsuarios.DataSource = c.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Actualizamos la tabala con el nuevo usuario
                MessageBox.Show("Usuario añadido ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Vacíamos los datos introducidos anteriormente

                textBoxNombre.Text = "";
                textBoxApellido.Text = "";
                textBoxdni.Text = "";
                textBoxDir.Text = "";
                textBoxTelefono.Text = "";
                textBoxPass.Text = "";

            }
            else
            {
                MessageBox.Show("Datos no válidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
