using System.Data;
using System.Diagnostics;
using EF_Core_Advanced.entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Advanced
{
	public class dto
	{
        public int age { get; set; }
        public string  name { get; set; }
    }
	public partial class Form1 : Form
	{
		public dbContext dbContext = new dbContext();
		List<Course> courses;
		List<Student> students;
		public Form1()
		{
			InitializeComponent();

			courses = dbContext.Courses.ToList();
			students = dbContext.Students.ToList();

			dataGridView1.DataSource = courses;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Student student = new Student();
			//student.Name = TXT_name.Text; 
			//student.Address = TXT_addr.Text;
			//student.Age = (int)NUD_age.Value;
			//dbContext.Add(student);
			SqlParameter sqlParameter1 = new SqlParameter()
			{
				ParameterName = "@name",
				DbType = DbType.String,
				Value = TXT_name.Text
			};
			SqlParameter sqlParameter2 = new SqlParameter()
			{
				ParameterName = "@age",
				DbType = DbType.Int32,
				Value = (int)NUD_age.Value
			};
			SqlParameter sqlParameter3 = new SqlParameter()
			{
				ParameterName = "@address",
				DbType = DbType.String,
				Value = TXT_addr.Text
			};

			var count = dbContext.Students.FromSqlRaw($"execute [insertStudent]")
										.ToList();

			dataGridView1.DataSource = count;

			//var x = dbContext.Database.ExecuteSql($"SELECT COUNT(*) as count FROM university.students");
			//var x = dbContext.Database.SqlQuery<int>($"SELECT COUNT(*) as count FROM university.students").FirstOrDefault();
			//NUD_age.Value = dbContext.Database.SqlQuery<int>($"execute insertStudent").FirstOrDefault();

			//var x = dbContext.Students.FromSqlRaw("execute insertStudent @name,@age,@address", sqlParameter1, sqlParameter2, sqlParameter3).ToList();
			//Trace.WriteLine(x);
			//dataGridView1.DataSource = dbContext.Students.FromSqlRaw("select * from University.Students").ToList();

		}
	}
}