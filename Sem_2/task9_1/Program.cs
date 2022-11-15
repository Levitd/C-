using System;
using static System.Console;

Clear();
int number = new Random().Next(10, 100);

maxNum(number);

void maxNum(int number)
{
    int a1 = number / 10;
    int a2 = number % 10;
    if (a1 > a2)
    {
        WriteLine($"{number}->{a1}");
    }
    else
    {
        WriteLine($"{number}->{a2}");
    }

}

