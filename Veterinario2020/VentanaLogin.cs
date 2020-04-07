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


            tablaUsuario = c.obtenerTablaUsuario(textBoxUsuario.Text);//Obtenemos la contraseña y si es administrador del usuario introducido.
            String contrasenaReal = "";//Aquí guardaremos la contraseña que hay en la base de datos
            String contrasenaDada = textBoxContrasena.Text;//Guardamos la contraseña dada por el usuario
            Boolean usuarioCorrecto = true;//Si el usuario no existe, se vuelve false
            try
            {
                 contrasenaReal = tablaUsuario.Rows[0]["contrasena"].ToString();//Guardamos la contraseña de la base de datos
            }
            catch 
            {//Si el usuario no existe salta aquí
                usuarioCorrecto = false;
            }
            

            if (String.Compare(contrasenaDada,contrasenaReal)==0 && usuarioCorrecto)//Si contraseña y usuario coinciden y si el usuario existe
            {
                
                if (Convert.ToBoolean(tablaUsuario.Rows[0]["administrador"]))//Si el usuario es administrador abrimos el form de administrador
                {
                    FormAdministrador fa = new FormAdministrador();
                    fa.Show();
                    this.Hide();

                }
                else//Si el usuario es cliente abrimos el form de usuario
                {
                    
                    FormUsuario f1 = new FormUsuario(tablaUsuario);
                    f1.Show();
                    this.Hide();
                }
                
                
            }
            else
            {//Si los datos  son incorrectos damos un aviso y vacíamos el textbox de contraseña
                MessageBox.Show("El usuario y la contraseña no se corresponden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContrasena.Text = "";
            }

        }


    }
}
