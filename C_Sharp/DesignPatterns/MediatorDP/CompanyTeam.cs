using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorDP
{
	public class CompanyTeam
	{
		public string Name { get; set; }
		public Mediator Mediator { get; set; }
		public CompanyTeam(string name)
		{
			Name = name;
		}

		public void SendMessage(string message)
		{
			if (Mediator is null)
			{
				Console.WriteLine("No Available Agent");
				return;
			}
			Mediator.sendToClient(message);
		}
		public void ReceiveMessage(string message)
		{
			Console.WriteLine($"{Name} has recieved message : {message}");
		}
	}
}
