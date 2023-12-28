using System.Collections;
using System.Xml.Linq;
using DesignPatterns.BuilderFolder;
//using DesignPatterns.Factory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region string formatter

			//int safetyScore = 30;
			//string message = $"The usage policy for {safetyScore} is {safetyScore switch
			//{
			//	> 90 => "Unlimited usage",
			//	> 80 => "General usage, with daily safety check",
			//	> 70 => "Issues must be addressed within 1 week",
			//	> 50 => "Issues must be addressed within 1 day",
			//	_ => "Issues must be addressed before continued use",
			//}}";
			//Console.WriteLine(message);

			//double x = 365.39625D;
			//string y = "mostafa";
			//Console.WriteLine($"Cost of {y,-10} is {x:F2}$");

			#endregion

			#region decorator

			//Decorator cafe = new Cafe();
			//Decorator decorator1 = new Milk(cafe);
			//Decorator decorator2 = new Cream(decorator1);
			//Decorator decorator3 = new Choclate(decorator2);

			//var x = decorator3.getCost();
			//Console.WriteLine(x);

			//Console.WriteLine("do you need coffee? enter yes for OK and otherwise if no");
			//bool.TryParse(Console.ReadLine(), out bool status);

			//Decorator cafe1 ;

			//if (Console.ReadLine()?.Equals("yes", StringComparison.InvariantCultureIgnoreCase) ?? false)
			//{
			//	cafe1 = new Cafe();
			//             Console.WriteLine("what about additions ? need any addition !!!");
			//	Decorator? addOn;

			//	if (Console.ReadLine()?.Equals("yes", StringComparison.InvariantCultureIgnoreCase) ?? false)
			//	{
			//                 Console.WriteLine("our additions are Cream, Milk, Chocolate \nenter your favourite addition" +
			//							" but if you changed your mind you can enter no");
			//		addOn = Console.ReadLine()?.ToLower() switch
			//		{
			//			"milk" =>  new Milk(cafe1),
			//			"cream" => new Cream(cafe1),
			//			"chocolate" => new Choclate(cafe1),
			//			_ => null,
			//		};
			//		while (addOn is not null)
			//		{
			//			Console.WriteLine("if you need any more additions enter one of them (Cream, Milk, Chocolate)?");
			//			switch (Console.ReadLine())
			//			{
			//				case nameof(Milk):
			//					addOn = new Milk(addOn);
			//					break;
			//				case nameof(Cream):
			//					addOn = new Cream(addOn);
			//					break;
			//				case nameof(Choclate):
			//					addOn = new Choclate(addOn);
			//					break;
			//				default:
			//					Console.WriteLine($"{addOn.mycost()}");
			//					Console.WriteLine($"the totol price is {addOn.getCost()}");
			//					addOn = null;
			//					break;
			//			};
			//		}
			//	}
			//	else
			//		Console.WriteLine($"the totol price is {cafe1.getCost()}");
			//}
			//Console.WriteLine("Thanks for use our service");



			#endregion

			#region inheriting Collections

			//additions decorators = new additions();

			//decorators.Add(decorator1);
			//decorators.Add(decorator2);
			//decorators.Add(decorator3);

			//decorators.printAllAdditions();

			#endregion

			#region Null forgiving operator

			//double? x = null;
			//string z = x.ToString()!;

			//Console.WriteLine(z); 
			#endregion

			#region Factory

			//Client client1 = new(new ProductFactory());
			//Client client2 = new(new BeverageFactory());

			//client1.MakeOrder(1);
			//client2.MakeOrder(3);

			//Console.WriteLine(client1.ShowMyOrder());
			//Console.WriteLine(client2.ShowMyOrder());

			#endregion

			#region TimeSpan

			//DateTime launchDate = new DateTime(2023, 11, 15, 9, 0, 0);
			//DateTime now = DateTime.Now;

			//// Calculate the interval between the two dates.
			//TimeSpan ts = now - launchDate;

			//Console.WriteLine("TimeSpan: {0}", ts.ToString());

			//// TimeSpan properties
			//Console.WriteLine("Days: {0}", ts.Days);
			//Console.WriteLine("Total Number of Days: {0}", ts.TotalDays);
			//Console.WriteLine("Hours: {0}", ts.Hours);
			//Console.WriteLine("Total number of hours: {0}", ts.TotalHours);
			//Console.WriteLine("Minutes: {0}", ts.Minutes);
			//Console.WriteLine("Total Number of Minutes: {0}", ts.TotalMinutes);
			//Console.WriteLine("Seconds: {0}", ts.Seconds);
			//Console.WriteLine("Total Number of Seconds: {0}", ts.TotalSeconds);
			//Console.WriteLine("Milliseconds: {0}", ts.Milliseconds);
			//Console.WriteLine("Total Number of Milliseconds: {0}", ts.TotalMilliseconds);
			//Console.WriteLine("Ticks: {0}", ts.Ticks);

			// Create TimeSpan Fromxxx methods
			//TimeSpan ts1 = TimeSpan.FromDays(12);
			//TimeSpan ts2 = TimeSpan.FromHours(8);
			//TimeSpan ts3 = TimeSpan.FromMinutes(20);
			//TimeSpan ts4 = TimeSpan.FromMilliseconds(2300);

			//TimeSpan ts5 = ts1+ ts2 + ts3;
			//Console.WriteLine(ts5);
			//TimeSpan ts6 = ts5.Subtract(ts2);
			//Console.WriteLine(ts6);

			//var firstTimeSpan = new TimeSpan(1, 60, 3600);
			//var secondTimeSpan = new TimeSpan(2, 60, 3600);
			//var actual = firstTimeSpan.Add(secondTimeSpan);
			//var expected = firstTimeSpan + secondTimeSpan;

			//         Console.WriteLine(actual);
			//         Console.WriteLine(expected);

			//var firstTimeSpan = new TimeSpan(2, 50, 3600);
			//var secondTimeSpan = new TimeSpan(1, 30, 1800);

			////var expected = firstTimeSpan.Divide(secondTimeSpan);
			////var actual = firstTimeSpan / secondTimeSpan;

			//var expected = firstTimeSpan.Divide(2);
			//var actual = firstTimeSpan / 2;

			//Console.WriteLine(expected);
			//         Console.WriteLine(actual);

			//DateTime now = DateTime.Now.AddHours(15);
			//DateTime now2 = DateTime.Now;

			//var x = now2 - now;

			//var y = x.TotalHours;
			//Console.WriteLine(DateTime.Parse("2023-12-27 08:00:00.0000000").Hour);

			//var date1 = DateTime.Now;
			//var date2 = DateTime.UtcNow;
			//var difference = date1 - date2;
			//Console.WriteLine("{0} - {1} = {2}", date1, date2, difference);

			//// Find difference between Now and UtcNow using DateTimeOffset
			//var dateOffset1 = DateTimeOffset.Now;
			//var dateOffset2 = DateTimeOffset.UtcNow;
			//var difference2 = dateOffset1 - dateOffset2;
			//Console.WriteLine("{0} - {1} = {2}",
			//				  dateOffset1, dateOffset2, difference2);
			#endregion

			#region practice on some features

			//var list = new List<object> { "mostafa", 2365,23.0,985m,'m',true, "hussien" };
			//foreach (var item in list.OfType<char>())
			//{
			//	Console.WriteLine(item);
			//}

			//var list = new ArrayList { "mostafa", "hussien" };
			//foreach (var item in list.Cast<string>())
			//{
			//	Console.WriteLine(item);
			//}

			//int[] arr = { 9, 10 };

			//string condition = int.Parse(Console.ReadLine()) switch
			//{
			//	//10 or 9 => "sobre",
			//	//var x when x >8 => "sobre",
			//	//var x when x.In(arr) => "sobre",
			//	>=9 => "sobre",
			//	8 or 7 => "notable",
			//	6 => "Bien",
			//	5 => "aprobado",
			//	_ => "suspenso",
			//};
			//         Console.WriteLine(condition);


			#endregion

			#region Builder

			var car = new Car();

			car.ChooseEngine(Vechicles.Car);
			car.ChooseWheels(Vechicles.Bus);
			car.ChooseLights(Vechicles.Car);

            Console.WriteLine(car.Engine.printMe());
            Console.WriteLine(car.Light.printMe());
            Console.WriteLine(car.Wheels.printMe());

            #endregion

        }

	}
}