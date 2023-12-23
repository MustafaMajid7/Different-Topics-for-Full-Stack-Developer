using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
	internal class Beverage : Product
	{
		public virtual string Status { get; set; }
		public virtual string displayMe() => $"Status of {Name} is {Status}";
	}
	internal class Tea : Beverage
	{
		public Tea(string name = "Egyptian Tea", double price=.99, string status = "Hot")
		{
			Name = name;
			Price = price;
			Status = status;
		}
	}
	internal class Soda : Beverage
	{
		public Soda(string name = "Fanta", double price = 1.3, string status = "Cold")
		{
			Name = name;
			Price = price;
			Status = status;
		}
	}
}
