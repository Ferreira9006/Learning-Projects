namespace TrabalhoPratico
{
    partial class FormInicial
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
            this.artigosButton = new System.Windows.Forms.Button();
            this.sobreButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artigosButton
            // 
            this.artigosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.artigosButton.Location = new System.Drawing.Point(12, 12);
            this.artigosButton.Name = "artigosButton";
            this.artigosButton.Size = new System.Drawing.Size(248, 35);
            this.artigosButton.TabIndex = 0;
            this.artigosButton.Text = "Gestão de Artigos*";
            this.artigosButton.UseVisualStyleBackColor = true;
            this.artigosButton.Click += new System.EventHandler(this.artigosButton_Click);
            // 
            // sobreButton
            // 
            this.sobreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sobreButton.Location = new System.Drawing.Point(12, 53);
            this.sobreButton.Name = "sobreButton";
            this.sobreButton.Size = new System.Drawing.Size(248, 35);
            this.sobreButton.TabIndex = 1;
            this.sobreButton.Text = "Sobre*";
            this.sobreButton.UseVisualStyleBackColor = true;
            this.sobreButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairButton.Location = new System.Drawing.Point(12, 110);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(248, 35);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair*";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 159);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.sobreButton);
            this.Controls.Add(this.artigosButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial*";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button artigosButton;
        private System.Windows.Forms.Button sobreButton;
        private System.Windows.Forms.Button sairButton;
    }
}

