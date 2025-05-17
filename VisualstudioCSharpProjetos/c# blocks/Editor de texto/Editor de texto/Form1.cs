using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RtfTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpcNovo_Click(object sender, EventArgs e)
        {
            RtfTexto.Rtf = string.Empty;
        }

        private void OpcAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir Arquivo";

            openFileDialog1.FileName = "";

            openFileDialog1.InitialDirectory = "C:\\";

            openFileDialog1.Filter = "Arquivos RTF|*.RTF|TUDO!!!|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);

                RtfTexto.Rtf = leitor.ReadToEnd();

                leitor.Close();


            }


        }

        private void OpcSalvar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Abrir Arquivo";

            saveFileDialog1.FileName = "";

            saveFileDialog1.InitialDirectory = "C:\\";

            saveFileDialog1.Filter = "Arquivos RTF|*.RTF";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);

                sw.Write(RtfTexto.Rtf);
                sw.Close();



            }
        }

        private void OpcEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpcRecortar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RtfTexto.SelectedRtf);
            RtfTexto.SelectedRtf = "";
        }

        private void OpcCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RtfTexto.SelectedRtf);
        }

        private void OpcColar_Click(object sender, EventArgs e)
        {
            RtfTexto.SelectedRtf = Clipboard.GetText();
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtfTexto.SelectAll();
        }

        private void OpcFonte_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                RtfTexto.SelectionFont = fontDialog1.Font;
            }
        }

        private void OpcCorDaFonte_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                RtfTexto.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
