namespace TrabalhoPratico
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.desenvolvidoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anoLectivoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutTextBox.Enabled = false;
            this.aboutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.aboutTextBox.Location = new System.Drawing.Point(15, 51);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(372, 110);
            this.aboutTextBox.TabIndex = 2;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(12, 23);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(171, 16);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Gabriel Ferreira, a22309449";
            // 
            // desenvolvidoLabel
            // 
            this.desenvolvidoLabel.AutoSize = true;
            this.desenvolvidoLabel.Location = new System.Drawing.Point(13, 10);
            this.desenvolvidoLabel.Name = "desenvolvidoLabel";
            this.desenvolvidoLabel.Size = new System.Drawing.Size(90, 13);
            this.desenvolvidoLabel.TabIndex = 0;
            this.desenvolvidoLabel.Text = "Desenvolvido por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "2024/25";
            // 
            // anoLectivoLabel
            // 
            this.anoLectivoLabel.AutoSize = true;
            this.anoLectivoLabel.Location = new System.Drawing.Point(327, 9);
            this.anoLectivoLabel.Name = "anoLectivoLabel";
            this.anoLectivoLabel.Size = new System.Drawing.Size(60, 13);
            this.anoLectivoLabel.TabIndex = 3;
            this.anoLectivoLabel.Text = "Ano lectivo";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 174);
            this.Controls.Add(this.anoLectivoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desenvolvidoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.aboutTextBox);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre *";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label desenvolvidoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label anoLectivoLabel;
    }
}