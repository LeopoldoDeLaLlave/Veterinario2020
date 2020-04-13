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
     */
    public partial class FormConfirmarEliminar : Form
    {

        String dni = "";
        Conexion c = new Conexion();
        DataGridView aux = new DataGridView();
        DataGridView dgMascotas = new DataGridView();
        public FormConfirmarEliminar(String d, DataGridView dg, DataGridView dg2)
        {
            aux = dg;
            dgMascotas = dg2;
            dni = d;
            InitializeComponent();
        }

        //Cancela eliminar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Elimina al usuario
        private void button1_Click(object sender, EventArgs e)
        {
            c.modificaTabla("DELETE FROM usuario WHERE DNI = '"+dni+"';");
            MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            aux.DataSource = c.obtenerDatos("SELECT dni AS DNI, nombre AS Nombre, apellido AS Apellido, email AS Email, telefono AS Telefono FROM usuario WHERE administrador=FALSE; ");//Ponemos todos los usuarios
            dgMascotas.DataSource = c.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Actualizamos el datagridview de las mascotas
            this.Hide();
        }
    }
}
