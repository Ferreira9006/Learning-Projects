using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Account
    {
        #region Methods

        public static DataTable GetAccounts()
        {
            DataTable dataTable = null;

            try
            {
                string connectionString = Properties.Settings.Default.ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [Account]", connection);
                command.CommandType = CommandType.Text;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return dataTable;
        }
        
        #endregion
    }
}
