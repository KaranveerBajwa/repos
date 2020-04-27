using CompareBeforeAndAfterData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace TestBeforeAndAfter
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
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

		[TestMethod]
		public static void AssertDataTablesAreEqual(DataTable dt1, DataTable dt2)
		{
			AssertTablesHaveEqualRowNumbers(dt1, dt2);
			AssertTablesHaveEqualColNumbers(dt1, dt2);
			AssertTablesHaveEqualColNames(dt1, dt2);
			AssertTablesHaveEqualValues(dt1, dt2);
		}

		[TestMethod]
		public static void AssertTablesHaveEqualRowNumbers(DataTable dt1, DataTable dt2)
		{
			Assert.AreEqual(dt1.Rows.Count, dt2.Rows.Count);
		}

		[TestMethod]
		public static void AssertTablesHaveEqualColNumbers(DataTable dt1, DataTable dt2)
		{
			Assert.AreEqual(dt1.Columns.Count, dt2.Columns.Count);
		}

		[TestMethod]
		public static void AssertTablesHaveEqualColNames(DataTable dt1, DataTable dt2)
		{
			string[] columnNames1 = dt1.Columns.Cast<DataColumn>().Select(x => x.ColumnName).OrderBy(x => x).ToArray();
			string[] columnNames2 = dt2.Columns.Cast<DataColumn>().Select(x => x.ColumnName).OrderBy(x => x).ToArray();
			for (int i = 0; i < columnNames1.Length; i++)
			{
				Assert.AreEqual(columnNames1[i], columnNames2[i]);
			}
		}

		[TestMethod]
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
					Assert.AreEqual(oldVal, newVal);
				}
			}
		}
	}
}
