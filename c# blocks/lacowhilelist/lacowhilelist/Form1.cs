using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacowhilelist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lista = { "Brasil", "Alemanha", "México", "Chile", "Holanda", "Colômbia", "Argentina", "Uruguai"};

            foreach (string pais in lista)
                {
                if(pais.ToUpper().StartsWith("C"&&"A"))
                {
                    listBox1.Items.Add(new string('-', 30));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
