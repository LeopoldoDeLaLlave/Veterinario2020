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
     * Form con los datos de la mascota
     */
    public partial class FormDatosMascota : Form
    {
        Conexion c3 = new Conexion();

        public DataTable datosMascota = new DataTable();//Aquí guardamos los datos de la mascota
        string nombrePropietario = "";
        int indice = 0;//Posición que ocupa la mascota en la lista de mascotas

        /*
         * int im: Posición que ocupa la mascota en la lista de mascotas
         * 
         * DataTable dt: Aquí guardamos los datos de la mascota
         * 
         * String nombre: Nombre del propietario de la mascota
         */
        public FormDatosMascota(int im, DataTable dt, String nombre)
        {
            datosMascota = dt;
            indice = im;
            nombrePropietario = nombre;
            InitializeComponent();
            this.Text = datosMascota.Rows[im]["nombre"].ToString();//Ponemos el nombre de la mascota de título del form
            ponerDatosMascota();

            dataGridView1.DataSource = c3.obtenerDatos("SELECT DATE_FORMAT(fecha, '%Y-%m-%d') AS Fecha, tipo_vacuna AS Vacuna  FROM cita WHERE `chip_mascota`='" +
                datosMascota.Rows[indice]["n_chip"].ToString() +
                    "' AND motivo = 'Vacuna' AND tipo_vacuna IS NOT NULL");//Ponemos las vacunas en un datagridview
        }


        //Pone los datos de las mascotas en la ficha
        private void ponerDatosMascota()
        {
            lNombre.Text = datosMascota.Rows[indice]["nombre"].ToString();
            labelChip.Text = datosMascota.Rows[indice]["n_chip"].ToString();
            labelEspecie.Text = datosMascota.Rows[indice]["especie"].ToString();
            labelRaza.Text = datosMascota.Rows[indice]["raza"].ToString();
            labelColor.Text = datosMascota.Rows[indice]["color"].ToString();
            labelEspecie.Text = datosMascota.Rows[indice]["especie"].ToString();
            labelNacimiento.Text = datosMascota.Rows[indice]["f_nacimiento"].ToString();
            labelProp.Text = nombrePropietario;
            labelMed.Text = datosMascota.Rows[indice]["medicamentos"].ToString();
            labelSexo.Text = datosMascota.Rows[indice]["sexo"].ToString();

            if (Convert.ToBoolean(datosMascota.Rows[indice]["esterilizado"]))
            {
                labelEsterilizado.Text = "Sí";
            }
            else
            {
                labelEsterilizado.Text = "No";
            }
            
            labelPatologia.Text = datosMascota.Rows[indice]["patologias"].ToString();
        }


    }
}
