using BenchmarkDotNet.Running;

namespace BenchMark
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<Testing>();
		}
	}
}