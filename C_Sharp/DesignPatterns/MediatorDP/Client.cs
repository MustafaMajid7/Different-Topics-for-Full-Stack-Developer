using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorDP
{
	public class Client
	{
        public string Name { get; set; }
        public Mediator Mediator { get; set; }
		public Client(string name) 
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
            Mediator.sendToCompany(message);
		}
		public void ReceiveMessage(string message)
		{
            Console.WriteLine($"{Name} has recieved message : {message}");
        }

	}
}
