long term = 0;
int divisorCounter = 0;
int counter = 0;

while (true)
{
    counter++;
    term += counter;

    divisorCounter = NumberOfDivisors(term);

    if (divisorCounter > 500)
    {
        break;
    }

}

Console.WriteLine(term); //76576500
Console.WriteLine(divisorCounter); //576 divisors


static int NumberOfDivisors(long term)
{
    int divisors = 0;
    for (int i = 1; i <= Math.Sqrt(term); i++)
    {
        if (term % i == 0)
        {
            divisors += 2;
        }
    }
    return divisors;
}