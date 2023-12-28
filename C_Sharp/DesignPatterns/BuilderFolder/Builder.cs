using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;

namespace DesignPatterns.BuilderFolder
{
	internal enum Vechicles
	{
		Car = 1,
		Bus = 2,
	}
	internal static class Builder 
	{
		//public static void ChooseVechicle(this Product product,Vechicles vechicle) 
		//{
		//          if (vechicle == Vechicles.Bus)
		//		product = new Bus();
		//	else
		//		product = new Car();
		//}
		public static void ChooseEngine(this Product product, Vechicles vechicle)
		{
			product.Engine = vechicle switch
			{
				Vechicles.Bus /*when product is not null */=> new G_Motors(),
				Vechicles.Car /*when product is not null */=> new BMW(),
			};
			//if (Vechicle is null)
			//    Console.WriteLine("Can't assign null vechicle !!!");
		}
		public static void ChooseWheels(this Product product, Vechicles vechicle)
		{
			product.Wheels = vechicle switch
			{
				Vechicles.Bus /*when Vechicle is not null */=> new HighWheels(),
				Vechicles.Car /*when Vechicle is not null */=> new SmallWheels(),
			};
		}
		public static void ChooseLights(this Product product, Vechicles vechicle)
		{
			product.Light = vechicle switch
			{
				Vechicles.Bus/* when Vechicle is not null */=> new HighLights(),
				Vechicles.Car /*when Vechicle is not null */=> new LowLights(),
			};
		}
	}
}
