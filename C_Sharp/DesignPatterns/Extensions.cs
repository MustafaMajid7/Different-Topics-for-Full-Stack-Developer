using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	internal static class Extensions
	{
		public static bool In<T>(this T val, params T[] vals) => vals.Contains(val);
	}
}
