using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DB_Helper
{
	public class DBOracle_Helper
	{
		string dbIp = "222.237.134.74";
		string dbName = "ORA7";
		string dbId = "EDU";
		string dbPw = "edu1234";

		public DBOracle_Helper()
		{
		}

		public DBOracle_Helper(string _dbip, string _dbName, string _dbId, string _dbPw)
		{
			dbIp = _dbip;
			dbName = _dbName;
			dbId = _dbId;
			dbPw = _dbPw;
		}
		//==========================================================================================================
		public DataTable GetData(string query)
		{
			OracleConnection conn = GetConnection();

			DataTable ret = new DataTable(); //DataTable 생성

			try
			{
				OracleCommand cmd = new OracleCommand();
				cmd.Connection = conn;
				cmd.CommandText = query;
				conn.Open();

				OracleDataAdapter da = new OracleDataAdapter(cmd);
				da.Fill(ret);

				conn.Close();
				da.Dispose();
			}
			catch (Exception ex)
			{
				ret = null;
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
				conn.Dispose();
			}

			return ret;
		}
		//==========================================================================================================
		public int SetData(string query)
		{
			int ret = 0;

			OracleConnection conn = GetConnection();

			try
			{
				OracleCommand cmd = new OracleCommand();
				cmd.Connection = conn;
				cmd.CommandText = query;
				conn.Open();
				ret = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				ret = -1;
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
				conn.Dispose();
			}

			return ret;
		}
		//===============================================================================================================

		private OracleConnection GetConnection()
		{
			return new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName}))); User ID={dbId};Password={dbPw};Connection Timeout=30;");
		}
	}
}
