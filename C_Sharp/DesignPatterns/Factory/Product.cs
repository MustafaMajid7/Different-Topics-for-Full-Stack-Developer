using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
	internal abstract class Product
	{
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
		public override string ToString()
		{
			return $"{Name,-10} for {Price:F2:C}";
		}
	}

}
