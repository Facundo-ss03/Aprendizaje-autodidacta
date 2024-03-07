using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Datos_Personales
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }
        private void txtbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = "Nombre: " + txtbApellido.Text + " " + txtbNombre.Text;
            string edad = "Edad: " + txtbEdad.Text;
            string direccion = "Dirección: " + txtbDireccion.Text;
            lvResultado.Items.Add(apellido);
            lvResultado.Items.Add(edad);
            lvResultado.Items.Add(direccion);
        }
    }
}
