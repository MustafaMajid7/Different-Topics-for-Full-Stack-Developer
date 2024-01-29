using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDP
{
	public interface ICommand
	{
        double Number { get; set; }
        void execute(double number);
		void unexecute(double number);
	}
}
