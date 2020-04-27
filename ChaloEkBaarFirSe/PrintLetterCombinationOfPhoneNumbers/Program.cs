using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLetterCombinationOfPhoneNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string digits = "0231";
			var res = LetterCombinations(digits);

			foreach (string s in res)
			{
				Console.WriteLine(s);
			}

			PrintPhoneInWords(digits);
			Console.ReadKey();
		}

		public static IList<string> LetterCombinations(string digits)
		{
			if (digits == null || digits.Length == 0)
				return new List<string>();
			int[] nums = new int[digits.Length];
			for (int i = 0; i < digits.Length;i++)
			{
				nums[i] = Convert.ToInt32(digits[i] - '0');
			}
			char[] buffer = new char[digits.Length];
			IList<string> list = new List<string>();
			LetterCombinationsHelper(nums, buffer, 0, 0, list);
			return list;
		}

		public static void LetterCombinationsHelper(int[] digits, char[] buffer, int curIndex, int bufferIndex, IList<string> result)
		{
			if (bufferIndex == buffer.Length || curIndex == digits.Length)
			{
				result.Add(new string(buffer));
				return;
			}
			char[] chars = PhoneDigitMapping(digits[curIndex]);
			if (chars.Length == 0)
				LetterCombinationsHelper(digits, buffer, curIndex + 1, bufferIndex, result);
			foreach (char c in chars)
			{
				buffer[bufferIndex] = c;
				LetterCombinationsHelper(digits, buffer, curIndex + 1, bufferIndex + 1, result);
			}

		}

		static char[] PhoneDigitMapping(int i)
		{
			string s = "";
			switch (i)
			{
				case 2:
					s="abc";
					break;
				case 3:
					s = "def";
					break;
				case 4:
					s = "ghi";
					break;
				case 5:
					s = "jkl";
					break;
				case 6:
					s = "mno";
					break;
				case 7:
					s = "pqrs";
					break;
				case 8:
					s = "tuv";
					break;
				case 9:
					s = "wxyz";
					break;
			}
			return s.ToCharArray();
		}

		static char[] PhoneDigitMapping(char i)
		{
			string s = "";
			switch (i)
			{
				case '2':
					s = "abc";
					break;
				case '3':
					s = "def";
					break;
				case '4':
					s = "ghi";
					break;
				case '5':
					s = "jkl";
					break;
				case '6':
					s = "mno";
					break;
				case '7':
					s = "pqrs";
					break;
				case '8':
					s = "tuv";
					break;
				case '9':
					s = "wxyz";
					break;
			}
			return s.ToCharArray();
		}


		public static void PrintPhoneInWords(string s)
		{
			char[] buffer = new char[s.Length];
			PrintPhoneToWords(s, buffer, 0, 0);
		}

		public static void PrintPhoneToWords(string s, char[] buffer, int sIndex, int bufferIndex)
		{
			if (bufferIndex == buffer.Length || sIndex == s.Length)
			{
				PrintBuffer(buffer, bufferIndex);
				return;
			}

			char[] letters = PhoneDigitMapping(s[sIndex]);
			if (letters.Length == 0)
				PrintPhoneToWords(s, buffer, sIndex + 1, bufferIndex);

			foreach (char c in letters)
			{
				buffer[bufferIndex] = c;
				PrintPhoneToWords(s, buffer, sIndex + 1, bufferIndex + 1);
			}		
		}
		static void PrintBuffer(char[] buffer, int bufferIndex)
		{
			for (int i = 0; i < bufferIndex; i++)
			{
				Console.Write(buffer[i] + " ");
			}
			Console.WriteLine();
		}
	
	}

}
