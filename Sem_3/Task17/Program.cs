using System;
using static System.Console;

Clear();


try
{
    Write("Введите Координату Х: ");
    int Х = int.Parse(ReadLine());
    Write("Введите Координату Y: ");
    int Y = int.Parse(ReadLine());


    if (Х > 0 && Y > 0)
    {
        WriteLine($"1 Четверть");
    }
    else if (Х < 0 && Y > 0)
    {
        WriteLine($"2 Четверть");
    }
    else if (Х < 0 && Y < 0)
    {
        WriteLine($"3 Четверть");
    }
    else if (Х > 0 && Y < 0)
    {
        WriteLine($"4 Четверть");
    } else {
        WriteLine($"Не правильно введены координаты");
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

