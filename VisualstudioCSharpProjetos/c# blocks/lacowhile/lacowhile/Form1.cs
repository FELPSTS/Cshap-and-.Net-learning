using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;

            while(num<=5000)
            {
                listBox1.Items.Add("NUM: " + num);
                num += 1;
            }
            listBox1.Items.Add(new string('-', 30));
        }
    }
}

