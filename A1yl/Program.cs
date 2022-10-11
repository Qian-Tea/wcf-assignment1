/*
 * Yifen Lin
 * Assignment 1
 * Oct 11, 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A1yl
{
	class Program
	{
		static void Main(string[] args)
		{
			printMenu();

			for (; ; )
			{
				string input = Console.ReadLine();
				Regex regInt = new Regex("^[1-6]$");

				if (regInt.IsMatch(input))
				{
					// go to the 5 active
					Console.WriteLine("you select " + input);
					switch (input)
					{
						case "1":
							PrimeNum();
							break;
						case "2":
							SumDigits();
							break;
						case "3":
							ReverseString();
							break;
						case "4":
							PrintHTMLTag();
							break;
						case "5":
							Sort5Num();
							break;
						case "6":
							Exit();
							break;
					}
				}
				else
				{
					//clean console
					Console.Clear();
					
					Console.WriteLine("Please enter a valid integer between 1-6\r\n");
					printMenu();
				}
			}

			Console.ReadKey();
		}

		//display the menu
		public static void printMenu()
		{
			//Console.Clear();
			Console.WriteLine("WCF Assignment 1 \r\n");
			Console.WriteLine("1. Prime number \r\n" +
							"2. Sum of digits  \r\n" +
							"3. Reverse a string  \r\n" +
							"4. Print HTML tags  \r\n" +
							"5. Sort 5 numbers  \r\n" +
							"6. Exit \r\n");
			Console.WriteLine("Enter your choice: _");
		}

		//1. Prime Number
		public static void PrimeNum()
		{
			int checkNum= 0;
			bool isPrime=true;
			// get intput number
			Console.Write("Enter the Number to check Prime: ");
			checkNum = int.Parse(Console.ReadLine());

			for (int i = 2; i <= checkNum / 2; i++)
			{
				if (checkNum % i == 0)
				{
					Console.Write("not prime number");
					isPrime = false;
					break;
				}
			}
			if (isPrime)
				Console.Write("prime number");
		}

		//2. Sum of Digits
		public static void SumDigits()
		{
			int num, sum = 0;
			Console.Write("Enter a positive integer: ");
			num = int.Parse(Console.ReadLine());
			while (num > 0)
			{
				sum += num % 10;
				num /= 10;
			}
			Console.Write(sum);
		}

		//3. Reverse a string
		public static void ReverseString()
		{
			string inputStr;
			Console.Write("Enter a string: ");
			inputStr = Console.ReadLine();
			char[] charArray = inputStr.ToCharArray();
			Array.Reverse(charArray);
			Console.Write(charArray);
		}

		//4. Print HTML tags.
		public static void PrintHTMLTag()
		{
			Console.WriteLine("Enter a HTML Tag Name, e.g.:h1");
			string tagName = Console.ReadLine();

			Console.WriteLine("Enter data");
			string htmlData = Console.ReadLine();

			Console.WriteLine("<" + tagName + ">" + htmlData + "</" + tagName + ">");

		}

		//5. Sort 5 numbers
		public static void Sort5Num()
		{
			Console.WriteLine("Select a Sort type(Ascending/Descending):");
			string sortType = Console.ReadLine();

			Console.WriteLine("Enter 5 numbers separated by commas(,):");
			string dataWithComma = Console.ReadLine();

			List<int> sortNumbers = new List<int>();
			sortNumbers = dataWithComma.Split(',').Select(int.Parse).ToList();

			if (sortType == "Ascending")
			{
				sortNumbers.Sort();
				Console.WriteLine(string.Join(",", sortNumbers));
			}
			if (sortType == "Descending")
			{
				sortNumbers.Sort();
				sortNumbers.Reverse();
				Console.WriteLine(string.Join(",", sortNumbers));
			}

		}

		//6.Exit
		public static void Exit()
		{
			Environment.Exit(1);
		}
	}
}
