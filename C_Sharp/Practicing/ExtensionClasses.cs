using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
	internal static class ExtensionClasses
	{
		public static bool isNullOrEmpty(this string s)
		{
			return s is null or "" ? true : false;
		}
		public static string? ConvertToCamelCase(this String str)
		{
			var sb = new StringBuilder();
			try
			{
				if (str.Split(" ").Length == 1)
					return char.ToUpper(str[0]) + str.Substring(1);

				foreach (var item in str.Trim().Split(" "))
					if (!string.IsNullOrEmpty(item))
						sb.Append(char.ToUpper(item[0]) + item.Substring(1));
				return sb.ToString();
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
