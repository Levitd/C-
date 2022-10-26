using System;
using static System.Console;

Clear();

Write("Введите число, обозначающее день недели: ");
try
{
    int number = int.Parse(ReadLine());


    if (number == 6 || number == 7)
    {
        WriteLine($"Да, это выходной");
    }
    else if (number >= 1 && number < 6)
    {
        WriteLine($"Нет, это не выходной");
    } else {
        WriteLine($"Введенное число не обозначет день недели!");
    }
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

