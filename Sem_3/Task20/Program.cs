using System.Text.RegularExpressions;
//Задача 20
using System;
using static System.Console;

Clear();


try
{
    Write("Введите координту Х первой точки: ");
    int X1 = int.Parse(ReadLine());
    Write("Введите координту Y первой точки: ");
    int Y1 = int.Parse(ReadLine());
    Write("Введите координту Х второй точки: ");
    int X2 = int.Parse(ReadLine());
    Write("Введите координту Y второй точки: ");
    int Y2 = int.Parse(ReadLine());

    double longXY =  Math.Round( Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)), 6);

     WriteLine($"Расстояние между точками X и Y равно: {longXY:f2}");
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

