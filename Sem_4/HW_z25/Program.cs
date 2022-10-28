//Задача 25

using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число A: ");
    int A = int.Parse(ReadLine());
    Write("Введите число B: ");
    int B = int.Parse(ReadLine());

    
    double DegreeNumber = GetDegreeNumber(A,B);

    WriteLine($"{A} в степени {B}: {DegreeNumber}");
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

double GetDegreeNumber(int n1, int n2){
    return Math.Pow(n1,n2);
}