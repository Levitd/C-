using System.Text.RegularExpressions;
//Задача 21
using System;
using static System.Console;

Clear();


try
{
    Write("Введите координту Х первой точки: ");
    int X1 = int.Parse(ReadLine());
    Write("Введите координту Y первой точки: ");
    int Y1 = int.Parse(ReadLine());
    Write("Введите координту Z первой точки: ");
    int Z1 = int.Parse(ReadLine());
    Write("Введите координту Х второй точки: ");
    int X2 = int.Parse(ReadLine());
    Write("Введите координту Y второй точки: ");
    int Y2 = int.Parse(ReadLine());
    Write("Введите координту Z второй точки: ");
    int Z2 = int.Parse(ReadLine());

    double longXYZ =  Math.Round( Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2)), 2);

     WriteLine($"Расстояние между точками X и Y в 3D равно: {longXYZ:f2}");
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

