using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleToCSharp
{
	public static class OracleDb
	{
		public static string ConnString;


		public static DataTable SelectData(OracleCommand command, OracleParameter[] parameters = null)
		{
			try
			{
				DataTable dataTable = new DataTable();

				using (OracleConnection connection = new OracleConnection())
				{
					connection.ConnectionString = ConnString;
					connection.Open();

					command.Connection = connection;

					if (parameters != null)
						command.Parameters.AddRange(parameters);

					OracleDataReader reader = command.ExecuteReader();
					dataTable.Load(reader);

					return dataTable;
				}
			}
			catch (OracleException e)
			{
				if (e.Message == @"ORA-12154: TNS:could not resolve the connect identifier specified")
					throw new ConnectException();
				else if (e.Message == "ORA-01017: invalid username/password; logon denied")
					throw new LogInException(); ;
				
				return null;
			}
		}

		public static bool InsertData(OracleCommand command, OracleParameter[] parameters)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(ConnString))
				{
					connection.Open();

					OracleCommand cmd = connection.CreateCommand();
					OracleTransaction transaction;

					transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

					cmd.Transaction = transaction;

					cmd.CommandText = command.CommandText;

					cmd.BindByName = true;
					cmd.Parameters.AddRange(parameters);

					int check = cmd.ExecuteNonQuery();
					transaction.Commit();

					if (check > 0)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			catch (OracleException)
			{
				throw;
				//Console.Write(e.Message);
				//return false;
			}
		}
	}
}

