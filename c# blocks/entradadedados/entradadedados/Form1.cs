using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;0'
using System.Windows.Forms;

namespace entradadedados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] numeros ={ 0,50,100,200,250,400,500 };

            for(int i= 0;  i <= numeros.Length - 1; i ++)
            {
                listBox1.Items.Add("numero [" + i + "] = " + numeros [i]);
            }
        }
    }
}
