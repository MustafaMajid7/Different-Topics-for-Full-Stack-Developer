using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
	[Table("Courses", Schema = "University")]
	public partial class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int degree { get; set; }
		public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
	}
}
