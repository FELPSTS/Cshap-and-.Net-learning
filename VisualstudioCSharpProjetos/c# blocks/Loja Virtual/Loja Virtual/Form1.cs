using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Virtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbPc.Checked = false;
            rbMac.Checked = false;
            rbUltra.Checked = false;
            pictureBox1.Image = null;
            cbFax.Checked = false;
            cbCopiadora.Checked = false;
            cbCalculadora.Checked = false;
            lsb1.SelectedIndex = -1;
            pictureBox5.Image = null;
            comboBox1.SelectedIndex = -1;
            pictureBox6.Image = null;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pic6.Image = Properties.Resources.Pix;
                    break;

                case 1:
                    pic6.Image = Properties.Resources.Cartao;
                    break;

                case 2:
                    pictureBox6.Image = Properties.Resources.Boleto;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("PIX");
            comboBox1.Items.Add("Cartão");
            comboBox1.Items.Add("Boleto");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gbComputadores_Enter(object sender, EventArgs e)
        {
            
        }

        private void lsb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lsb1.SelectedIndex)
            {
                case 0:
                    pictureBox5.Image = Properties.Resources.HUB;
                    break;

                case 1:
                    pictureBox5.Image = Properties.Resources.HD;
                    break;

                case 2:
                    pictureBox5.Image = Properties.Resources.IMpressora;
                    break;
            }
        }

        private void rbPc_CheckedChanged(object sender, EventArgs e)
        {

            if (rbPc.Checked)
            {
                pictureBox1.Image = Properties.Resources.PC;
            }
        }

        private void rbMac_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMac.Checked)
            {
                pictureBox1.Image = Properties.Resources.MAC;
            }
        }

        private void rbUltra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUltra.Checked)
            {
                pictureBox1.Image = Properties.Resources.ULTRA;
            }
        }

        private void cbFax_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFax.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.Fax;
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void cbCopiadora_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCopiadora.Checked == true)
            {
                pic6.Image = Properties.Resources.Copiadora;
            }
            else
            {
                pic6.Image = null;
            }
        }

        private void cbCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCalculadora.Checked == true)
            {
                pictureBox4.Image = Properties.Resources.Calculadora;
            }
            else
            {
                pictureBox4.Image = null;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
