using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
	internal abstract class Food : Product
	{
        public virtual string Ingrediant { get; set; }
		public virtual string displayMe() => $"ingradients of {Name} is {Ingrediant}";
    }
	internal class Pizza : Food
	{
        public Pizza(string name="italy",double price=5.5,string ingradient = "Meat + moziralla")
        {
            Name = name;
            Price = price;
            Ingrediant = ingradient;
        }
    }
	internal class Sandiwich : Food
	{
		public Sandiwich(string name="Big Mac", double price=4.3, string ingradient="Meat with veges")
		{
			Name = name;
			Price = price;
			Ingrediant = ingradient;
		}
	}
}
