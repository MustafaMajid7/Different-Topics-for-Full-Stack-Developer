using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderFolder
{
	internal abstract class Light
	{
		public virtual string printMe() => GetType().Name;
	}
	internal class LowLights : Light
	{
	}
	internal class HighLights : Light
	{
	}
}
