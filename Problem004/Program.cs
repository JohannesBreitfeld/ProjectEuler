int biggestProduct = 0;

for (int i = 999; i > 900; i--)
{
	for (int j = 999; j > 900; j--)
	{
		string productAsString = Convert.ToString(i * j);

		if (productAsString.SequenceEqual(productAsString.Reverse()))
		{
			int productAsInt = int.Parse(productAsString);
			if (productAsInt > biggestProduct)
			{ 
				biggestProduct = productAsInt;
			}
		}
	}
}

Console.WriteLine(biggestProduct); //906609