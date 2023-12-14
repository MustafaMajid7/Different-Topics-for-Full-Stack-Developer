using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
	public partial class Course
	{
		//public Course() { }
        public Course(string Name,int degree)
        {
			this.Name = Name + ":)";
            this.degree = degree+100;
        }
        public override string ToString()
		{
			return $"Index: {this.Id}, Name :{this.Name}, Degree is {this.degree}";
		}
	}
}
