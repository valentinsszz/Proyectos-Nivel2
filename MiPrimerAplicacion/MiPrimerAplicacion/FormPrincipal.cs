using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por usar la App...");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención...");
            //this.BackColor = Color.Blue;
            if (txtApellido.Text == "")
            {
                this.BackColor = Color.Beige;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            }

        }

        private void FormPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton Derecho", "Atención");
            if (click.Button == MouseButtons.Middle)
                    MessageBox.Show("Presiono el Boton del medio");



        }

        private void lblPrimero_MouseMove(object sender, MouseEventArgs e)
        {
            lblPrimero.BackColor = Color.Cyan;
            lblPrimero.Cursor = Cursors.Hand;
        }

        private void lblPrimero_MouseLeave(object sender, EventArgs e)
        {
            lblPrimero.BackColor = System.Drawing.SystemColors.Control;
            lblPrimero.Cursor = Cursors.Arrow;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBNuevo_Leave(object sender, EventArgs e)
        {
            
          MessageBox.Show("Tiene " + txtBNuevo.Text.Length + " Caracteres");
         
        }
    }
}
