using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
	internal interface ICalculator
	{
		double Multiply(double x, double y);
	}
	internal class Calculator
	{
		private readonly ICalculator calculator;

		public Calculator(ICalculator calculator)
        {
			this.calculator = calculator;
		}
        public double Multiply(double x, double y)
		{
			return calculator.Multiply(x, y);
		}
	}
}
