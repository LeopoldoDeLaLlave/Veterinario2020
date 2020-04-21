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
     * Autor: Javier de la Llave
     * 
     * Si le das a aceptar se borra el registro de la mascota
     */
    public partial class FormConfirmarEliminarMascota : Form
    {

        String dni = "";//Dni del propietario de la mascota
        String chip = "";//Chip de la mascota
        Conexion c = new Conexion();
        DataGridView dgMascotasClientes = new DataGridView();//Mascotas del cliente
        DataGridView dgTodasMascotas = new DataGridView();//Todas las mascotas

        /*
         * String c:Chip de la mascota
         * 
         * DataGridView dg:Mascotas del cliente
         * 
         * DataGridView dg2:Todas las mascotas
         * 
         * String d:Dni del propietario de la mascota
         */
        public FormConfirmarEliminarMascota(String c, DataGridView dg, DataGridView dg2, String d)
        {
            dni = d;
            chip = c;
            dgMascotasClientes = dg;
            dgTodasMascotas = dg2;
            InitializeComponent();
        }

        //Elimina la mascota seleccionada
        private void button1_Click(object sender, EventArgs e)
        {
            c.modificaTabla("DELETE FROM mascota WHERE n_chip = '" + chip + "';");
            MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            try
            {//El admin puede llegar aquí desde la modificación de usuario o desde la lista de mascotas, en este ultimo caso este datagridview sera null

                dgMascotasClientes.DataSource = c.obtenerDatos("SELECT n_chip AS Chip, nombre AS Nombre FROM mascota WHERE propietario='" + dni + "'; ");//Ponemos todas las mascotas que tiene ese usuario
            }
            catch (Exception)
            {

            }
            
            dgTodasMascotas.DataSource = c.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Actulizamos todas las mascotas
            this.Hide();
        }
    }
}
