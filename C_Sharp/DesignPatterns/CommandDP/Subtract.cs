using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.CommandDP
{
	internal class Subtract : ICommand
	{
		private readonly Calculator calculator;
		public double Number { get; set; }

		public Subtract(Calculator calculator, double number)
		{
			this.calculator = calculator;
			Number = number;
		}
		public void execute(double number)
		{
			calculator.Number -= number;
		}

		public void unexecute(double number)
		{
			calculator.Number += number;
		}
		public override string ToString()
		{
			return $"-{Number}";
		}
	}
}
