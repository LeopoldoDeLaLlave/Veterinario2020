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
    public partial class FormDatosMascota : Form
    {
        Conexion c3 = new Conexion();

        public DataTable datosMascota = new DataTable();//Aquí guardamos los datos de la mascota
        string nombrePropietario = "";
        int indice = 0;

        public FormDatosMascota(int im, DataTable dt, String nombre)
        {
            datosMascota = dt;
            indice = im;
            nombrePropietario = nombre;
            InitializeComponent();
            this.Text = datosMascota.Rows[im]["nombre"].ToString();//Ponemos el nombre de la mascota de título del form
            ponerDatosMascota();

            dataGridView1.DataSource = c3.obtenerVacunas(datosMascota.Rows[indice]["n_chip"].ToString());
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
