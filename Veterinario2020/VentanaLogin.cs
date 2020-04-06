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
        DataTable usuarioCotrasena = new DataTable();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioCotrasena = c.obtenerPassword(textBoxUsuario.Text);
            String contrasenaReal = "";
            try
            {
                 contrasenaReal = usuarioCotrasena.Rows[0]["contrasena"].ToString();//Guardamos la contraseña de la base de datos
            }
            catch (Exception error)
            {
                MessageBox.Show("El usuario y la contraseña no se corresponden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            String contrasenaDada = textBoxContrasena.Text;//Guardamos la contraseña dada por el usuario

            if (String.Compare(contrasenaDada,contrasenaReal)==0)
            {
                if (Convert.ToBoolean(usuarioCotrasena.Rows[0]["administrador"]))
                {
                    FormAdministrador fa = new FormAdministrador();
                    fa.Show();
                    this.Hide();

                }
                else
                {
                    FormUsuario f1 = new FormUsuario();
                    f1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El usuario y la contraseña no se corresponden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
