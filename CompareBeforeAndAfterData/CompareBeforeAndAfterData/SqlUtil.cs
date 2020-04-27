using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareBeforeAndAfterData
{
	public static class SqlUtil
	{
		public static DataTable GetDataTable(string sql, SqlConnection sqlConnection)
		{
			using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
			using (DataSet dataSet = new DataSet())
			using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
			{
				adapter.SelectCommand.CommandTimeout = 5000;
				adapter.Fill(dataSet);
				return dataSet?.Tables?[0];
			}
		}
		public static DataTable GetDataTable(string sql, string sqlConnection)
		{
			DataTable dt = new DataTable();
			using (SqlConnection conn = new SqlConnection(sqlConnection))
			{
				conn.Open();
				{
					dt = GetDataTable(sql, conn);
				}
				conn.Close();
				conn.Dispose();
			}
			return dt;
		}
	}
}
