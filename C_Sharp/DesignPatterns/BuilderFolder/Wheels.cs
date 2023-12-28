using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderFolder
{
	internal abstract class Wheels
	{
		public virtual string printMe() => GetType().Name;
	}
	internal class SmallWheels : Wheels
	{
	}
	internal class HighWheels : Wheels
	{
	}
}
