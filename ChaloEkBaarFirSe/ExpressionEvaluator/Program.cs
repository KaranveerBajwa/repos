using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEvaluator
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "1+2+(3-4)";
			var result = Evaluate(s);
		}

		public static int Evaluate(string s)
		{
			Stack<char> operators = new Stack<char>();
			Stack<int> operands = new Stack<int>();
			foreach (char ch in s)
			{
				if (Char.IsDigit(ch))
					operands.Push(ch - '0');
				else if (IsOperator(ch))
				{

					while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(ch))
					{
						Process(operators, operands);
					}
					operators.Push(ch);
				}
				else if (ch == '(')
					operators.Push(ch);
				else if (ch == ')')
				{
					while (operators.Peek() != '(')
					{
						Process(operators, operands);
					}
					operators.Pop();
				}

			}
			while (operators.Count > 0)
				Process(operators, operands);
			return operands.Pop();
		}

		static void Process(Stack<char> operators, Stack<int> operands)
		{
			int var1 = operands.Pop();
			int var2 = operands.Pop();
			char op = operators.Pop();
			switch (op)
			{
				case '+':
					operands.Push(var2 + var1);
					break;
				case '-':
					operands.Push(var2 - var1);
					break;
				case '/':
					operands.Push(var2 / var1);
					break;
				case '*':
					operands.Push(var2 * var1);
					break;			
			}
		
		}


		public static bool IsOperator(char ch)
		{
			HashSet<char> hs = new HashSet<char>();
			hs.Add('+');
			hs.Add('-');
			hs.Add('/');
			hs.Add('*');
			if (hs.Contains(ch))
				return true;
			else
				return false;
		}

		public static int Precedence(char ch)
		{
			switch (ch)
			{
				case '+':
				case '-':
					return 2;
				case '*':
				case '/':
					return 1;
				case '(':
					return 0;
				default:
					throw new Exception("Invaid characters");
			}
		
		}

	}
}
