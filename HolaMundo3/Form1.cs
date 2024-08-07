using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Saludo.Text = "Escribe tu nombre abajo y presiona OK";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Saludo.Text = "Hola "+textBox1.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
