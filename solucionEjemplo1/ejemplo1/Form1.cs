using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string tipo;
            if (rbNormal.Checked)
            {
                tipo = "Normal";
            }
            else
            {
                tipo = "Trolo";
            }
            string edadFavorita = nupEdad.Value.ToString();

            MessageBox.Show(nombre + " Edad " + fecha + " Tipo de persona " + tipo + " Edad que le gusta " + edadFavorita);
        }
    }
}
