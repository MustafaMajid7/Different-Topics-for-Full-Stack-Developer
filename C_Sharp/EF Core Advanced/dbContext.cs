using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Advanced.entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Advanced
{
	public class dbContext : DbContext
	{
		public dbContext() { }

		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<Student> Students { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source = MOSTAFAMAGED\\SQLEXPRESS;Initial Catalog =EF_Advanced;Integrated Security=True;TrustServerCertificate=True");
		}

	}
}
