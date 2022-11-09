// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;

Console.Clear();

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if (GetEvenNumber(number1))
{
    Console.WriteLine($"{number1} - число четное");
}
else
{
    Console.WriteLine($"{number1} - число Нечетное");
}

static bool GetEvenNumber(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
