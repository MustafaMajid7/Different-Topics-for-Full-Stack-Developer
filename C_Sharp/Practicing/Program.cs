using System.Collections;
using System.Collections.Specialized;
using LinqKit;
using Moq;

namespace Practicing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region predicate builder
			//var arr = new []{1,2,3,4,5,6};
			//var predicate = PredicateBuilder.New<int>(x=>x==1);
			//predicate.Or(x => x > 2);
			//predicate.And(x=>x>2);
			//predicate.And(x=>x<5);
			//predicate.Or(x=>x==5);

			//foreach (var item in arr.Where(predicate))
			//         {
			//             Console.WriteLine(item);
			//         }

			#endregion

			#region Mock
			//var calculator = new Mock<ICalculator>();

			//calculator.Setup(x=>x.Multiply(3.0d,5.0d)).Returns(15.0d);

			//Calculator calculator1 = new Calculator(calculator.Object);

			//         Console.WriteLine(calculator1.Multiply(5,6)); 
			#endregion

			#region HashTable VS Dictionary

			//Hashtable hashtable = new()
			//{
			//	{ 1, "mostafa" },
			//	{ 2, "mahmoud" },
			//	{ 3, "maged" },
			//	{ 4, "ali" }
			//};

			//foreach (var item in hashtable.Values)
		    //{
		    //	Console.WriteLine(item);
		    //}

			//OrderedDictionary orderedDictionary = new();

			//orderedDictionary.Add(orderedDictionary.Count, 2365);
			//orderedDictionary.Add(orderedDictionary.Count, "mostafa");

			//orderedDictionary.Add(orderedDictionary.Count, 555);
			//orderedDictionary.Add(orderedDictionary.Count, "ibrahim");

   //         foreach (var item in orderedDictionary.Keys)
   //         {
   //             Console.WriteLine(item);
   //         }

			var x = DateTime.Parse("4-5-2020").ToString("dd-MM-yyyy hh.mm.ss");
            Console.WriteLine(x);

            #endregion
        }
	}
}