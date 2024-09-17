int x = 1;
int y = 2;
int z = 0;
int sum = 0;

while(z < 4000000)
{
    z = y + x;
    if (y % 2 == 0) sum += y;
    x = y;
    y = z;
}
Console.WriteLine(sum);