using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2__Button_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            MessageBox.Show("Ahora el color de fondo es azul.");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left) 
            {
                MessageBox.Show("Se presionó el botón izquierdo del mouse.");
            }
            else if (click.Button == MouseButtons.Right) 
            {
                MessageBox.Show("Se presionó el botón derecho del mouse.");
            }
            else if (click.Button == MouseButtons.Middle) 
            {
                MessageBox.Show("Se presionó el botón central del mouse.");
            }
        }
    }
}
