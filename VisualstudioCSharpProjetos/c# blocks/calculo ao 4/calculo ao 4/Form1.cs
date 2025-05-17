using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_ao_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num, quadrado;
            num = Convert.ToDouble(textBox.Text);
            quadrado = Math.Pow(num, 2);
            lblreuslt.Text = "O quadrado de " +
                num.ToString() + " é =" + quadrado.ToString("N0");
            textBox.Focus();
            textBox.SelectAll();

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            if(e.KeyChar != '\b' && e.KeyChar != '\r' && e.KeyChar != '.' &&
                    e.KeyChar != ',')

                 {
                e.KeyChar = '\0';

            }
        }
    }
}
