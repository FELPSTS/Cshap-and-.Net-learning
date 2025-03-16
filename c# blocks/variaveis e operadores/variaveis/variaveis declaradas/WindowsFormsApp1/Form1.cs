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
        //variavel declarada para a classe 
        //visivel em todos os metodos (global)
        decimal a = 10;//variavel global
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            listBox1 .Items.Add(a);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string a = "jorge street";
            listBox1.Items.Add(a);
            listBox1.Items.Add(this.a);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
