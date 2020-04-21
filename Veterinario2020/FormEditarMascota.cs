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
     * 
     * Aparece la información de la mascota y esta es modificable
     */
    public partial class FormEditarMascota : Form
    {
        Conexion c = new Conexion();
        String chip = "";//Chip del animal en el que se ha pulsado
        public DataTable datosMascota = new DataTable();//Aquí guardamos los datos de la mascota
        DataGridView dgMascotasUsuario = new DataGridView();//El datagrid view que se muestra en los datos de usuario con sus mascotas, para modificarlo
        DataGridView dglistaMascotas = new DataGridView();//El datagrid view que muestra todas las mascotas

        /*
         * String ch:Chip del animal en el que se ha pulsado
         * 
         * DataGridView dg:El datagrid view que se muestra en los datos de usuario con sus mascotas, para modificarlo
         *  
         * DataGridView dg2: El datagrid view que muestra todas las mascotas
         */
        public FormEditarMascota(String ch, DataGridView dg, DataGridView dg2)
        {
            chip = ch;
            datosMascota = c.obtenerDatos("SELECT nombre, propietario, especie, raza, color, esterilizado, patologias, medicamentos, f_nacimiento, sexo FROM mascota WHERE n_chip='"+chip+"';");
            dglistaMascotas = dg2;
            dgMascotasUsuario = dg;

            InitializeComponent();
            this.Text = datosMascota.Rows[0]["nombre"].ToString();
            ponerDatos();
            dateTimePicker1.MaxDate = DateTime.Now;//Como máximo la fecha de nacimiento podrá ser hoy
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

            if (!c.comprobarId("SELECT * FROM mascota WHERE n_chip='" + textBoxchip.Text + "';") || String.Equals(textBoxchip.Text, chip))//Si ya hay un animal con ese chip sale mensaje de error
            {
                if (textBoxnombre.Text.Length > 1 && textBoxchip.Text.Length > 4 && textBoxespecie.Text.Length > 3 && textBoxraza.Text.Length > 2 && textBoxpropietario.Text.Length > 5 &&
                    textBoxcolor.Text.Length > 2)//Los datos tienen que tener unas medidas mínimas
                {
                    String fecha = Convert.ToDateTime(dateTimePicker1.Value.ToString().Substring(0, 10)).ToString("yyyy-MM-dd");//Para que no de fallo al introducirlo en la base de datos
                    c.modificaTabla("UPDATE mascota SET nombre='" + textBoxnombre.Text + "', n_chip='" + textBoxchip.Text +
                            "', especie = '" + textBoxespecie.Text + "', raza='" + textBoxraza.Text + "',propietario='" + textBoxpropietario.Text
                            + "', color='" + textBoxcolor.Text + "', patologias='" + textBoxpat.Text +
                            "', medicamentos='" + textBoxmed.Text + "', sexo='" + comboBox1.SelectedItem
                            + "', esterilizado=" + checkBox1.Checked + ", f_nacimiento='" + fecha + "' WHERE n_chip = '" + chip + "';");
                    try
                    {//El admin puede llegar aquí desde la modificación de usuario o desde la lista de mascotas, en este ultimo caso este datagridview será null
                        dgMascotasUsuario.DataSource = c.obtenerDatos("SELECT n_chip AS Chip, nombre AS Nombre FROM mascota WHERE propietario='" + datosMascota.Rows[0]["propietario"].ToString() + "'; ");//Actualizamos el datagridview con las mascotas del usuario
                    }
                    catch (Exception)
                    {

                    }

                    dglistaMascotas.DataSource = c.obtenerDatos("SELECT m.n_chip AS Chip, m.nombre AS Nombre, m.especie AS Especie, m.raza AS Raza, CONCAT(s.nombre, ' ', s.apellido) AS Propietario FROM `mascota` m, usuario s WHERE m.propietario = s.dni;");//Ponemos todass las mascotas
                    MessageBox.Show("Cambios guardados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos no válidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chip ya registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        //Abre un form para confirmar al eliminación de la mascota
        private void buttonborrarMascota_Click(object sender, EventArgs e)
        {
            FormConfirmarEliminarMascota fcem = new FormConfirmarEliminarMascota(chip, dgMascotasUsuario, dglistaMascotas, datosMascota.Rows[0]["propietario"].ToString());
            fcem.ShowDialog();
            this.Hide();
        }

    }
}
