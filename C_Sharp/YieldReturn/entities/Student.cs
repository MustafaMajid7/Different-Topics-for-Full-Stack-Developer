using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
	[Table("Students",Schema ="University")]
	public class Student
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
		public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

	}
}
