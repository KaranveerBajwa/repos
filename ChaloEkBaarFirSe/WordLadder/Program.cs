using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLadder
{
	class Program
	{
		static void Main(string[] args)
		{
			string beginWord = "hit";
			string endWord = "cog";
			string[] words = { "hot", "dot", "dog", "lot", "log", "cog", "ait" };
			List<string> wordsList = words.ToList();
			var count = LadderLength(beginWord, endWord, wordsList);
			Console.WriteLine(count);
			Console.Read();
		}

		//https://leetcode.com/problems/word-ladder/
		public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
		{
			// convert list to hashset
			HashSet<string> dict = new HashSet<string>(wordList);
			Dictionary<string, List<string>> resList = new Dictionary<string, List<string>>();
			Queue<string> queue = new Queue<string>();
			int count = 0;
			queue.Enqueue(beginWord);
			while (queue.Count > 0)
			{
				count = count + 1;
				int queueSize = queue.Count;
				for (int i = 0; i < queueSize; i++)
				{
					char[] s = queue.Dequeue().ToCharArray();
					for(int j =0; j < s.Length; j++)
					{
						char temp = s[j];
						for (char c = 'a'; c <= 'z'; c++)
						{
							s[j] = c;
							string res = new string(s);
							if (dict.Contains(res))
							{
								if (string.Equals(endWord, res))
								{
									return count;
								}
								if (count == 1 && !resList.ContainsKey(res))
									resList.Add(res, new List<string>());
								
								queue.Enqueue(res);
								dict.Remove(res);
							}
						}
						s[j] = temp;	
					}
					}
				}

			return 0;
			}

		}
	}
