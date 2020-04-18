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
    public partial class FormAddPet : Form
    {
        /*
         * Autor: Javier de la Llave
         * 
         * Se introducen los datos de un animal y se añade a la base de datos
         */

        Conexion c = new Conexion();

        String dni = "";

        DataGridView todasMascotas = new DataGridView();
        DataGridView mascotasUsuario = new DataGridView();

        public FormAddPet(String d, DataGridView dg1, DataGridView dg2)
        {
            mascotasUsuario = dg1;
            todasMascotas = dg2;
            dni = d;
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;//Como máximo la fecha de nacimiento podrá se hoy
        }

        //Añade la mascota en la base e datos
        private void button1_Click(object sender, EventArgs e)
        {

            if (!c.comprobarId("SELECT * FROM mascota WHERE n_chip='" + textBoxchip.Text + "';"))//Si ya hay un animal con ese chip sale mensaje de error
            {
                if (textBoxchip.Text.Length > 5 && textBoxnombre.Text.Length > 1 && textBoxespecie.Text.Length > 1 && textBoxraza.Text.Length > 1 && textBoxcolor.Text.Length > 1 && comboBox1.Text.Length > 2)
                {
                    String fecha = Convert.ToDateTime(dateTimePicker1.Value.ToString().Substring(0, 10)).ToString("yyyy-MM-dd");//Para que no de fallo al introducirlo en l base de datos
                    c.modificaTabla("INSERT INTO mascota VALUES('" + textBoxchip.Text + "','" + dni + "','" + textBoxnombre.Text + "','" + textBoxespecie.Text
                        + "','" + textBoxraza.Text + "','" + textBoxcolor.Text + "','" + checkBox1.Checked + "', '" + textBoxpat.Text + "','" + textBoxmed.Text + "','" + fecha + "','" + comboBox1.Text + "')");
                    textBoxchip.Text = "";
                    textBoxnombre.Text = "";
                    textBoxespecie.Text = "";
                    textBoxraza.Text = "";
                    textBoxcolor.Text = "";
                    textBoxpat.Text = "";
                    textBoxmed.Text = "";
                    checkBox1.Checked = false;
                    mascotasUsuario.DataSource = c.obtenerDatos("SELECT n_chip AS Chip, nombre AS Nombre FROM mascota WHERE propietario='" + dni + "'; ");//Actualizamos el datagridview con las mascotas del usuariodel usuario
                    todasMascotas.DataSource = c.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Ponemos todass las mascotas
                    System.Diagnostics.Debug.WriteLine(mascotasUsuario.RowCount);

                    if (mascotasUsuario.RowCount >= 7)//Si ya hay 8 mascotas, impedimos que el usuario introduzca más
                    {
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Datos no válidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chip ya registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
