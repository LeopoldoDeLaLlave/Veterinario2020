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
     * Autor Javier de la Llave
     * 
     * Al pulsar el botón se elimina el registro de un usuario
     */
    public partial class FormConfirmarEliminarUsuario : Form
    {

        String dni = "";//Cliente seleccionado
        Conexion c = new Conexion();
        DataGridView dgTodosUsuarios = new DataGridView();//Datagridview con todos los usuarios
        DataGridView dgTodasMascotas = new DataGridView();//Datagridview con todas las mascotas

        /*
         * String d:DNI del usuario
         * 
         * DataGridView dg:Datagridview con todos los usuarios
         * 
         * DataGridView dg2:Datagridview con todas las mascotas
         */
        public FormConfirmarEliminarUsuario(String d, DataGridView dg, DataGridView dg2)
        {
            dgTodosUsuarios = dg;
            dgTodasMascotas = dg2;
            dni = d;
            InitializeComponent();
        }

        //Elimina al usuario
        private void button1_Click(object sender, EventArgs e)
        {
            c.modificaTabla("DELETE FROM usuario WHERE dni = '"+dni+"';");
            MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgTodosUsuarios.DataSource = c.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Ponemos todos los usuarios
            dgTodasMascotas.DataSource = c.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Actualizamos el datagridview de las mascotas
            this.Hide();
        }
    }
}
