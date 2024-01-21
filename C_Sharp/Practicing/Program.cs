using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using HtmlAgilityPack;
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

            //OrderedDictionary orderedDictionary = new()
            //{
            //	{ 3, "mostafa" },
            //	{ 1, 2365 },
            //	{ 8, "ibrahim" },
            //	{ 2, 555 }
            //};

            //foreach (var item in orderedDictionary)
            //{
            //	Console.WriteLine(item);
            //}

            //Dictionary<int, string> GenericDectionary = new()
            //{
            //	{3,"sayed" },
            //	{2,"fawzy" },
            //	{4,"ali" },
            //	{25,"fawzy" },
            //	{1,"mostafa" },
            //	{12,"fawzy" },
            //	{22,"fawzy" },
            //};

            //foreach (var item in GenericDectionary)
            //	Console.WriteLine(item);

            //SortedDictionary<int, string> SortedDic= new()
            //{
            //	{10,"maged" },
            //	{2,"mostafa" },
            //	{20,"bono" },
            //	{7,"ali" },
            //};
            //         foreach (var item in SortedDic)
            //             Console.WriteLine(item);



            #endregion

            #region Return Delegate Expression

            //var list = new List<Student>()
            //{
            //	new Student(1, "Test", 19, "st 236"),
            //	new Student(2, "mostafa", 29, "Block 6"),
            //	new Student(3, "mahmoud", 36, "compound 11"),
            //	new Student(4, "mona", 21, "nawa Village"),
            //};


            //foreach (var item in list.Where(IsAdult().Compile()))
            //{
            //	Console.WriteLine(item);
            //}

            #endregion

            #region string operations
            //string x = "";

            //Console.WriteLine(string.IsNullOrEmpty(x));

            //Console.WriteLine(x?.Equals("mostafa",StringComparison.InvariantCultureIgnoreCase));

            //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")); 
            #endregion

            #region Timestamp

            //Console.WriteLine(DateTime.Today);

            //Console.WriteLine((DateTime.ParseExact("2024/01/12 00:00:00", "yyyy/MM/dd HH:mm:ss", CultureInfo.CurrentCulture)
            //- DateTime.ParseExact("1970/01/01 00:00:00","yyyy/MM/dd HH:mm:ss", CultureInfo.CurrentCulture)).TotalSeconds);

            #endregion

            #region HAP (HTML Agility Parsing)

            //var htmlDoc = new HtmlDocument();
            //htmlDoc.Load("C:\\Users\\T480\\Desktop\\New Text Document.html");
            //var node = htmlDoc.DocumentNode.SelectSingleNode("//div[@id=\"content\"]");
            //if (node != null)
            //{
            //	HtmlNodeCollection paragraphnodes = node.SelectNodes("p");
            //	if (paragraphnodes != null)
            //	{
            //		string title = paragraphnodes[1].InnerText;
            //		Console.WriteLine($"{title}");
            //	    Console.WriteLine($"There are {paragraphnodes.Count} paragraphs. The suggested number is between 1 and 3.");
            //	}
            //}

            #endregion

            #region XML Serializing

            //var serializer = new XmlSerializer(typeof(ShipmentCreationResponse));
            //using (TextReader reader = new StringReader(response.Message))
            //{
            //    var responseObject = (ShipmentCreationResponse)serializer.Deserialize(reader);
            //    baseCommandResponse.Data = responseObject.Notifications;
            //} 
            #endregion

            #region MyRegion

            string s = "sayed";
            Console.WriteLine(s??"ali");


            #endregion

        }
		public static Expression<Func<Student,bool>> IsAdult()
		{
			return p => p.Age > 21;
		}
		

	}
}