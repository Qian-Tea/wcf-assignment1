using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services.Description;
using System.Web.UI.HtmlControls;

namespace wcf_assignment
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1
	{
		public bool PrimeNum(int n1)
		{
			bool isPrime = true;

			for (int i = 2; i <= n1 / 2; i++)
			{
				if (n1 % i == 0)
				{
					Console.Write("not prime number");
					isPrime = false;
					break;
				}
			}
			return isPrime;
		}
		public int SumDigits(int n1)
		{
			int n2=0 ;
			while (n1 > 0)
			{
				n2 += n1 % 10;
				n1 /= 10;
			}
			return n2;
		}

		public char[] ReverseString(string s1)
		{
			char[] s2 = s1.ToCharArray();
			Array.Reverse(s2);
			//string s3 = s2.ToString();
			return s2;
		}

		public string PrintHTMLTag(string s1, string s2)
		{
			string s3= "<" + s1 + ">" + s2 + "</" + s1 + ">";
			return s3;
		}



		public string Sort5Num(string s1,string s2)
		{
			List<int> s3 = new List<int>();
			 s3 = s2.Split(',').Select(int.Parse).ToList();
			string s4 = "";
			if (s1 == "Ascending")
			{
				s3.Sort();
				s4=string.Join(",", s3);
			}
			if (s1 == "Descending")
			{
				s3.Sort();
				s3.Reverse();
				s4 = string.Join(",", s3);
			}
			return s4;
		}

	}
}
