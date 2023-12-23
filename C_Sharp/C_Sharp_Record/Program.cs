using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;

namespace C_Sharp_Record
{
	public record class College(
	string Name,
	int NoOfStudents,
	bool IsPublic,
	List<Teacher>? Teachers = null);
	public record class Teacher(
		string Name,
		int WorkHours,
		bool InProbation,
		List<Course>? Courses = null);
	public record class Course(
		string Name,
		int CreditHours,
		bool IsOptional);
	internal class Program
	{
		static void Main(string[] args)
		{
			#region record
			//// class without any override functions

			//Point point1 = new Point(10, 5);
			//Point point2 = new Point(10, 5);
			//Console.WriteLine(point1 == point2);
			//Console.WriteLine(point1.Equals(point2));

			//// class with override Equals object function 

			//Point_Equals point3 = new Point_Equals(10, 5);
			//Point_Equals point4 = new Point_Equals(10, 5);
			//Console.WriteLine(point3 == point4);
			//Console.WriteLine(point3.Equals(point4));
			//Console.WriteLine(point3.GetHashCode());
			//Console.WriteLine(point4.GetHashCode());

			//// class with override == operator

			//Point_equal_operator point5 = new Point_equal_operator(10, 5);
			//Point_equal_operator point6 = new Point_equal_operator(10, 6);
			//Console.WriteLine(point5 != point6);
			//Console.WriteLine(point5.Equals(point6));

			//// class with override == operator

			//Console.WriteLine("********************************************");

			//PointEquatable point7 = new PointEquatable(10, 5);
			//PointEquatable point8 = new PointEquatable(10, 5);
			//Console.WriteLine(point7.Equals(point8));

			//Console.WriteLine("********************************************");

			//SPoint point9 = new SPoint(10, 5);
			//SPoint point10 = new SPoint(10, 5);
			//Console.WriteLine(point9.Equals(point10));

			//Console.WriteLine("********************************************");

			//RPoint rPoint1 = new RPoint
			//{
			//	x = 10,
			//	y = 10,
			//};
			//rPoint1.y = 15;
			//RPoint rPoint2 = new RPoint(10, 5);
			//RPoint rPoint3 = rPoint2 with { x = 30 };

			//Console.WriteLine(rPoint1);
			//Console.WriteLine(rPoint2);
			//Console.WriteLine(rPoint3); 
			#endregion

			#region coverting json text to c# code
			//var options = new JsonSerializerOptions
			//{
			//	PropertyNameCaseInsensitive = true,
			//	ReadCommentHandling= JsonCommentHandling.Skip
			//};
			//var stream = File.OpenRead("Attendance.json");
			//var list = JsonSerializer.Deserialize<List<Attendance>>(stream,options);
			//         foreach (var item in list)
			//         {
			//             Console.WriteLine(item);
			//         } 
			#endregion

			#region coverting c# code to json text 

			var stream = File.Create(@"E:\Full Stack Repo\Repo\Different-Topics-for-Full-Stack-Developer\college.json");
			var utf8JsonWriter = new Utf8JsonWriter(stream);

			JsonSerializer.Serialize(utf8JsonWriter, GetColleges(5, 3, 3), new JsonSerializerOptions
			{
				WriteIndented = true,
			});


			#endregion
		}
		public static IEnumerable<College> GetColleges(int noOfColleges
			,int teachersPerCollege, int coursesPerTeacher)
			{
				for (var i = 0; i < noOfColleges; i++)
				{
					yield return new($"College{i}", 100, true, GetTeachers());
				}
				List<Teacher>? GetTeachers()
					=> Enumerable.Repeat<Teacher>(new($"John", 8, false, GetCourses()), teachersPerCollege).ToList();
				List<Course>? GetCourses()
					=> Enumerable.Repeat<Course>(new($"Course", 4, false), coursesPerTeacher).ToList();
			}
	}
	class Point
	{
        public int X { get; set; }
		public int Y { get; set; }
        public Point(int X,int Y)
        {
            this.X = X;
			this.Y = Y;
        }
		
	}
	class Point_Equals
	{
		public int X { get; set; }
		public int Y { get; set; }
		public Point_Equals(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public override bool Equals(object? obj)
		{
			Point_Equals point = obj as Point_Equals;
			if (point == null)
			{
				return false;
			}
			return this.X == point.X && this.Y == point.Y;
		}
		public override int GetHashCode()
		{
			//int hash;
			//hash = 17*11 +X.GetHashCode();
			//hash += 17*11 +Y;
			//return hash;
			return HashCode.Combine(X,Y);
		}
	}
	class Point_equal_operator
	{
		public int X { get; set; }
		public int Y { get; set; }
		public Point_equal_operator(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public static bool operator ==(Point_equal_operator lhs,Point_equal_operator rhs)
		{
            if (lhs is null)
            {
				if (rhs == null)
					return true;

				return false;
            }
			return lhs.X == rhs.X && lhs.Y == rhs.Y;
        }
		public static bool operator !=(Point_equal_operator lhs, Point_equal_operator rhs)
		{
			return !(lhs == rhs);
		}
	}
	struct PointEquatable : IEquatable<PointEquatable> 
	{
		public int X { get; set; }
		public int Y { get; set; }
		public PointEquatable(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public override bool Equals(object? obj)
		{
			if (obj is null)
			{
				return false;
			}
			return this.Equals(obj);
		}
		public bool Equals(PointEquatable other)
		{
			return other.X == this.X && other.Y == this.Y;
		}
	}
	struct SPoint
	{
		public int X { get; set; }
		public int Y { get; set; }
		public SPoint(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public override bool Equals(object? obj)
		{
			SPoint? sPoint = obj as SPoint?;
			//SPoint sPoint = (SPoint)obj;
			return this.X == sPoint?.X && this.Y == sPoint?.Y;
		}
	}
	record struct RPoint (int x, int y)
	{
  //      public int X { get; }
		//public int Y { get; }
		public RPoint():this(0,0) { }
	};
}
