using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3__Label_y_LinkLabel_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSaludo_MouseMove(object sender, MouseEventArgs e)
        {
            lblSaludo.BackColor = Color.LightBlue;
            lblSaludo.Cursor = Cursors.Hand;
        }

        private void lblSaludo_MouseLeave(object sender, EventArgs e)
        {
            lblSaludo.BackColor = Color.White;
        }
    }
}
