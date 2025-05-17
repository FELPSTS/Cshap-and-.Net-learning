using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operador_ternario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*o perador Ternario,ou operador conditional,é composto por três
             * operandos aseparados pelos sinais (?) e (:) etem o objetivos de 
             * atribuir um valor a uma variavle de acorod
               * com resultado de teste logico .sua sintaxe é a seguinte:
               *teste logico ? valor verdadeiro : valor falso;*/
        private void exemplo_Click(object sender, EventArgs e)
        {
            int numero;
            numero = 10;
            listBox1.Items.Add(numero + " é " + (numero % 2 == 0 ? " par " : " ímpar "));
            listBox1.Items.Add(new string('-', 20));

            numero = 15;
            listBox1.Items.Add(numero + " é " + (numero % 2 == 0 ? " par " : " ímpar "));
            listBox1.Items.Add(new string('-', 20));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
