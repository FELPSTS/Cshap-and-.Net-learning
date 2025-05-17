using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseStreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Microssanair";
            string endereco = "Alemeda jaú,32";
            string cidade = "São paulo";
            string uf = "SP";
            System.IO.StreamWriter escritor = new System.IO.StreamWriter(@"C:\Users\lab_street\Escritor.txt", true);
            escritor.WriteLine(nome.PadRight(20) + endereco.PadRight(25) + cidade.PadRight(20) + uf);
            escritor.Close();
                MessageBox.Show("Registro gravado com sucesso!");
        } 

        private void btnLer_Click(object sender,EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear()
            string registro = string.Empty;
            System.IO.StreamReader leitor = new System.IO.StreamReader(@"C:\Users\lab_street\Escritor.txt",Encoding,UTF8);
            while (!leitor.EndOfStream) {

                registro = leitor.ReadLiner();
                exemploListBox.Items.Add(
                    "Nome:  " + registro.Substring(0, 20).Trim());

                exemploListBox.Items.Add(
                    "endereco:  " + registro.Substring(20, 25).Trim());

                exemploListBox.Items.Add(
                    "cidade:  " + registro.Substring(45, 20).Trim());

                exemploListBox.Items.Add(
                    "uf:  " + registro.Substring(65, 2).Trim());
                listBox1.Items.Add(new string('-', 40));
            }

        }

        leitor.Close();
    }
}
