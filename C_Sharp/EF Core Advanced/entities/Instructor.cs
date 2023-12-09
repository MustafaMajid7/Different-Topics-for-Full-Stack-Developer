using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Advanced.entities
{
	[Table("Instructors", Schema = "University")]
	public class Instructor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Address { get; set; }
		public virtual ICollection<Student> Courses { get; set; } = new HashSet<Student>();

	}
}
