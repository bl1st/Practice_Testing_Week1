using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

	public class MaterialCalculator
	{
		public float[] ProductTypes = new float[] { 1.1f, 2.5f, 8.43f };
		public float[] DefectiveMaterialCoeffitients = new float[] { 0.003f, 0.012f };

		public MaterialCalculator() { }

		public int GetQuantityForProduct(int productType, int materialType, int count, float width, float height)
		{
			if (count <=0 || width <=0 || height <= 0)
			{
				return -1;
			}

			float productTypeCoefficient;
			float defectiveMaterialCoefficient;
			try
			{
				productTypeCoefficient = ProductTypes[productType];
				defectiveMaterialCoefficient = DefectiveMaterialCoeffitients[materialType];
			}
			catch (Exception ex)
			{
				return -1;
			}
			

			float materialQuantity = productTypeCoefficient * width * height * count * (1+defectiveMaterialCoefficient);

			int totalMaterialQuantity = (int)Math.Ceiling(materialQuantity);
			//if (totalMaterialQuantity < 0) return -1;

			return totalMaterialQuantity;
		}
	}
}
