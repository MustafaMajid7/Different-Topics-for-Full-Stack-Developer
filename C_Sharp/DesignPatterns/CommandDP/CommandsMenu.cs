using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDP
{
	public class CommandsMenu
	{
		private readonly Calculator calculator;

		public CommandsMenu(Calculator calculator)
        {
			this.calculator = calculator;
		}
        public void add(double number)=>
			calculator.add(number);
		public void subtract(double number) =>
			calculator.subtract(number);
		public void multiply(double number) =>
			calculator.multiply(number);
		public void divide(double number) =>
			calculator.divide(number);

	}
}
