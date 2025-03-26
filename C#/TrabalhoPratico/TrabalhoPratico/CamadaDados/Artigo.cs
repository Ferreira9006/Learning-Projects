using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Artigo
    {
        #region Metodos

        public static bool GravarArtigo(int id, string descricao, float preco, DateTime dataValidade, int tipoArtigo, string estado, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("ArtigoGravar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Id", SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = id;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("descricao", System.Data.SqlDbType.NVarChar, 256);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = descricao;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("preco", System.Data.SqlDbType.Float);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = preco;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("DataValidade", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataValidade;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("TipoArtigo", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = tipoArtigo;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Estado", System.Data.SqlDbType.NVarChar, 50);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = estado;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }

        public static bool Eliminar(int id, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("ArtigoEliminar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Id", SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = id;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }

        public static DataTable ObterId(int id)
        {
            DataTable dataTable = null;

            try
            {
                string connectionString = Properties.Settings.Default.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ArtigoObter";

                SqlParameter sqlParameter = new SqlParameter("Id", SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = id;

                sqlCommand.Parameters.Add(sqlParameter);

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return dataTable;
        }

        public static DataTable ObterLista()
        {
            DataTable dataTable = null;
            try
            {
                string connectionString = Properties.Settings.Default.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ArtigoListar";

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
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
