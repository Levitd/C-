//Задача 20
using System;
using static System.Console;
using System.Text.RegularExpressions;

Clear();


try
{
    Write("Введите координту Х первой точки: ");
    int X1 = Convert.ToInt32(ReadLine());
    Write("Введите координту Y первой точки: ");
    int Y1 = Convert.ToInt32(ReadLine());
    Write("Введите координту Х второй точки: ");
    int X2 = Convert.ToInt32(ReadLine());
    Write("Введите координту Y второй точки: ");
    int Y2 = Convert.ToInt32(ReadLine());

    double longXY = longLine(X1,X2,Y1,Y2);

    WriteLine($"Расстояние между точками X и Y равно: {longXY:f3}");
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

double longLine(int x1, int x2, int y1, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3);
}