using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
	public class DaySegment : IDateTimeSegment
	{
        public void Evalute(DateTime_UD dateTime_UD)
		{
			dateTime_UD.Pattern.Append(dateTime_UD.DateTime.Day); 		
		}
	}
}
