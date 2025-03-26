namespace LoginSystem
{
    partial class FormInicial
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorProvider1Login = new System.Windows.Forms.ErrorProvider(this.components);
            this.loginStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showUsernameLabel = new System.Windows.Forms.Label();
            this.showPasswordLabel = new System.Windows.Forms.Label();
            this.inputUsernameLabel = new System.Windows.Forms.Label();
            this.inputPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Login)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(113, 106);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username: *";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(116, 140);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password: *";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(211, 106);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(170, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(211, 137);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(170, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(297, 165);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 35);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login *";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // errorProvider1Login
            // 
            this.errorProvider1Login.ContainerControl = this;
            // 
            // loginStatusLabel
            // 
            this.loginStatusLabel.AutoSize = true;
            this.loginStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStatusLabel.Location = new System.Drawing.Point(471, 58);
            this.loginStatusLabel.Name = "loginStatusLabel";
            this.loginStatusLabel.Size = new System.Drawing.Size(134, 25);
            this.loginStatusLabel.TabIndex = 5;
            this.loginStatusLabel.Text = "Login Status *";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // showUsernameLabel
            // 
            this.showUsernameLabel.AutoSize = true;
            this.showUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsernameLabel.Location = new System.Drawing.Point(476, 105);
            this.showUsernameLabel.Name = "showUsernameLabel";
            this.showUsernameLabel.Size = new System.Drawing.Size(92, 16);
            this.showUsernameLabel.TabIndex = 6;
            this.showUsernameLabel.Text = "Username: *";
            // 
            // showPasswordLabel
            // 
            this.showPasswordLabel.AutoSize = true;
            this.showPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordLabel.Location = new System.Drawing.Point(473, 137);
            this.showPasswordLabel.Name = "showPasswordLabel";
            this.showPasswordLabel.Size = new System.Drawing.Size(89, 16);
            this.showPasswordLabel.TabIndex = 7;
            this.showPasswordLabel.Text = "Password: *";
            // 
            // inputUsernameLabel
            // 
            this.inputUsernameLabel.AutoSize = true;
            this.inputUsernameLabel.Location = new System.Drawing.Point(574, 105);
            this.inputUsernameLabel.Name = "inputUsernameLabel";
            this.inputUsernameLabel.Size = new System.Drawing.Size(67, 16);
            this.inputUsernameLabel.TabIndex = 8;
            this.inputUsernameLabel.Text = "User input";
            // 
            // inputPasswordLabel
            // 
            this.inputPasswordLabel.AutoSize = true;
            this.inputPasswordLabel.Location = new System.Drawing.Point(574, 137);
            this.inputPasswordLabel.Name = "inputPasswordLabel";
            this.inputPasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.inputPasswordLabel.TabIndex = 9;
            this.inputPasswordLabel.Text = "User input";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPasswordLabel);
            this.Controls.Add(this.inputUsernameLabel);
            this.Controls.Add(this.showPasswordLabel);
            this.Controls.Add(this.showUsernameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginStatusLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "FormInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ErrorProvider errorProvider1Login;
        private System.Windows.Forms.Label loginStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showUsernameLabel;
        private System.Windows.Forms.Label showPasswordLabel;
        private System.Windows.Forms.Label inputPasswordLabel;
        private System.Windows.Forms.Label inputUsernameLabel;
    }
}

