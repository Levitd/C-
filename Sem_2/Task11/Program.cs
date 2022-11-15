using System;
using static System.Console;

Clear();

noCenter();

void noCenter()
{
    int number = new Random().Next(100, 1000);
    WriteLine($"{number}->{number / 100 * 10 + number % 10}");
}