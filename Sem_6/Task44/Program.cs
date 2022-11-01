//Задача 44
//Т чисел Фибоначи без рекурсии

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите число: ");
    int N = int.Parse(ReadLine());

    WriteLine($"{String.Join(" ", fibonach(N))}");


}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
/*
catch
{
    Write("Ошибка выполнения!");
}
*/
double[] fibonach(int n)
{
    double[] fArray = new double[n];
    fArray[0] = 0;
    fArray[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fArray[i] = fArray[i - 2] + fArray[i - 1];
    }
    return fArray;
}