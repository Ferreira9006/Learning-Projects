using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Account
    {
        #region Constructors

        public Account()
        {
			this.username = string.Empty;
			this.password = string.Empty;
        }

		public Account(string username, string password)
		{
            this.username = username;
            this.password = password;
        }

        #endregion

        #region Properties

        private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

        #endregion

        #region Methods
        public void newAuth(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool checkAuth()
        {
            DataTable dataTable = DataLayer.Account.GetAccounts();

            foreach (DataRow row in dataTable.Rows)
            {
                // Sem o Trim() não funcionava. É importante verificar qual o tipo de dados que a DB esta a devolver para evitar problemas futuros.
                if (row["username"].ToString().Trim() == this.username && row["password"].ToString().Trim() == this.password)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

    }
}
