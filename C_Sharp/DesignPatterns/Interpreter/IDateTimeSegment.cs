using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
	public interface IDateTimeSegment
	{
		void Evalute(DateTime_UD dateTime_UD);
	}
}
