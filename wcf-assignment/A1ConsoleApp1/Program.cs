using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			ServiceReference8.Service1Client client = new ServiceReference8.Service1Client();
			string choice="";
			int n1,n2, n3;
			bool isPrime=true;
			string s1,s2,s3;
			char[] c1;
			while (!choice.Equals("6"))
			{
				Console.WriteLine("WCF Assignment 1 \r\n");
				Console.WriteLine("1. Prime number \r\n" +
								"2. Sum of digits  \r\n" +
								"3. Reverse a string  \r\n" +
								"4. Print HTML tags  \r\n" +
								"5. Sort 5 numbers  \r\n" +
								"6. Exit \r\n");
				Console.WriteLine("Enter your choice: _");
				choice=Console.ReadLine();
				switch (choice)
				{
					case "1":
						//PrimeNum
						Console.WriteLine("Enter the Number to check Prime: ");
						n1 = int.Parse(Console.ReadLine());
						isPrime = client.PrimeNum(n1);
						if (isPrime)
						{
							Console.WriteLine(n1+" is a prime number");
						}
						else {
							Console.WriteLine(n1+ " is not a prime number");

						}
						break;

					case "2":
						//SumDigits
						Console.WriteLine("Enter a positive integer: ");
						n1 = int.Parse(Console.ReadLine());
						n2 = client.SumDigits(n1);
						Console.WriteLine("sum is "+ n2);
						break;

					case "3":
						//ReverseString
						Console.WriteLine("Enter a string: ");
						s1 = Console.ReadLine();
						c1 = client.ReverseString(s1);
						Console.WriteLine(c1);
						break;

					case "4":
						//PrintHTMLTag
						Console.WriteLine("Enter a HTML Tag Name, e.g.:h1");
						s1 = Console.ReadLine();
						Console.WriteLine("Enter data");
						s2 = Console.ReadLine();
						s3 = client.PrintHTMLTag(s1,s2);
						Console.WriteLine(s3);
						break;

					case "5":
						//Sort5Num
						Console.WriteLine("Select a Sort type(Ascending/Descending):");
						s1 = Console.ReadLine();

						Console.WriteLine("Enter 5 numbers separated by commas(,):");
						s2 = Console.ReadLine();
						s3 = client.Sort5Num(s1, s2);
						Console.WriteLine(s3);
						break;

					case "6":
						Environment.Exit(1);
						break;
				}
			}
			Console.ReadLine();

		}
	}
}
