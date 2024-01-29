﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDP
{
	public class Multiply : ICommand
	{
		private readonly Calculator calculator;
		public double Number { get; set; }

		public Multiply(Calculator calculator, double number)
		{
			this.calculator = calculator;
			Number = number;
		}
		public void execute(double number)
		{
			calculator.Number *= number;
		}

		public void unexecute(double number)
		{
			calculator.Number /= number;
		}
		public override string ToString()
		{
			return $"*{Number}";
		}
	}
}
