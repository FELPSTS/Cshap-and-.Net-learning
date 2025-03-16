using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lendo_input_box
{
    public partial class Form1 : Form
    {
        double a1, soma = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnestrada_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<=3; i++)
            {
                a1 = Convert.ToDouble(Interaction.InputBox("Informe o numero"));
                soma = soma + a1;
                lstResult.Items.Add(a1);
            }
            lstResult.Items.Add(soma);
        }
    }
}
