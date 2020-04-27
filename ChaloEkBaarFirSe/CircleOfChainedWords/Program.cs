using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleOfChainedWords
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = { "apple", "eggs", "snack","karat","tuna"};
			var res = ChainedWords(words);
		}


		static bool ChainedWords(string[] words)
		{
			HashSet<string> visited = new HashSet<string>();
			Dictionary<char, List<string>> dict= new Dictionary<char, List<string>>();

			foreach (var word in words)
			{
				if (!dict.ContainsKey(word[0]))
				{
					dict.Add(word[0], new List<string>());
				}
				dict[word[0]].Add(word);
			}

			return IsCycleDFS(dict, words[0], words[0],dict.Count, visited);
		}

		static bool IsCycleDFS(Dictionary<char, List<string>> dict, string currentWord, string startWord,int count, HashSet<string> visited)
		{
			if (count == 1)
			{
				if (startWord[0] == currentWord[currentWord.Length - 1])  
					return true;
			}
			visited.Add(currentWord);
			foreach (string neighbor in dict[currentWord[currentWord.Length -1]]) 
			{
				if (!visited.Contains(neighbor))
				{
				 return	IsCycleDFS(dict, neighbor, startWord, count - 1, visited);
				}
			}
			//visited.Remove(currentWord);
			return false;
		}
 

	}
}
