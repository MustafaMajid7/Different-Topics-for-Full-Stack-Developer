using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Record
{
	public class Attendance
	{
        public DateTime AttendaceDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int EmpID { get; set; }
		public override string ToString()
		{
			return $"{EmpID} : {AttendaceDate:yyyyMMdd} {DepartureTime:yyyyMMdd} {ArrivalTime:yyyyMMdd}";
		}
	}
}
