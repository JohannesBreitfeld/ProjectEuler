var biggestPrimeFactor = 0;
for (int i = 1; i < Math.Sqrt(600851475143); i++)
{
    var primtal = true;

    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            primtal = false;
            break;
        }
    }
    if (primtal == true && 600851475143%i == 0)
    {
        biggestPrimeFactor = i;
    }
}
Console.WriteLine(biggestPrimeFactor);