using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
	public class DateTime_UD
	{
        public StringBuilder Pattern { get; set; } = new StringBuilder();
        public DateTime DateTime { get; set; }
        public void setSegment(IDateTimeSegment segment) 
        {
            segment.Evalute(this);
        }
    }
}
