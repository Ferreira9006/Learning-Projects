using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BusinessLayer;
using LoginSystem.Properties;

namespace LoginSystem
{
    public partial class FormInicial : Form
    {
        #region Constructors

        public FormInicial()
        {
            InitializeComponent();

        }

        #endregion

        #region Methods

        private bool validData()
        {
            bool valid = true;

            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;

            errorProvider1Login.Clear();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                // Show error message
                errorProvider1Login.SetError(usernameTextBox, Resources.EMPTY_DATA_FIELDS_ERROR);
                return valid = false;
            }

            return valid;
        }

        private void Login()
        {
            try
            {
                if (validData())
                {
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    Account account = new Account();

                    account.newAuth(username, password);

                    this.inputUsernameLabel.Text = username;
                    this.inputPasswordLabel.Text = password;

                    if (account.checkAuth())
                    {
                        this.loginStatusLabel.Text = "Login successful!";
                        this.loginStatusLabel.ForeColor = Color.Green;
                        return;
                    }

                    this.loginStatusLabel.Text = "Login failed!";
                    loginStatusLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void InitResources()
        {
            this.usernameLabel.Text = Resources.USERNAME_LABEL;
            this.passwordLabel.Text = Resources.PASSWORD_LABEL;
            this.loginButton.Text = Resources.LOGIN_BUTTON;
            this.loginStatusLabel.Text = Resources.LOGIN_STATUS_LABEL;

            this.showUsernameLabel.Text = Resources.USERNAME_LABEL;
            this.showPasswordLabel.Text = Resources.PASSWORD_LABEL;

            this.inputUsernameLabel.Text = "";
            this.inputPasswordLabel.Text = "";
        }

        #endregion

        #region Events

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.InitResources();
        }

        #endregion
    }
}
