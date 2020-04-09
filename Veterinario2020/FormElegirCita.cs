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
    public partial class FormElegirCita : Form
    {

        Conexion c4 = new Conexion();
        DataTable mascotas = new DataTable();
        string fecha = "";
        string hora = "";

        public FormElegirCita(DataTable dm, string f, string h)
        {
            mascotas = dm;
            fecha = f;
            hora = h;
            
            InitializeComponent();
            fillCombo();

            labelDatos.Text =fecha + ", a las " + hora;
        }

        //Pone en un combobox los nombres de las mascotas
        void fillCombo()
        {
            int numColumnas = mascotas.Rows.Count;//Obtenemos el número de mascotas que tiene
            for (int i = 0; i < numColumnas; i++)
            {
                comboBox1.Items.Add(mascotas.Rows[i]["nombre"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
