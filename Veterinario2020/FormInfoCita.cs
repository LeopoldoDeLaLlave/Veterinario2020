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
     * Se pueden añadir comentarios, precio y tipo de vacuna a las citas pasadas
     */
    public partial class FormInfoCita : Form
    {
        Conexion c = new Conexion();
        DataGridView dgCitas = new DataGridView();//Información de las citas pasadas del usuario
        int index = 0;//Indica que fila ha sido pulsada
        string dni = "";//Guardamos el dni del cliente que ha tenido la cita

        public FormInfoCita(DataGridView dg, int i, string d)
        {
            
            dgCitas = dg;
            index = i;
            dni = d;

            InitializeComponent();

            textBoxComents.Text = dgCitas.Rows[index].Cells["Comentarios"].Value.ToString();//Ponemos los comentarios
            textBoxPrecio.Text = dgCitas.Rows[index].Cells["Precio"].Value.ToString();//Ponemos el precio
            textBoxVacuna.Text = dgCitas.Rows[index].Cells["Vacuna"].Value.ToString();//POnemos la vacuna

            if (!String.Equals("Vacuna", dgCitas.Rows[index].Cells["Motivo"].Value.ToString()))//Si el motivo no es vacuna no se puede poner tipo de vacuna
            {
                textBoxVacuna.Enabled = false;
            }
        }

        //Actualiza la base de datos con los nuevos datos
        private void button1_Click(object sender, EventArgs e)
        {
            c.modificaTabla("UPDATE cita SET comentarios ='"+ textBoxComents.Text + "', precio = '"+ textBoxPrecio.Text + "', tipo_vacuna = '"+ textBoxVacuna.Text + "'" +
                "WHERE n_cita='"+ dgCitas.Rows[index].Cells["Numero"].Value.ToString()+"';");

            MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgCitas.DataSource = c.obtenerDatos("SELECT m.nombre AS mascota, c.n_cita AS Numero, DATE_FORMAT(c.fecha, '%Y-%m-%d') AS Fecha, hora AS Hora, c.motivo AS Motivo,c.tipo_vacuna AS Vacuna, c.comentarios AS Comentarios," +
                "c.precio AS Precio FROM mascota m, cita c WHERE m.n_chip = c.chip_mascota AND m.propietario = '" + dni + "' AND fecha<CURDATE()");//Actualizamos las citas que ha tenido un usuario
        }
    }
}
