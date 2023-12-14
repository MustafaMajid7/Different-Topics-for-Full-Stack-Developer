using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Advanced.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_Core_Advanced
{
	public class dbContext : DbContext
	{
		private readonly IConfiguration config;

		public dbContext(IConfiguration config) 
		{
			this.config = config;
			var builder = new ConfigurationBuilder().AddJsonFile("appSetting.json");
			this.config = builder.Build();
		}

		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<Student> Students { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(config["Connection String:default"]);
			//optionsBuilder.UseSqlServer("Data Source = MOSTAFAMAGED\\SQLEXPRESS;Initial Catalog =EF_Advanced;Integrated Security=True;TrustServerCertificate=True");
		}

	}
}
