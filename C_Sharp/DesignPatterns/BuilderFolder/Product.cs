using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderFolder
{
	internal abstract class Product
	{
		public Wheels Wheels { get; set; }
		public Engine Engine { get; set; }
		public Light Light { get; set; }
	}
}
