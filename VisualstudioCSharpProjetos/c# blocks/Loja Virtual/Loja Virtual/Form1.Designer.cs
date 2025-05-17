namespace Loja_Virtual
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbComputadores = new System.Windows.Forms.GroupBox();
            this.rbUltra = new System.Windows.Forms.RadioButton();
            this.rbMac = new System.Windows.Forms.RadioButton();
            this.rbPc = new System.Windows.Forms.RadioButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lsb1 = new System.Windows.Forms.ListBox();
            this.gbMaquinas = new System.Windows.Forms.GroupBox();
            this.cbCopiadora = new System.Windows.Forms.CheckBox();
            this.cbCalculadora = new System.Windows.Forms.CheckBox();
            this.cbFax = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gbComputadores.SuspendLayout();
            this.gbMaquinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gbComputadores
            // 
            this.gbComputadores.Controls.Add(this.rbUltra);
            this.gbComputadores.Controls.Add(this.rbMac);
            this.gbComputadores.Controls.Add(this.rbPc);
            this.gbComputadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComputadores.Location = new System.Drawing.Point(12, 102);
            this.gbComputadores.Name = "gbComputadores";
            this.gbComputadores.Size = new System.Drawing.Size(237, 129);
            this.gbComputadores.TabIndex = 0;
            this.gbComputadores.TabStop = false;
            this.gbComputadores.Text = "Computadores";
            this.gbComputadores.Enter += new System.EventHandler(this.gbComputadores_Enter);
            // 
            // rbUltra
            // 
            this.rbUltra.AutoSize = true;
            this.rbUltra.Location = new System.Drawing.Point(7, 66);
            this.rbUltra.Name = "rbUltra";
            this.rbUltra.Size = new System.Drawing.Size(65, 28);
            this.rbUltra.TabIndex = 2;
            this.rbUltra.Text = "Ultra";
            this.rbUltra.UseVisualStyleBackColor = true;
            this.rbUltra.CheckedChanged += new System.EventHandler(this.rbUltra_CheckedChanged);
            // 
            // rbMac
            // 
            this.rbMac.AutoSize = true;
            this.rbMac.Location = new System.Drawing.Point(7, 42);
            this.rbMac.Name = "rbMac";
            this.rbMac.Size = new System.Drawing.Size(64, 28);
            this.rbMac.TabIndex = 1;
            this.rbMac.Text = "Mac";
            this.rbMac.UseVisualStyleBackColor = true;
            this.rbMac.CheckedChanged += new System.EventHandler(this.rbMac_CheckedChanged);
            // 
            // rbPc
            // 
            this.rbPc.AutoSize = true;
            this.rbPc.Location = new System.Drawing.Point(7, 20);
            this.rbPc.Name = "rbPc";
            this.rbPc.Size = new System.Drawing.Size(53, 28);
            this.rbPc.TabIndex = 0;
            this.rbPc.Text = "PC";
            this.rbPc.UseVisualStyleBackColor = true;
            this.rbPc.CheckedChanged += new System.EventHandler(this.rbPc_CheckedChanged);
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(405, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(185, 42);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Loja Virtual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pereféricos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(786, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Forma de Pagamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Computador";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Máquinas de Escritório";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pereféricos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(826, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pagamento";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(830, 350);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 37);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // lsb1
            // 
            this.lsb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb1.FormattingEnabled = true;
            this.lsb1.ItemHeight = 16;
            this.lsb1.Items.AddRange(new object[] {
            "HUB",
            "HD",
            "Impressora"});
            this.lsb1.Location = new System.Drawing.Point(606, 129);
            this.lsb1.Name = "lsb1";
            this.lsb1.Size = new System.Drawing.Size(151, 52);
            this.lsb1.TabIndex = 19;
            this.lsb1.SelectedIndexChanged += new System.EventHandler(this.lsb1_SelectedIndexChanged);
            // 
            // gbMaquinas
            // 
            this.gbMaquinas.Controls.Add(this.cbCopiadora);
            this.gbMaquinas.Controls.Add(this.cbCalculadora);
            this.gbMaquinas.Controls.Add(this.cbFax);
            this.gbMaquinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaquinas.Location = new System.Drawing.Point(265, 102);
            this.gbMaquinas.Name = "gbMaquinas";
            this.gbMaquinas.Size = new System.Drawing.Size(249, 129);
            this.gbMaquinas.TabIndex = 20;
            this.gbMaquinas.TabStop = false;
            this.gbMaquinas.Text = "Máquinas de Escritório";
            // 
            // cbCopiadora
            // 
            this.cbCopiadora.AutoSize = true;
            this.cbCopiadora.Location = new System.Drawing.Point(7, 42);
            this.cbCopiadora.Name = "cbCopiadora";
            this.cbCopiadora.Size = new System.Drawing.Size(116, 28);
            this.cbCopiadora.TabIndex = 3;
            this.cbCopiadora.Text = "Copiadora";
            this.cbCopiadora.UseVisualStyleBackColor = true;
            this.cbCopiadora.CheckedChanged += new System.EventHandler(this.cbCopiadora_CheckedChanged);
            // 
            // cbCalculadora
            // 
            this.cbCalculadora.AutoSize = true;
            this.cbCalculadora.Location = new System.Drawing.Point(7, 66);
            this.cbCalculadora.Name = "cbCalculadora";
            this.cbCalculadora.Size = new System.Drawing.Size(129, 28);
            this.cbCalculadora.TabIndex = 2;
            this.cbCalculadora.Text = "Calculadora";
            this.cbCalculadora.UseVisualStyleBackColor = true;
            this.cbCalculadora.CheckedChanged += new System.EventHandler(this.cbCalculadora_CheckedChanged);
            // 
            // cbFax
            // 
            this.cbFax.AutoSize = true;
            this.cbFax.Location = new System.Drawing.Point(7, 20);
            this.cbFax.Name = "cbFax";
            this.cbFax.Size = new System.Drawing.Size(61, 28);
            this.cbFax.TabIndex = 0;
            this.cbFax.Text = "Fax";
            this.cbFax.UseVisualStyleBackColor = true;
            this.cbFax.CheckedChanged += new System.EventHandler(this.cbFax_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(804, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(179, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 85);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(583, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 108);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic6
            // 
            this.pic6.Location = new System.Drawing.Point(785, 236);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(194, 108);
            this.pic6.TabIndex = 27;
            this.pic6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(142, 85);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(459, 273);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(118, 85);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(318, 273);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(135, 85);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 487);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbMaquinas);
            this.Controls.Add(this.lsb1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.gbComputadores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbComputadores.ResumeLayout(false);
            this.gbComputadores.PerformLayout();
            this.gbMaquinas.ResumeLayout(false);
            this.gbMaquinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbComputadores;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lsb1;
        private System.Windows.Forms.RadioButton rbUltra;
        private System.Windows.Forms.RadioButton rbMac;
        private System.Windows.Forms.RadioButton rbPc;
        private System.Windows.Forms.GroupBox gbMaquinas;
        private System.Windows.Forms.CheckBox cbCalculadora;
        private System.Windows.Forms.CheckBox cbFax;
        private System.Windows.Forms.CheckBox cbCopiadora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

