namespace TrabalhoPratico
{
    partial class FormArtigo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novoButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.listarArtigosButton = new System.Windows.Forms.Button();
            this.artigosListBox = new System.Windows.Forms.ListBox();
            this.totalArtigosLabel = new System.Windows.Forms.Label();
            this.totalArtigosTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.precoLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.dataValidadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataValidadeLabel = new System.Windows.Forms.Label();
            this.obterButton = new System.Windows.Forms.Button();
            this.tipoArtigoLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.listagemLabel = new System.Windows.Forms.Label();
            this.gestaoLabel = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoArtigoUserControl = new TrabalhoPratico.TipoArtigoUserControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.toolStripSeparator1,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo *";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gravarToolStripMenuItem.Text = "Gravar *";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar *";
            this.eliminarToolStripMenuItem.DisplayStyleChanged += new System.EventHandler(this.eliminarButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair *";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // novoButton
            // 
            this.novoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoButton.Location = new System.Drawing.Point(496, 323);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(86, 37);
            this.novoButton.TabIndex = 20;
            this.novoButton.Text = "Novo *";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // gravarButton
            // 
            this.gravarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gravarButton.Location = new System.Drawing.Point(496, 366);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(86, 37);
            this.gravarButton.TabIndex = 21;
            this.gravarButton.Text = "Gravar *";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.Location = new System.Drawing.Point(496, 409);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(86, 37);
            this.eliminarButton.TabIndex = 22;
            this.eliminarButton.Text = "Eliminar *";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairButton.Location = new System.Drawing.Point(496, 452);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(86, 37);
            this.sairButton.TabIndex = 23;
            this.sairButton.Text = "Sair *";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // listarArtigosButton
            // 
            this.listarArtigosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listarArtigosButton.Location = new System.Drawing.Point(55, 72);
            this.listarArtigosButton.Name = "listarArtigosButton";
            this.listarArtigosButton.Size = new System.Drawing.Size(107, 37);
            this.listarArtigosButton.TabIndex = 2;
            this.listarArtigosButton.Text = "Listar Artigos*";
            this.listarArtigosButton.UseVisualStyleBackColor = true;
            this.listarArtigosButton.Click += new System.EventHandler(this.listarArtigosButton_Click);
            // 
            // artigosListBox
            // 
            this.artigosListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.artigosListBox.FormattingEnabled = true;
            this.artigosListBox.Location = new System.Drawing.Point(168, 72);
            this.artigosListBox.Name = "artigosListBox";
            this.artigosListBox.Size = new System.Drawing.Size(411, 147);
            this.artigosListBox.TabIndex = 3;
            this.artigosListBox.SelectedIndexChanged += new System.EventHandler(this.artigosListBox_SelectedIndexChanged);
            // 
            // totalArtigosLabel
            // 
            this.totalArtigosLabel.AutoSize = true;
            this.totalArtigosLabel.Location = new System.Drawing.Point(429, 228);
            this.totalArtigosLabel.Name = "totalArtigosLabel";
            this.totalArtigosLabel.Size = new System.Drawing.Size(91, 13);
            this.totalArtigosLabel.TabIndex = 4;
            this.totalArtigosLabel.Text = "Total de Artigos: *";
            // 
            // totalArtigosTextBox
            // 
            this.totalArtigosTextBox.Location = new System.Drawing.Point(526, 225);
            this.totalArtigosTextBox.Name = "totalArtigosTextBox";
            this.totalArtigosTextBox.ReadOnly = true;
            this.totalArtigosTextBox.Size = new System.Drawing.Size(53, 20);
            this.totalArtigosTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(149, 297);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(279, 20);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idTextBox_KeyUp);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(54, 301);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "Id: *";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(149, 323);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(279, 20);
            this.descricaoTextBox.TabIndex = 11;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(54, 326);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(65, 13);
            this.descricaoLabel.TabIndex = 10;
            this.descricaoLabel.Text = "Descrição: *";
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(149, 349);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(279, 20);
            this.precoTextBox.TabIndex = 13;
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(54, 352);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(45, 13);
            this.precoLabel.TabIndex = 12;
            this.precoLabel.Text = "Preço: *";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(54, 483);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(50, 13);
            this.estadoLabel.TabIndex = 18;
            this.estadoLabel.Text = "Estado: *";
            // 
            // dataValidadeDateTimePicker
            // 
            this.dataValidadeDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataValidadeDateTimePicker.Location = new System.Drawing.Point(149, 379);
            this.dataValidadeDateTimePicker.Name = "dataValidadeDateTimePicker";
            this.dataValidadeDateTimePicker.Size = new System.Drawing.Size(279, 20);
            this.dataValidadeDateTimePicker.TabIndex = 15;
            // 
            // dataValidadeLabel
            // 
            this.dataValidadeLabel.AutoSize = true;
            this.dataValidadeLabel.Location = new System.Drawing.Point(54, 381);
            this.dataValidadeLabel.Name = "dataValidadeLabel";
            this.dataValidadeLabel.Size = new System.Drawing.Size(84, 13);
            this.dataValidadeLabel.TabIndex = 14;
            this.dataValidadeLabel.Text = "Data Validade: *";
            // 
            // obterButton
            // 
            this.obterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obterButton.Location = new System.Drawing.Point(434, 297);
            this.obterButton.Name = "obterButton";
            this.obterButton.Size = new System.Drawing.Size(36, 20);
            this.obterButton.TabIndex = 9;
            this.obterButton.Text = "... *";
            this.obterButton.UseVisualStyleBackColor = true;
            this.obterButton.Click += new System.EventHandler(this.obterButton_Click);
            // 
            // tipoArtigoLabel
            // 
            this.tipoArtigoLabel.AutoSize = true;
            this.tipoArtigoLabel.Location = new System.Drawing.Point(54, 433);
            this.tipoArtigoLabel.Name = "tipoArtigoLabel";
            this.tipoArtigoLabel.Size = new System.Drawing.Size(68, 13);
            this.tipoArtigoLabel.TabIndex = 16;
            this.tipoArtigoLabel.Text = "Tipo Artigo: *";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // listagemLabel
            // 
            this.listagemLabel.AutoSize = true;
            this.listagemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listagemLabel.Location = new System.Drawing.Point(12, 37);
            this.listagemLabel.Name = "listagemLabel";
            this.listagemLabel.Size = new System.Drawing.Size(155, 16);
            this.listagemLabel.TabIndex = 1;
            this.listagemLabel.Text = "Listagem de Artigos *";
            // 
            // gestaoLabel
            // 
            this.gestaoLabel.AutoSize = true;
            this.gestaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestaoLabel.Location = new System.Drawing.Point(12, 259);
            this.gestaoLabel.Name = "gestaoLabel";
            this.gestaoLabel.Size = new System.Drawing.Size(142, 16);
            this.gestaoLabel.TabIndex = 6;
            this.gestaoLabel.Text = "Gestão de Artigos *";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(151, 480);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(277, 21);
            this.estadoComboBox.TabIndex = 19;
            // 
            // tipoArtigoUserControl
            // 
            this.tipoArtigoUserControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoArtigoUserControl.Location = new System.Drawing.Point(149, 406);
            this.tipoArtigoUserControl.Name = "tipoArtigoUserControl";
            this.tipoArtigoUserControl.Size = new System.Drawing.Size(67, 68);
            this.tipoArtigoUserControl.TabIndex = 17;
            this.tipoArtigoUserControl.TextoTipo1 = "Cadeira";
            this.tipoArtigoUserControl.TextoTipo2 = "Mesa";
            this.tipoArtigoUserControl.TextoTipo3 = "Móvel";
            this.tipoArtigoUserControl.Tipo = CamadaNegocio.TipoArtigo.Tipo1;
            // 
            // FormArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 544);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.gestaoLabel);
            this.Controls.Add(this.listagemLabel);
            this.Controls.Add(this.tipoArtigoUserControl);
            this.Controls.Add(this.tipoArtigoLabel);
            this.Controls.Add(this.obterButton);
            this.Controls.Add(this.dataValidadeLabel);
            this.Controls.Add(this.dataValidadeDateTimePicker);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.totalArtigosTextBox);
            this.Controls.Add(this.totalArtigosLabel);
            this.Controls.Add(this.artigosListBox);
            this.Controls.Add(this.listarArtigosButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Artigos*";
            this.Load += new System.EventHandler(this.FormArtigo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button listarArtigosButton;
        private System.Windows.Forms.ListBox artigosListBox;
        private System.Windows.Forms.Label totalArtigosLabel;
        private System.Windows.Forms.TextBox totalArtigosTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.DateTimePicker dataValidadeDateTimePicker;
        private System.Windows.Forms.Label dataValidadeLabel;
        private System.Windows.Forms.Button obterButton;
        private System.Windows.Forms.Label tipoArtigoLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private TipoArtigoUserControl tipoArtigoUserControl;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label gestaoLabel;
        private System.Windows.Forms.Label listagemLabel;
        private System.Windows.Forms.ComboBox estadoComboBox;
    }
}