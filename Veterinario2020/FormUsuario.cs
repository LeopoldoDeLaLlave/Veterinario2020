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
    public partial class FormUsuario : Form
    {


        VentanaLogin vl = new VentanaLogin();
        public DataTable datosUsuarios = new DataTable();


        public FormUsuario(DataTable dUsuarios)
        {
            InitializeComponent();
            datosUsuarios = dUsuarios;
            this.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();
            ponerDatos();
        }

        private void ponerDatos()
        {
            labelNombre.Text = datosUsuarios.Rows[0]["nombre"].ToString() + " " + datosUsuarios.Rows[0]["apellido"].ToString();
            labelTelefono.Text = datosUsuarios.Rows[0]["telefono"].ToString();
            labelDir.Text = datosUsuarios.Rows[0]["direccion"].ToString();
            labelDni.Text = datosUsuarios.Rows[0]["dni"].ToString();
            labelEmail.Text = datosUsuarios.Rows[0]["email"].ToString();
            labelAlta.Text = datosUsuarios.Rows[0]["fecha_alta"].ToString();
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }

    }
}
