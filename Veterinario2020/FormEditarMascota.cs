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
     * Autor:Javier de la Llave
     */
    public partial class FormEditarMascota : Form
    {
        Conexion c = new Conexion();
        String chip = "";
        public DataTable datosMascota = new DataTable();//Aquí guardamos los datos de la mascota
        public FormEditarMascota(String ch)
        {
            chip = ch;
            datosMascota = c.obtenerDatos("SELECT nombre, propietario, especie, raza, color, esterilizado, patologias, medicamentos, f_nacimiento, sexo FROM mascota WHERE n_chip='"+chip+"';");
           
            InitializeComponent();
            this.Text = datosMascota.Rows[0]["nombre"].ToString();
            ponerDatos();
        }

        /*
         * Ponemos los datos de la mascota
         */
        private void ponerDatos()
        {
            textBoxnombre.Text = datosMascota.Rows[0]["nombre"].ToString();
            textBoxchip.Text = chip;
            textBoxespecie.Text = datosMascota.Rows[0]["especie"].ToString();
            textBoxraza.Text = datosMascota.Rows[0]["raza"].ToString();
            textBoxpropietario.Text = datosMascota.Rows[0]["propietario"].ToString();
            textBoxcolor.Text = datosMascota.Rows[0]["color"].ToString();
            textBoxpat.Text = datosMascota.Rows[0]["patologias"].ToString();
            textBoxmed.Text = datosMascota.Rows[0]["medicamentos"].ToString();
            comboBox1.SelectedItem= datosMascota.Rows[0]["sexo"].ToString();
            checkBox1.Checked = Convert.ToBoolean(datosMascota.Rows[0]["esterilizado"]);
            dateTimePicker1.Value = DateTime.Parse(datosMascota.Rows[0]["f_nacimiento"].ToString());
        }

        //Guarda en la base de datos los valores modificados
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String fecha=Convert.ToDateTime(dateTimePicker1.Value.ToString().Substring(0, 10)).ToString("yyyy-MM-dd");
            System.Diagnostics.Debug.WriteLine(fecha);
            c.modificaTabla("UPDATE mascota SET nombre='" + textBoxnombre.Text + "', n_chip='" + textBoxchip.Text +
                    "', especie = '" + textBoxespecie.Text + "', raza='" + textBoxraza.Text + "',propietario='" + textBoxpropietario.Text
                    + "', color='" + textBoxcolor.Text + "', patologias='" + textBoxpat.Text + 
                    "', medicamentos='" + textBoxmed.Text + "', sexo='" + comboBox1.SelectedItem
                    + "', esterilizado=" + checkBox1.Checked + ", f_nacimiento='" + fecha+ "' WHERE n_chip = '" + chip + "';");
        }


    }
}
