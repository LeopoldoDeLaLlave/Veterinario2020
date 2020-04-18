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
    /*
     * Autor: Javier de la Llave
     * 
     * Se introducen los datos del usuario y se guardan en la base de datos
     */
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
            if (!c.comprobarId("SELECT * FROM usuario WHERE dni='"+ textBoxdni.Text.ToUpper() + "';"))//Si el dni ya está registrado sale mensaje de error
            {
                if (textBoxNombre.Text.Length > 1 && textBoxApellido.Text.Length > 1 && textBoxdni.Text.Length > 5 && textBoxDir.Text.Length > 5 && textBoxPass.Text.Length > 3)
                {//Si no cumple las medidas mínimas sale mensaje de error
                    string myHash = BCrypt.Net.BCrypt.HashPassword(textBoxPass.Text, BCrypt.Net.BCrypt.GenerateSalt());


                    c.addUser(textBoxNombre.Text, textBoxApellido.Text, textBoxdni.Text.ToUpper(), textBoxEmail.Text, textBoxDir.Text, textBoxTelefono.Text, myHash);
                    try//Si es un usuario registrándose a sí mismo el datagridview es null y da fallo
                    {
                        tablaUsuarios.DataSource = c.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Actualizamos la tabala con el nuevo usuario
                    }
                    catch
                    {

                    }
                    
                    MessageBox.Show("Usuario añadido ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    //Vacíamos los datos introducidos anteriormente

                    textBoxEmail.Text = "";
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
            else
            {
                MessageBox.Show("Ese DNI ya está registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Vacíamos los datos introducidos anteriormente
                textBoxNombre.Text = "";
                textBoxApellido.Text = "";
                textBoxdni.Text = "";
                textBoxDir.Text = "";
                textBoxTelefono.Text = "";
                textBoxPass.Text = "";
                textBoxEmail.Text = "";
            }
                

            
        }
    }
}
