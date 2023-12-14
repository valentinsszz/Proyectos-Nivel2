using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLICACIÓN_WINDOWS_2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Ponga todos los datos", "Alerta");
                txtApellido.BackColor = Color.Red;
                txtNombre.BackColor = Color.Red;
                txtEdad.BackColor = Color.Red;
                txtDireccion.BackColor = Color.Red;
            }

            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            }
            string apellido = txtApellido.Text, nombre = txtNombre.Text, direccion = txtDireccion.Text;
            lvwResultado.Items.Add("Apellido y Nombre " + apellido + nombre);
            lvwResultado.Items.Add("Edad: " + txtEdad.Text);
            lvwResultado.Items.Add("Dirección: " + direccion);


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 59 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
