namespace TrabalhoPratico
{
    partial class TipoArtigoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movelRadioButton = new System.Windows.Forms.RadioButton();
            this.mesaRadioButton = new System.Windows.Forms.RadioButton();
            this.cadeiraRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // movelRadioButton
            // 
            this.movelRadioButton.AutoSize = true;
            this.movelRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.movelRadioButton.Location = new System.Drawing.Point(3, 49);
            this.movelRadioButton.Name = "movelRadioButton";
            this.movelRadioButton.Size = new System.Drawing.Size(54, 17);
            this.movelRadioButton.TabIndex = 26;
            this.movelRadioButton.TabStop = true;
            this.movelRadioButton.Text = "Móvel";
            this.movelRadioButton.UseVisualStyleBackColor = false;
            this.movelRadioButton.Click += new System.EventHandler(this.tipoArtigoButton_Click);
            // 
            // mesaRadioButton
            // 
            this.mesaRadioButton.AutoSize = true;
            this.mesaRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.mesaRadioButton.Location = new System.Drawing.Point(3, 26);
            this.mesaRadioButton.Name = "mesaRadioButton";
            this.mesaRadioButton.Size = new System.Drawing.Size(51, 17);
            this.mesaRadioButton.TabIndex = 25;
            this.mesaRadioButton.TabStop = true;
            this.mesaRadioButton.Text = "Mesa";
            this.mesaRadioButton.UseVisualStyleBackColor = false;
            this.mesaRadioButton.Click += new System.EventHandler(this.tipoArtigoButton_Click);
            // 
            // cadeiraRadioButton
            // 
            this.cadeiraRadioButton.AutoSize = true;
            this.cadeiraRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.cadeiraRadioButton.Location = new System.Drawing.Point(3, 3);
            this.cadeiraRadioButton.Name = "cadeiraRadioButton";
            this.cadeiraRadioButton.Size = new System.Drawing.Size(61, 17);
            this.cadeiraRadioButton.TabIndex = 24;
            this.cadeiraRadioButton.TabStop = true;
            this.cadeiraRadioButton.Text = "Cadeira";
            this.cadeiraRadioButton.UseVisualStyleBackColor = false;
            this.cadeiraRadioButton.Click += new System.EventHandler(this.tipoArtigoButton_Click);
            // 
            // TipoArtigoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movelRadioButton);
            this.Controls.Add(this.mesaRadioButton);
            this.Controls.Add(this.cadeiraRadioButton);
            this.Name = "TipoArtigoUserControl";
            this.Size = new System.Drawing.Size(67, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton movelRadioButton;
        private System.Windows.Forms.RadioButton mesaRadioButton;
        private System.Windows.Forms.RadioButton cadeiraRadioButton;
    }
}
