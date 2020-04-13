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
     * Autor: Javier de la LLave
     * 
     * El usuario introduce su dni y contraseña, si son correctos, se abre un form u otro en función de si es usuario o administrador
     */
    public partial class VentanaLogin : Form
    {

        Conexion c = new Conexion();
        public DataTable tablaUsuario = new DataTable();
        
        public VentanaLogin()
        {
            InitializeComponent();
        }

        //Se encarga de recoger el nombre y la contraseña introducida por el usuario y comprobar si coinciden
        //En tal caso cierra VentanaLogin y abre FormUsuario o FormAdministrador en función de quien haya introducido los datos.
        //Si los datos introducidos son incorrectos salta un aviso
        public void BotonLogin_Click(object sender, EventArgs e)
        {


            

            if (c.comprobarLogin(textBoxUsuario.Text, textBoxContrasena.Text))
            {
                tablaUsuario = c.obtenerDatos("SELECT * FROM usuario WHERE dni ='" + textBoxUsuario.Text + "'");//Obtenemos los datos del usuario
                if (Convert.ToBoolean(tablaUsuario.Rows[0]["administrador"]))//Si el usuario es administrador abrimos el form de administrador
                {
                    FormAdministrador fa = new FormAdministrador(tablaUsuario);
                    fa.Show();
                    this.Hide();

                }
                else//Si el usuario es cliente abrimos el form de usuario
                {

                    FormUsuario f1 = new FormUsuario(tablaUsuario);
                    f1.Show();
                    this.Hide();
                }

                //Vacíamos los textbox por sí se cierra sesión y se abre otra
                textBoxContrasena.Text = "";
                textBoxUsuario.Text = "";
            }
            else
            {//Si los datos  son incorrectos damos un aviso y vacíamos el textbox de contraseña
                MessageBox.Show("El usuario y la contraseña no se corresponden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContrasena.Text = "";

            }

        }

        //Para que se para la aplicación al pulsar la x
        private void VentanaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
