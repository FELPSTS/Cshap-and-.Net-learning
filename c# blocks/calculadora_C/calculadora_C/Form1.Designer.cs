namespace calculadora_C
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
            this.texto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_1 = new System.Windows.Forms.TextBox();
            this.txtB_2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_negativo = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_positivo = new System.Windows.Forms.Button();
            this.btn_pocertagem = new System.Windows.Forms.Button();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_resto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(71, 31);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(102, 13);
            this.texto.TabIndex = 0;
            this.texto.Text = "Calculadora Simples";
            this.texto.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "valor 2";
            // 
            // txtB_1
            // 
            this.txtB_1.Location = new System.Drawing.Point(95, 75);
            this.txtB_1.Name = "txtB_1";
            this.txtB_1.Size = new System.Drawing.Size(100, 20);
            this.txtB_1.TabIndex = 3;
            this.txtB_1.TextChanged += new System.EventHandler(this.txtB_1_TextChanged);
            this.txtB_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_1_KeyPress);
            // 
            // txtB_2
            // 
            this.txtB_2.Location = new System.Drawing.Point(95, 110);
            this.txtB_2.Name = "txtB_2";
            this.txtB_2.Size = new System.Drawing.Size(100, 20);
            this.txtB_2.TabIndex = 4;
            this.txtB_2.TextChanged += new System.EventHandler(this.txtB_2_TextChanged);
            this.txtB_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_2_KeyPress);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(22, 153);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(50, 13);
            this.resultado.TabIndex = 5;
            this.resultado.Text = "resultado";
            // 
            // label_resultado
            // 
            this.label_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_resultado.Location = new System.Drawing.Point(95, 152);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(100, 23);
            this.label_resultado.TabIndex = 6;
            this.label_resultado.Text = "RESULTADO";
            this.label_resultado.Click += new System.EventHandler(this.label_resultado_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.BackColor = System.Drawing.Color.Orange;
            this.btn_divisao.Location = new System.Drawing.Point(21, 299);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(75, 23);
            this.btn_divisao.TabIndex = 7;
            this.btn_divisao.Text = "/";
            this.btn_divisao.UseVisualStyleBackColor = false;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_negativo
            // 
            this.btn_negativo.BackColor = System.Drawing.Color.Orange;
            this.btn_negativo.Location = new System.Drawing.Point(21, 254);
            this.btn_negativo.Name = "btn_negativo";
            this.btn_negativo.Size = new System.Drawing.Size(75, 23);
            this.btn_negativo.TabIndex = 7;
            this.btn_negativo.Text = "-";
            this.btn_negativo.UseVisualStyleBackColor = false;
            this.btn_negativo.Click += new System.EventHandler(this.btn_negativo_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.BackColor = System.Drawing.Color.Orange;
            this.btn_multiplicacao.Location = new System.Drawing.Point(120, 299);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(75, 23);
            this.btn_multiplicacao.TabIndex = 8;
            this.btn_multiplicacao.Text = "*";
            this.btn_multiplicacao.UseVisualStyleBackColor = false;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_positivo
            // 
            this.btn_positivo.BackColor = System.Drawing.Color.Orange;
            this.btn_positivo.Location = new System.Drawing.Point(120, 254);
            this.btn_positivo.Name = "btn_positivo";
            this.btn_positivo.Size = new System.Drawing.Size(75, 23);
            this.btn_positivo.TabIndex = 9;
            this.btn_positivo.Text = "+";
            this.btn_positivo.UseVisualStyleBackColor = false;
            this.btn_positivo.Click += new System.EventHandler(this.btn_positivo_Click);
            // 
            // btn_pocertagem
            // 
            this.btn_pocertagem.BackColor = System.Drawing.Color.Orange;
            this.btn_pocertagem.Location = new System.Drawing.Point(120, 342);
            this.btn_pocertagem.Name = "btn_pocertagem";
            this.btn_pocertagem.Size = new System.Drawing.Size(75, 23);
            this.btn_pocertagem.TabIndex = 10;
            this.btn_pocertagem.Text = "%";
            this.btn_pocertagem.UseVisualStyleBackColor = false;
            this.btn_pocertagem.Click += new System.EventHandler(this.btn_pocertagem_Click);
            // 
            // btn_potencia
            // 
            this.btn_potencia.BackColor = System.Drawing.Color.Orange;
            this.btn_potencia.Location = new System.Drawing.Point(21, 342);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(75, 23);
            this.btn_potencia.TabIndex = 11;
            this.btn_potencia.Text = "^";
            this.btn_potencia.UseVisualStyleBackColor = false;
            this.btn_potencia.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.BackColor = System.Drawing.Color.Orange;
            this.btn_limpa.ForeColor = System.Drawing.Color.Red;
            this.btn_limpa.Location = new System.Drawing.Point(21, 209);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(75, 23);
            this.btn_limpa.TabIndex = 12;
            this.btn_limpa.Text = "C";
            this.btn_limpa.UseCompatibleTextRendering = true;
            this.btn_limpa.UseVisualStyleBackColor = false;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_result
            // 
            this.btn_result.BackColor = System.Drawing.Color.Orange;
            this.btn_result.Location = new System.Drawing.Point(120, 209);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 13;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = false;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_resto
            // 
            this.btn_resto.BackColor = System.Drawing.Color.Orange;
            this.btn_resto.Location = new System.Drawing.Point(36, 383);
            this.btn_resto.Name = "btn_resto";
            this.btn_resto.Size = new System.Drawing.Size(140, 59);
            this.btn_resto.TabIndex = 14;
            this.btn_resto.Text = "RESTO";
            this.btn_resto.UseVisualStyleBackColor = false;
            this.btn_resto.Click += new System.EventHandler(this.btn_resto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(234, 466);
            this.Controls.Add(this.btn_resto);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_potencia);
            this.Controls.Add(this.btn_pocertagem);
            this.Controls.Add(this.btn_positivo);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_negativo);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.txtB_2);
            this.Controls.Add(this.txtB_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_1;
        private System.Windows.Forms.TextBox txtB_2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_negativo;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_positivo;
        private System.Windows.Forms.Button btn_pocertagem;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_resto;
    }
}

