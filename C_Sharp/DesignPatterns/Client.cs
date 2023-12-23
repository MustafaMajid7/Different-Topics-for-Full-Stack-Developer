using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;

namespace DesignPatterns
{
	internal class Client
	{
		private readonly FactoryMethod factory;
        public Product Product { get; set; }

        public Client(FactoryMethod factory)
        {
			this.factory = factory;
		}
		public void MakeOrder(int x)
		{
			Product = factory.createProduct(x);
		}
		public string ShowMyOrder()
		{
			if (Product is Food p)
				return p.displayMe();
			else if (Product is Beverage d)
				return d.displayMe();
			else
				return "No product is ordered yet";
		}
	}
}
