using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 0;
			int count = int.MaxValue;
			float width = 5.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			Console.ReadKey();


		}
	}
}
