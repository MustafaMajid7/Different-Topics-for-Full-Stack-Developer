using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDP
{
	public class Calculator
	{
		private List<ICommand> commands;
        public Calculator()
        {
            commands = new List<ICommand>();
        }
        public double Number { get; set; } = default;
		public void add(double number)
		{
			Number += number;
			commands.Add(new Add(this,number));
		}
		public void subtract(double number)
		{
			Number -= number;
			commands.Add(new Subtract(this, number));
		}
		public void multiply(double number)
		{
			Number *= number;
			commands.Add(new Multiply(this, number));
		}
		public void divide(double number)
		{
			Number /= number;
			commands.Add(new Division(this, number));
		}
		public void ShowHistory()
		{
            foreach (var item in commands)
                Console.WriteLine(item.ToString());
        }
		public void Undo()
		{
			commands.LastOrDefault()?.unexecute(commands.LastOrDefault().Number);
			commands.RemoveAt(commands.Count - 1);
		}

	}
}
