using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Sty = new Size(20);
        }

        private void azul_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Arial_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", 8);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Courier", 8);
        }

        private void Time_New_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times new Roman", 8);
        }

        private void calibrir_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Calibri", 8);
        }

        private void Negrito_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void verde_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void vermelho_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void laranja_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Orange;
        }

        private void esquerda_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
