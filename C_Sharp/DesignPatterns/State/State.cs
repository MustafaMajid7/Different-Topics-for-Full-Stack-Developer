using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
	internal abstract class State
	{
        protected decimal Balance { get; set; }
		public abstract string makeLoan();
		public abstract string outDoorsMoney();
        public void credit(decimal amount)=> Balance += amount;
        public void debit(decimal amount)=> Balance -= amount;
	}
	internal class Red : State
	{
		public override string makeLoan() => "Can't Make Loan";

		public override string outDoorsMoney() => "Can't Accept money";
	}

	internal class Silver : State
	{
		public override string makeLoan() => "Make Loan until 20% beyond Balance";

		public override string outDoorsMoney() => "Accept money until 10,000$";
	}

	internal class Gold : State
	{
		public override string makeLoan() => "Make Loan until 60% beyond Balance";

		public override string outDoorsMoney() => "Accept money until 50,000$";
	}
}
