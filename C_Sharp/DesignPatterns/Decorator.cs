using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	internal abstract class Decorator
	{

        public Decorator decorator { get; set; }

		private double cost;
        public string Name { get; set; }
        public Decorator(Decorator decorator,double Cost,string Name)
        {
            this.decorator = decorator;
			cost = Cost;
			this.Name = Name;
		}
		public double getCost()
		{
            if (decorator is null)
				return cost ;
			return cost + decorator.getCost();
			
		}
        public virtual string mycost()
        {
			//string x = $"the totol price is {getCost()}\n";

			return decorator?.mycost() + $"Cost of {Name} is {cost:F2}$\n" /*+ x*/;
        }
    }
    internal class Cream : Decorator
    {
        public Cream(Decorator decorator)
                : base(decorator, 3.33, "Cream") {}

	}
	internal class Milk : Decorator
	{
		public Milk(Decorator decorator)
				: base(decorator, 2.6, "Milk") { }

	}
	internal class Choclate : Decorator
	{
		public Choclate(Decorator decorator)
				: base(decorator, 5.2, "Choclate") { }

	}
	internal class Cafe : Decorator
	{
		public Cafe() : base(null, 2.0d, "Black Coffee")
		{
		}
	}
	//internal class Cafe
	//{
	//	public double price=2.0d;
	//	public double TotalCost { get=> price + Decorators?.Cost ??0;
	//		set => price = value; }
	//	public string description()
	//	{
	//		return Decorators.mycost();
	//	}
	//}
	internal class additions : List<Decorator>
	{
		internal void addDecorator(Decorator decorator) => Add(decorator);
		internal void printAllAdditions()
		{
			ForEach(x=>Console.WriteLine(x.mycost()));
		}
	}

}
