//Задача 28

using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число: ");
    int N = int.Parse(ReadLine());

    int FactNumber = GetFactNumbers(N);

    WriteLine($"Факториал числа {N}: {FactNumber}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}

int GetFactNumbers(int number)
{
    int fact = 1;
    for (int i = 2; i <= number; i++)
    {
        fact *= i;
    }
    return fact;
}