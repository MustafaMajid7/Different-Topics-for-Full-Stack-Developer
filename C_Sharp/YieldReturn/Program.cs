using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using YieldReturn;

namespace YieldReturn
{
	internal class Program
	{
		private static List<int> myList = new List<int>();
		private static object lockObject = new object();

		static List<int> list = Enumerable.Range(1, 5).ToList();
		enum weekNames
		{
			Monday=1,
			Tuesday=2,
			Wednesday=3,
			Thursday=4,
			Friday=5,
			Saturday=6,
			Sunday=7,
		}
		record student<T,S>(T age,S name)
		{
			public void printMyName(S myname) { Console.WriteLine(nameof(myname)); }
		};
		static void Main(string[] args)
		{

            #region Concurrency
            //Thread writerThread = new Thread(WriterThreadMethod);
            //Thread readerThread = new Thread(ReaderThreadMethod);

            //writerThread.Start();
            //readerThread.Start();

            //writerThread.Join();
            //readerThread.Join();

            //-----------------------------------------------------------------------------

            //var t1 = new Thread(print);
            //var t2 = new Thread(() =>
            //{
            //             while (true)
            //             {
            //		lock (lockObject) { 
            //			Thread.Sleep(500);
            //			list.Add(list.Max() + 1);
            //		}
            //	}
            //         });
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            //Console.Read(); 
            #endregion

            #region nameof
            //var e = weekNames.Saturday;

            //student<int,string> s = new student<int, string>(5, "mahmoud");
            //string y = "ali";

            //foreach (var item in s.GetType().GetProperties())
            //{
            //    Console.WriteLine(nameof(item.Name.Length));
            //}

            //s.printMyName(y); 
            #endregion

			dbContext db = new dbContext();
			db.Database.Migrate();

			Course course = new Course("Wisdom", 1) {Id=500 };

			changeTracker(db, course);
			Course crs = db.Courses.Find(3);
			crs.Name = "new Course";
            //foreach (var item in db.Entry<Course>(crs).Properties)
            //{
            //	//Console.WriteLine(item.EntityEntry.CurrentValues.GetValue<string>("Name"));
            //	Console.WriteLine(item.Metadata.Name);
            //	Console.WriteLine(item.CurrentValue);
            //}
            //Console.WriteLine(db.Courses.Entry(crs).Property("isDeleted").CurrentValue);

			//db.SaveChanges();
			//foreach (var item in db.Courses.Local.ToList())
			//{
			//	Console.WriteLine(item);
			//}
            foreach (var item in db.Courses)
			{
				Console.WriteLine(item+"   "+db.Courses.Entry(item).State.ToString());
			}
            Console.WriteLine("------------------------------------------------");
			foreach (var item in db.Courses.Local.ToList())
			{
				Console.WriteLine(item + "   " + db.Courses.Entry(item).State.ToString());
			}
			db.SaveChanges();
		}
		public static IEnumerable<int> yieldReturn()
		{
            foreach (var item in list)
            {
				lock(lockObject)
				{
					yield return item;
				}
            }
			
		}
		public static void print()
		{
			Console.WriteLine(yieldReturn());
			//        foreach (var item in list)
			//        {
			//lock( lockObject)
			//{
			//	Thread.Sleep(500);
			//	Console.WriteLine(item);
			//}
			//        }
		}

		static void WriterThreadMethod()
		{
			while(true) { 
				for (int i = 0; i < 10; i++)
				{
					lock (lockObject)
					{
						myList.Add(i);
						Console.WriteLine($"Writer Thread added: {i}");
						Thread.Sleep(100); // Simulate some work
					}
				}
			}
		}

		static void ReaderThreadMethod()
		{
			while (true)
			{
				lock (lockObject)
				{
					Console.WriteLine("Reader Thread content:");
					foreach (var item in myList)
					{
						Console.Write($"{item} ");
					}
					Console.WriteLine();
					Thread.Sleep(1000); // Print every second
				}
			}
		}
		static void changeTracker<T>(DbContext db,T entity) where T : class
		{
			db.ChangeTracker.TrackGraph(entity, e => {
				if (e.Entry.IsKeySet )
				{
					var key = db.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties.
								FirstOrDefault().GetColumnName();
					//var x = int.Parse(entity.GetType().GetProperty(key).GetValue(entity).ToString());
					var y = int.Parse(db.Entry(entity).Property(key).CurrentValue.ToString());
					var x = db.Set<T>().Find(y);

					if (x is not null)
						e.Entry.State = EntityState.Modified;
					else
					{
						db.Entry(entity).Property(key).CurrentValue = 0;
						
						e.Entry.State = EntityState.Added;
					}
				}
				else
				{
					e.Entry.State = EntityState.Added;
				}
			});
		}
	}

}