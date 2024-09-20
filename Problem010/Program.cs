using System.Diagnostics;

long sumOfPrimes = 5;
bool isPrime;
int currentNumber = 3;

while (currentNumber < 2000000)
{
    currentNumber += 2;
    isPrime = IsPrime(currentNumber);
    if (isPrime)
    {
        sumOfPrimes += currentNumber;
    }
}

Console.Write(sumOfPrimes); // 142.913.828.922


static bool IsPrime(int value)
{
    for (int divisor = 3; divisor * divisor <= value; divisor += 2)
    {
        if (value % divisor == 0) return false;
    }

    return true;
}
