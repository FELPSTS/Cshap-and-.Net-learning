using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String produto = "caneta";
            decimal preco = 6.32m;
            decimal valor = 1276.32m;
                /*Para valores interiros inteiros ou não inteiros , temos alguns 
                 * caracters que aplicam  formatos aos seus argumentos:
                 *  C
                 *  D
                 *  E
                 *  F
                 *  G
                 *  N
                 *  
                 *  P
                 *  R
                 *  X Hexadecim */

            listBox.Items.Add(string.Format("Produto: {0} Preço:{1}", produto, preco));

            listBox.Items.Add(string.Format
                ("Produto: {0} Preço:{1:C2}", produto, preco));

            listBox.Items.Add(string.Format
                ("Produto: {0} Preço:{1:C2}", produto, preco.ToString("C20")));

            label1.Text = valor.ToString("C2") + "\n\n"
                + valor.ToString("C2",
                new System.Globalization.CultureInfo("ja-jp"));
        }
    }
}
