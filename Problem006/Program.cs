double sumOfSquares = 0;
double squareOfSums = 0;
double sum = 0;
double difference = 0;

for (double i = 1; i <= 100; i++)
{
    sumOfSquares += Math.Pow(i, 2);
}

for (double i = 1; i <= 100; i++)
{
    sum += i;
}

squareOfSums = Math.Pow(sum, 2);

difference = squareOfSums - sumOfSquares;
Console.WriteLine(difference); //25164150