using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YieldReturn
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
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>().Property<bool>("isDeleted");
		}
	}
}
