using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsMerge
{
	class Program
	{
		static void Main(string[] args)
		{
			IList<IList<string>> accounts = new List<IList<string>>();
			accounts.Add(new List<string>(new string[] { "John", "johnsmith@mail.com", "john00@mail.com" }));
			accounts.Add(new List<string>(new string[] { "John", "johnnybravo@mail.com" }));
			accounts.Add(new List<string>(new string[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" }));
			accounts.Add(new List<string>(new string[] { "Mary", "mary@mail.com" }) );
			Dictionary<string, HashSet<string>> g = new Dictionary<string, HashSet<string>>();
			Dictionary<string, string> emailToName = new Dictionary<string, string>();
			HashSet<string> visited = new HashSet<string>();
			List<List<string>> result = new List<List<string>>();
			BuildGraph(accounts, g, emailToName);
			foreach (string eMail in emailToName.Keys)
			{
				if (!visited.Contains(eMail))
				{
					List<string> list = new List<string>();
					list.Add(eMail);
					visited.Add(eMail);
					dfs(g,list,eMail,visited);
					list.Sort();
					list.Insert(0, emailToName[eMail]);
					result.Add(list);
				}					
			}
			foreach (List<string> l in result)
			{
				foreach (string s in l)
				{
					Console.Write(s + " ");
				}
				Console.WriteLine();
			}


//Output: [["John", 'john00@mail.com', 'john_newyork@mail.com', 'johnsmith@mail.com'],  ["John", "johnnybravo@mail.com"], ["Mary", "mary@mail.com"]]
		}

		//public IList<IList<string>> AccountsMerge(List<List<string>> accounts)
		//{

		//	Dictionary<string, HashSet<string>> g = new Dictionary<string, HashSet<string>>();
		//	Dictionary<string, string> emailToName = new Dictionary<string, string>();
		//	HashSet<string> visited = new HashSet<string>();
		//	List<IList<string>> result = new List<IList<string>>();
		//	BuildGraph(accounts, g, emailToName);
		//	foreach (string eMail in emailToName.Keys)
		//	{
		//		if (!visited.Contains(eMail))
		//		{
		//			List<string> list = new List<string>();
		//			list.Add(eMail);
		//			visited.Add(eMail);
		//			dfs(g, list, eMail, visited);
		//			list.Sort();
		//			list.Insert(0, emailToName[eMail]);
		//			result.Add(list);
		//		}
		//	}
		//	return result;
		//}

			static void BuildGraph(IList<IList<string>> accounts, Dictionary<string, HashSet<string>> g, Dictionary<string, string> emailToName)
		{
			foreach (var a in accounts)
			{
				string name = a[0];
				{
					for (int i = 1; i < a.Count; i++)
					{
						string eMail = a[i];
						if(!emailToName.ContainsKey(eMail))
							emailToName.Add(eMail, name);
						if (!g.ContainsKey(eMail))
							g.Add(eMail, new HashSet<string>());
						if (i == 1) continue; // its the first email
						string prev = a[i - 1];
						g[prev].Add(eMail);
						g[eMail].Add(prev);
					}
				}			
			}		
		}

		static void dfs(Dictionary<string, HashSet<string>> g, List<string> list, string eMail, HashSet<string> visited)
		{
			if (g == null || g.Count == 0) return;
			foreach (string neighbor in g[eMail])
			{
				if (!visited.Contains(neighbor))
				{
					visited.Add(neighbor);
					list.Add(neighbor);
					dfs(g, list, neighbor, visited);
				}
			}
			}
			}
		}
	
