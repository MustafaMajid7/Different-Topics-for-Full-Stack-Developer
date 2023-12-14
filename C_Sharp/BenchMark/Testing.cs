using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace BenchMark
{
	public class Testing
	{
		[Benchmark]
		public void test1()
		{
			object x = "mostafa";
			switch (x)
			{
				case int intValue:
                    Console.WriteLine(intValue);
					break;

				case DateTime dateValue:
					Console.WriteLine(dateValue);
					break;


				case double doubleValue:
					Console.WriteLine(doubleValue);
					break;

				default:
					Console.WriteLine(x.ToString());
					break;
			}
		}
		[Benchmark]
		public void test2()
		{
			object x = "mostafa";
			if (x == typeof(int))
			{
				if (int.TryParse(x.ToString(), out var intValue))
				{
                    Console.WriteLine(intValue);
                }
			}

			else if (x == typeof(DateTime))
			{
				if (DateTime.TryParse(x.ToString(), out var DateTimeValue))
				{
					Console.WriteLine(DateTimeValue);
				}
			}
			else if (x == typeof(Double))
			{
				if (Double.TryParse(x.ToString(), out var doubleValue))
				{
                    Console.WriteLine(doubleValue);
                }
			}
			else
			{
				Console.WriteLine(x.ToString());
			}
		}
	}
}
