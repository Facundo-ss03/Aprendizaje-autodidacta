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

        private string apellidoPersona;
        private string nombrePersona;
        private string edadPersona;
        private string direccionPersona;

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

        private Persona DatosPersona()
        {
            apellidoPersona = txtbApellido.Text;
            nombrePersona = txtbNombre.Text;
            edadPersona = txtbEdad.Text;
            direccionPersona = txtbDireccion.Text;

            Persona persona = new Persona(apellidoPersona, nombrePersona, edadPersona, direccionPersona);

            return persona;
        }
        
        private void MostrarResultado()
        {
            Persona p = DatosPersona();

            txtbResultado.Text += "Nombre y apellido: \n" + p.Apellido + " " + p.Nombre + " ";
            txtbResultado.Text += "Edad: " + p.Edad + " ";
            txtbResultado.Text += "Dirección: " + p.Direccion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MostrarResultado();
        }
    }
}
