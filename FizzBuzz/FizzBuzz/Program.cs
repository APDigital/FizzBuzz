using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input your maximum value");
			int input = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input what you want to divide by");
			int divide = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input your replacement string");
			string userMessage = Console.ReadLine();
			string blank = "";

			IEnumerable<int> range = Enumerable.Range(1, input);
			foreach (int num in range)
			{
				if (num % divide == 0)
				{
					blank = userMessage;
					Console.WriteLine(userMessage);
				}
				else if (num % 15 == 0)
				{

					if (num % 17 == 0)
					{
						blank = "BuzzFizz";
						Console.WriteLine(blank);
					}

					else
					{
						blank = "FizzBuzz";
						Console.WriteLine(blank);
					}

				}

				else if (num % 13 == 0)
				{
					string fezz = "Fezz";
					if (num % 7 == 0)
					{
						Console.WriteLine(fezz + blank);
					}
					else if (num % 5 == 0)
					{
						Console.WriteLine(fezz + blank);
					}
					else if (num % 3 == 0)
					{
						Console.WriteLine(fezz + blank);
					}
					else if (num % 17 == 0)
					{
						Console.WriteLine(blank + fezz);
					}
					else
					{
						Console.WriteLine(fezz);
					}

				}

				else if (num % 11 == 0)
				{
					blank = "Bong";
					Console.WriteLine(blank);
				}
				else if (num % 7 == 0)
				{
					string bang = "Bang";
					if (num % 5 == 0)
					{
						Console.WriteLine(blank + bang);
					}
					else if (num % 3 == 0)
					{
						Console.WriteLine(blank + bang);
					}
					else if (num % 17 == 0)
					{
						Console.WriteLine(bang + blank);
					}
					else
					{
						Console.WriteLine(bang);
					}

				}

				else if (num % 5 == 0)
				{
					blank = "Buzz";
					Console.WriteLine(blank);
				}

				else if (num % 3 == 0)
				{
					blank = "Fizz";
					Console.WriteLine(blank);
				}

				else
				{

					Console.WriteLine(num);
				}

				Console.ReadLine();
			}
		}
	}
}

