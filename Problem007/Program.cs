int counter = 2;
int primeNumber10001 = 0;
bool isPrime;
int currentNumber = 3;

while (counter < 10001)
{
    currentNumber += 2;
    isPrime = IsPrime(currentNumber);
    if (isPrime)
    {
        counter++;
        primeNumber10001 = currentNumber;
    }
}

Console.Write(primeNumber10001); //104743
    

static bool IsPrime(int value)
{
    for (int divisor = 3; divisor * divisor <= value; divisor += 2)
    {
        if (value % divisor == 0) return false;
    }

    return true;
}
