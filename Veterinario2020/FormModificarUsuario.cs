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
     * Autor: JAvier de la Llave
     * 
     * Form con los datos del usuario seleccionado donde estos se pueden editar o eliminar al usuario
     */
    public partial class FormModificarUsuario : Form
    {
        Conexion c = new Conexion();

        public DataTable datosUsuario = new DataTable();//Aquí guardamos los datos del cliente

        String dni = "";

        DataGridView aux = new DataGridView();//Para actualizar los datos del datagridview de clientes
        public FormModificarUsuario(String d, DataGridView dg)
        {

            dni = d;
            datosUsuario = c.obtenerDatos("SELECT nombre, apellido, telefono, email, direccion FROM usuario WHERE dni = '"+dni+"';");
            aux = dg;
            
            InitializeComponent();
            ponerDatos();
            this.Text = datosUsuario.Rows[0]["nombre"].ToString() + " " + datosUsuario.Rows[0]["apellido"].ToString();//Ponemos el nombre del usuario de título del form
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
            if (textBoxNombre.Text.Length>=2 && textBoxApellido.Text.Length>=2 && textBoxTelefono.Text.Length>6 && textBoxDir.Text.Length>6
                && textBoxEmail.Text.Length>5)
            {
                c.modificaTabla("UPDATE usuario SET nombre='"+ textBoxNombre.Text +"', apellido='"+textBoxApellido.Text+
                    "', telefono = '"+textBoxTelefono.Text+"', dni='"+textBoxdni.Text+"',direccion='"+textBoxDir.Text
                    +"', email='"+textBoxEmail.Text+"' WHERE dni = '"+dni+"';");

                MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                aux.DataSource = c.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Actualizamos el datagridview con usuarios

            }
            else
            {
                MessageBox.Show("Datos no válidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
