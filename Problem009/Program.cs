int a = 0, b = 0, c = 0;
bool isFound = false;

for (int i = 1; i < 335; i++)
{
	for (int j = 0; j < 1000-i; j++)
	{
		int k = 1000 - i - j;
		if (Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2))
		{
			a = i;
			b = j;
			c = k;
			isFound = true;
			break;

		}
	}
	if (isFound) 
	{ 
		break; 
	}
}
Console.WriteLine($"a = {a} b = {b} c = {c}"); // a= 200, b=375, c=425
Console.WriteLine($"a*b*c = {a * b * c}"); //31875000