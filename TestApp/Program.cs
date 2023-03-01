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

			int productType = 1;
			int materialType = 1;
			int count = 20;
			float width = float.MaxValue;
			float height = 30.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			Console.ReadKey();


		}
	}
}
