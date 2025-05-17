namespace Editor_de_texto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpcSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.OpcEncerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcColar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcCorDaFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.RtfTexto = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.recortarToolStripButton,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.toolStripSeparator1,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuArquivo,
            this.MnuEditar,
            this.MnuFormatar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuArquivo
            // 
            this.MnuArquivo.BackColor = System.Drawing.Color.DimGray;
            this.MnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcNovo,
            this.OpcAbrir,
            this.toolStripSeparator2,
            this.OpcSalvar,
            this.toolStripSeparator4,
            this.OpcEncerrar});
            this.MnuArquivo.ForeColor = System.Drawing.Color.White;
            this.MnuArquivo.Name = "MnuArquivo";
            this.MnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.MnuArquivo.Text = "&Arquivo";
            this.MnuArquivo.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // OpcNovo
            // 
            this.OpcNovo.Image = ((System.Drawing.Image)(resources.GetObject("OpcNovo.Image")));
            this.OpcNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcNovo.Name = "OpcNovo";
            this.OpcNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.OpcNovo.Size = new System.Drawing.Size(180, 22);
            this.OpcNovo.Text = "&Novo";
            this.OpcNovo.Click += new System.EventHandler(this.OpcNovo_Click);
            // 
            // OpcAbrir
            // 
            this.OpcAbrir.Image = ((System.Drawing.Image)(resources.GetObject("OpcAbrir.Image")));
            this.OpcAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcAbrir.Name = "OpcAbrir";
            this.OpcAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpcAbrir.Size = new System.Drawing.Size(180, 22);
            this.OpcAbrir.Text = "&Abrir";
            this.OpcAbrir.Click += new System.EventHandler(this.OpcAbrir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // OpcSalvar
            // 
            this.OpcSalvar.Image = ((System.Drawing.Image)(resources.GetObject("OpcSalvar.Image")));
            this.OpcSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcSalvar.Name = "OpcSalvar";
            this.OpcSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.OpcSalvar.Size = new System.Drawing.Size(180, 22);
            this.OpcSalvar.Text = "&Salvar";
            this.OpcSalvar.Click += new System.EventHandler(this.OpcSalvar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // OpcEncerrar
            // 
            this.OpcEncerrar.Name = "OpcEncerrar";
            this.OpcEncerrar.Size = new System.Drawing.Size(180, 22);
            this.OpcEncerrar.Text = "En&cerrar";
            this.OpcEncerrar.Click += new System.EventHandler(this.OpcEncerrar_Click);
            // 
            // MnuEditar
            // 
            this.MnuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcRecortar,
            this.OpcCopiar,
            this.OpcColar,
            this.toolStripSeparator6,
            this.selecionarTudoToolStripMenuItem});
            this.MnuEditar.ForeColor = System.Drawing.Color.White;
            this.MnuEditar.Name = "MnuEditar";
            this.MnuEditar.Size = new System.Drawing.Size(49, 20);
            this.MnuEditar.Text = "&Editar";
            // 
            // OpcRecortar
            // 
            this.OpcRecortar.Image = ((System.Drawing.Image)(resources.GetObject("OpcRecortar.Image")));
            this.OpcRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcRecortar.Name = "OpcRecortar";
            this.OpcRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.OpcRecortar.Size = new System.Drawing.Size(180, 22);
            this.OpcRecortar.Text = "Recor&tar";
            this.OpcRecortar.Click += new System.EventHandler(this.OpcRecortar_Click);
            // 
            // OpcCopiar
            // 
            this.OpcCopiar.Image = ((System.Drawing.Image)(resources.GetObject("OpcCopiar.Image")));
            this.OpcCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcCopiar.Name = "OpcCopiar";
            this.OpcCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.OpcCopiar.Size = new System.Drawing.Size(180, 22);
            this.OpcCopiar.Text = "&Copiar";
            this.OpcCopiar.Click += new System.EventHandler(this.OpcCopiar_Click);
            // 
            // OpcColar
            // 
            this.OpcColar.Image = ((System.Drawing.Image)(resources.GetObject("OpcColar.Image")));
            this.OpcColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcColar.Name = "OpcColar";
            this.OpcColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.OpcColar.Size = new System.Drawing.Size(180, 22);
            this.OpcColar.Text = "C&olar";
            this.OpcColar.Click += new System.EventHandler(this.OpcColar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // MnuFormatar
            // 
            this.MnuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcFonte,
            this.OpcCorDaFonte});
            this.MnuFormatar.ForeColor = System.Drawing.Color.White;
            this.MnuFormatar.Name = "MnuFormatar";
            this.MnuFormatar.Size = new System.Drawing.Size(67, 20);
            this.MnuFormatar.Text = "&Formatar";
            // 
            // OpcFonte
            // 
            this.OpcFonte.Name = "OpcFonte";
            this.OpcFonte.Size = new System.Drawing.Size(180, 22);
            this.OpcFonte.Text = "Fo&nte";
            this.OpcFonte.Click += new System.EventHandler(this.OpcFonte_Click);
            // 
            // OpcCorDaFonte
            // 
            this.OpcCorDaFonte.Name = "OpcCorDaFonte";
            this.OpcCorDaFonte.Size = new System.Drawing.Size(180, 22);
            this.OpcCorDaFonte.Text = "C&or da fonte";
            this.OpcCorDaFonte.Click += new System.EventHandler(this.OpcCorDaFonte_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RtfTexto
            // 
            this.RtfTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RtfTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtfTexto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RtfTexto.Location = new System.Drawing.Point(0, 49);
            this.RtfTexto.Name = "RtfTexto";
            this.RtfTexto.Size = new System.Drawing.Size(776, 405);
            this.RtfTexto.TabIndex = 2;
            this.RtfTexto.Text = "";
            this.RtfTexto.TextChanged += new System.EventHandler(this.RtfTexto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 454);
            this.Controls.Add(this.RtfTexto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem OpcNovo;
        private System.Windows.Forms.ToolStripMenuItem OpcAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OpcSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem OpcEncerrar;
        private System.Windows.Forms.ToolStripMenuItem MnuEditar;
        private System.Windows.Forms.ToolStripMenuItem OpcRecortar;
        private System.Windows.Forms.ToolStripMenuItem OpcCopiar;
        private System.Windows.Forms.ToolStripMenuItem OpcColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFormatar;
        private System.Windows.Forms.ToolStripMenuItem OpcFonte;
        private System.Windows.Forms.ToolStripMenuItem OpcCorDaFonte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox RtfTexto;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

