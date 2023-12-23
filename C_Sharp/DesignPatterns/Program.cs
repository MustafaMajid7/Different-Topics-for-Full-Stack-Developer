using System.Xml.Linq;

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

			Console.WriteLine("do you need coffee? enter yes for OK and otherwise if no");
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

			#endregion

		}
	}
}