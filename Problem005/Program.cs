int targetNumber = 0;
int testNumber = 1;

while (targetNumber == 0)
{
    testNumber++;
    bool isEvenlyDivideable = true;
    for (int i = 2; i <= 20; i++)
    {
        if (testNumber % i != 0)
        {
            isEvenlyDivideable = false;
        }
        if (!isEvenlyDivideable)
        {
            break;
        }
    }
    if (isEvenlyDivideable)
    {
        targetNumber = testNumber;
        break;
    }
}
Console.Write(targetNumber); //232792560
    
