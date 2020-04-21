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
     * Se introduce la antigua contraseña una vez y la nueva dos, si los datos son válido se
     * actuallizan en la base de datos con el hashmap
     */
    public partial class FormChangePass : Form
    {
        Conexion c = new Conexion();
        String dni = "";//Dni del cliente

        /*
         * String d: DNI del cliente
         */
        public FormChangePass(String d)
        {
            dni = d;
;
            InitializeComponent();
        }

        //Al pulsar, si los datos son correctos, se cambia la contraseña
        private void button1_Click(object sender, EventArgs e)
        {
            if (c.comprobarLogin(dni, textBoxActual.Text))//Comprobamos que la contraseña actual sea correcta
            {
                if (textBoxNueva.Text.Length>3 && textBoxNueva.Text.Length <=20 && String.Equals(textBoxNueva.Text, textBoxConfirmar.Text))
                {//Comprobamos que la conraseña tenga el número de caracteres adecuado y que sea la misma contraseña las dos veces
                    string myHass = BCrypt.Net.BCrypt.HashPassword(textBoxNueva.Text, BCrypt.Net.BCrypt.GenerateSalt());
                    c.modificaTabla("UPDATE usuario SET contrasena = '"+myHass+"' WHERE dni='"+dni+"'; ");
                    MessageBox.Show("Contraseña cambiada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Contraseña no valida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Ponemos los textbox vacios otra vez
            textBoxActual.Text = "";
            textBoxNueva.Text = "";
            textBoxConfirmar.Text = "";
        }
    }
}
