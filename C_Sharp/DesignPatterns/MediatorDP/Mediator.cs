using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorDP
{
	public class Mediator
	{
        public Client Client { get; set; }
        public CompanyTeam Team { get; set; }
        public void sendToClient(string message)
		{
			if (Client is null)
			{
				Console.WriteLine("No Available Client");
				return;
			}
			Client.ReceiveMessage(message);
		}
		public void sendToCompany(string message)
		{
			if (Team is null)
			{
				Console.WriteLine("No Available Team");
				return;
			}
			Team.ReceiveMessage(message);
		}

	}
}
