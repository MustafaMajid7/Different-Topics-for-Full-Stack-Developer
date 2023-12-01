using System.Collections;

namespace YieldReturn
{
	internal class Program
	{
		private static List<int> myList = new List<int>();
		private static object lockObject = new object();

		static List<int> list = Enumerable.Range(1, 5).ToList();
		static void Main(string[] args)
		{

			//Thread writerThread = new Thread(WriterThreadMethod);
			//Thread readerThread = new Thread(ReaderThreadMethod);

			//writerThread.Start();
			//readerThread.Start();

			//writerThread.Join();
			//readerThread.Join();

			//-----------------------------------------------------------------------------

			var t1 = new Thread(print);
			var t2 = new Thread(() =>
			{
                while (true)
                {
					lock (lockObject) { 
						Thread.Sleep(500);
						list.Add(list.Max() + 1);
					}
				}
            });
			t1.Start();
			t2.Start();
			t1.Join();
			t2.Join();
			//Console.Read();

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
	}

}