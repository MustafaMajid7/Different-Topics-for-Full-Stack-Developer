using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
	internal abstract class FactoryMethod
	{
		public abstract Product createProduct(int type);
	}
	internal class ProductFactory: FactoryMethod
	{
		public override Product createProduct(int type)
		{
			if (type == 1)
				return new Pizza();
			else
				return new Sandiwich();
		}
	}
	internal class BeverageFactory : FactoryMethod
	{
		public override Product createProduct(int type)
		{
			if (type == 1)
				return new Tea();
			else
				return new Soda();
		}
	}
}
