using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareBeforeAndAfterData
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			var connectionString = txtConnectionStringOld.Text; // "Data Source = .; Integrated Security=SSPI;Initial Catalog=northwind_spp";
			string sql = "SELECT * FROM Categories";
			var dt1 = SqlUtil.GetDataTable(sql, connectionString);

			var connectionStringNew = txtConnectionStringNew.Text;
			string sqlNew = "SELECT * FROM categories1";
			var dt2 = SqlUtil.GetDataTable(sqlNew, connectionStringNew);
			AssertDataTablesAreEqual(dt1, dt2);
			MessageBox.Show("Comparision complete");
		}


		public static void AssertQueryResultsAreIdentical(string connstr, string query1, string query2, out long elapsedTime1, out long elapsedTime2)
		{
			elapsedTime1 = 0;
			elapsedTime2 = 0;

			Stopwatch sw1 = new Stopwatch();
			sw1.Start();
			DataTable dt1 = SqlUtil.GetDataTable(query1, connstr);
			sw1.Stop();
			elapsedTime1 = sw1.ElapsedTicks;

			Stopwatch sw2 = new Stopwatch();
			sw2.Start();
			DataTable dt2 = SqlUtil.GetDataTable(query2, connstr);
			sw2.Stop();
			elapsedTime2 = sw2.ElapsedTicks;

			AssertDataTablesAreEqual(dt1, dt2);
		}

		public static void AssertDataTablesAreEqual(DataTable dt1, DataTable dt2)
		{
			AssertTablesHaveEqualRowNumbers(dt1, dt2);
			AssertTablesHaveEqualColNumbers(dt1, dt2);
			AssertTablesHaveEqualColNames(dt1, dt2);
			AssertTablesHaveEqualValues(dt1, dt2);
		}
		public static void AssertTablesHaveEqualColNumbers(DataTable dt1, DataTable dt2)
		{
			Debug.Assert(dt1.Columns.Count == dt2.Columns.Count, "Column count do not match");
		}

		public static void AssertTablesHaveEqualRowNumbers(DataTable dt1, DataTable dt2)
		{
			Debug.Assert(dt1.Rows.Count == dt2.Rows.Count, "Both results have equal number of rows");
		}

		public static void AssertTablesHaveEqualColNames(DataTable dt1, DataTable dt2)
		{
			string[] columnNames1 = dt1.Columns.Cast<DataColumn>().Select(x => x.ColumnName).OrderBy(x => x).ToArray();
			string[] columnNames2 = dt2.Columns.Cast<DataColumn>().Select(x => x.ColumnName).OrderBy(x => x).ToArray();
			for (int i = 0; i < columnNames1.Length; i++)
			{
				Debug.Assert(string.Compare(columnNames1[i], columnNames2[i], true) == 0, "Column names do not match ,", columnNames1[i] + " ," + columnNames2[i]);
			}
		}

		public static void AssertTablesHaveEqualValues(DataTable dt1, DataTable dt2)
		{
			int nR = dt1.Rows.Count;
			int nC = dt2.Columns.Count;

			for (int r = 0; r < nR; r++)
			{
				for (int c = 0; c < nC; c++)
				{
					string oldVal = dt1.Rows[r][c].ToString();
					string newVal = dt2.Rows[r][c].ToString();
					Debug.Assert(string.Compare(oldVal, newVal, true) == 0, ("Old and new values do not match" + oldVal + " : " + newVal + " in row: " + r  + " and column :" + c), "Long Message");
				}

			}


		}
	}
}

