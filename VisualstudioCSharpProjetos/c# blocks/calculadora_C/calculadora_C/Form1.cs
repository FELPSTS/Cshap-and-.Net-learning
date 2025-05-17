using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_C
{

    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private double result;

        public Form1()
        {
            int num1;

            int num2;




            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            result = Math.Pow(num1, num2);
        }

        private void label_resultado_Click(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            label_resultado.Text = result.ToString("N0");
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {

        }

        private void txtB_1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtB_1.Text);

        }

        private void txtB_2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtB_2.Text);
        }
        private void btn_positivo_Click(object sender, EventArgs e)
        {
            result = (num1 + num2);

        }

        private void btn_negativo_Click(object sender, EventArgs e)
        {
            result = (num1 - num2);
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            result = (num1 / num2);
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            result = (num1 * num2);
        }

        private void btn_pocertagem_Click(object sender, EventArgs e)
        {
            result = (num1 * num2 / 100);
        }

        private void btn_resto_Click(object sender, EventArgs e)
        {
            result = (num1 % num2);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtB_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != '\b' && e.KeyChar != '\r' && e.KeyChar != '.' &&
                        e.KeyChar != ',')

                {
                    e.KeyChar = '\0';

                }
        }

        private void txtB_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != '\b' && e.KeyChar != '\r' && e.KeyChar != '.' &&
                        e.KeyChar != ',')

                {
                    e.KeyChar = '\0';

                }
        }
    }
}
