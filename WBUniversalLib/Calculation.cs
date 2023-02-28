using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;


namespace WBUniversalLib
{
	[TestClass]
	public class Calculation
	{
	
		[TestMethod]
		public void Calculation_ValidData()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 2;
			int materialType = 0;
			int count = 15;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualQuantity = 114147;

			Assert.AreEqual(materialCount, actualQuantity);

		}


		[TestMethod]
		public void Calculation_ProductTypeLessThanZero()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = -1;
			int materialType = 0;
			int count = 15;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}
		[TestMethod]
		public void Calculation_MaterialTypeLessThanZero()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = -1;
			int count = 15;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_ProductTypeMoreThanMaximum()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 9;
			int materialType = 0;
			int count = 15;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_MaterialTypeMoreThanMaximum()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 9;
			int count = 15;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_CountIsLessThanZero()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 0;
			int count = -9;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_CountIsZero()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 0;
			int count = 0;
			float width = 45.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);
		}

		[TestMethod]
		public void Calculation_WidthIsLessThanZero()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 0;
			int count = -15;
			float width = -9.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_WidthIsZero()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 0;
			int count = -15;
			float width = 0.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_ResultOverflow()
		{
			MaterialCalculator Calculator = new MaterialCalculator();

			int productType = 0;
			int materialType = 0;
			int count = int.MaxValue;
			float width = 4.0f;
			float height = 20.0f;

			int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, height);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;

			Assert.AreEqual(materialCount, actualResult);

		}










	}


}
