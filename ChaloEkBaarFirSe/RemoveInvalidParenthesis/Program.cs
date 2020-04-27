using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveInvalidParenthesis
{
 
	class Program
	{
		static int minCount = Int32.MaxValue;
		static void Main(string[] args)
		{
			string s = ")("; 
			var res = RemoveInvalidParens(s);
			foreach (var l in res)
			{
				Console.WriteLine(l);
			}
			Console.ReadKey();
		}

		public static  IList<string> RemoveInvalidParens(string s)
		{ 
			HashSet<string> validExpressions = new HashSet<string>();
			//int minCount = Int32.MaxValue;
			StringBuilder sb = new StringBuilder();
			RemoveInvalidParensHelper(s, sb, 0, 0, 0,  0,  validExpressions);
 
			return validExpressions.ToList();
		}

		static void RemoveInvalidParensHelper(string s, StringBuilder sb,
			int lc, int rc, int curIndex, int removedCount, HashSet<string> validExpressions)
		{
			if (curIndex == s.Length)
			{
				if ( lc == rc)
				{
					if (removedCount <= minCount)
					{
						string possibleExpression = sb.ToString();
						if (removedCount < minCount)
						{ 			 
							validExpressions.Clear();
							minCount = removedCount;
						}
						validExpressions.Add(possibleExpression);
					}
				}
 
			}

			else
			{
				if (s[curIndex] != '(' && s[curIndex] != ')')
				{
					sb.Append(s[curIndex]);
					RemoveInvalidParensHelper(s, sb, lc, rc, curIndex + 1,  removedCount, validExpressions);
					sb.Remove(sb.Length - 1, 1);
				}
				else
				{
					RemoveInvalidParensHelper(s, sb, lc, rc, curIndex + 1,   removedCount + 1, validExpressions);
					sb.Append(s[curIndex]);
					if (s[curIndex] == '(')
					{
						RemoveInvalidParensHelper(s, sb, lc + 1, rc, curIndex + 1 , removedCount, validExpressions);
					}
					else
					{
						if (rc < lc)
							RemoveInvalidParensHelper(s, sb, lc, rc + 1, curIndex + 1,   removedCount, validExpressions);
					}
					sb.Remove(sb.Length - 1, 1);
				}
			}
			}
	

	}


}
