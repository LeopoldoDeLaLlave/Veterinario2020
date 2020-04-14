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

        public FormAddPet(String d)
        {
            dni = d;
            InitializeComponent();
        }

        //Añade la mascota en la base e datos
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxchip.Text.Length>5 && textBoxnombre.Text.Length>1 && textBoxespecie.Text.Length>1 && textBoxraza.Text.Length>1 && textBoxcolor.Text.Length>1)
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
            }
            else
            {
                MessageBox.Show("Datos no válidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
