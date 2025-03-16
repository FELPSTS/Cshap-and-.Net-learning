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

namespace atividade_entrada
{
    public partial class Form1 : Form
    {
        string[] numeros = new string[10];
        int media , soma;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                numeros[i] = (Interaction.InputBox("Informe o numero"));
               
            }
           
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                lstentrada.Items.Add("nota [" + i + "] = " + numeros[i]);
            }
            }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                 soma = soma + Convert.ToInt32(numeros[i]);
            }
            media = Convert.ToInt32(soma) / 10;
            lstentrada.Items.Add("media = " + media);

            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                if(Convert.ToInt32(numeros[i]) > media )
                {
                   lstentrada.Items.Add("nota [" + i + "] = " + numeros[i] + "\n esta acima da media");
                }

                
            }
        }
    }
}
