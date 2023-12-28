using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderFolder
{
	internal abstract class Engine
	{
		public virtual string printMe() => GetType().Name;
	}
	internal class BMW:Engine
	{
	}
	internal class G_Motors:Engine
	{
	}
}
