using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
	internal class BankAccount
	{
		private readonly State state;
		public BankAccount(State state)
		{
			this.state = state;
		}
		public override string ToString() => $"{state.GetType().Name}";
	}
}
