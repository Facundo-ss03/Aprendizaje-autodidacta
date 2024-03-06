using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3__Control_Textbox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCaja1.Text == "") txtCaja1.BackColor = Color.LightBlue;
            else txtCaja1.BackColor = Color.Orange;
        }

        private void txtbSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtbCaja3_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("La caja de texto tiene " + txtbCaja3.Text.Length + " caracteres.");
        }

        private void txtbCaja3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13) e.Handled = true;
        }
        private void btnCambiarFondo2_Click(object sender, EventArgs e)
        {
            if (txtbCaja3.Text == "") txtbCaja3.BackColor = Color.LightBlue;
            else txtbCaja3.BackColor = Color.Orange;
        }

    }
}
