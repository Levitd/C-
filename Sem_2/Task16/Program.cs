using System;
using static System.Console;

Clear();

Write("Введите Первое число: ");
int number1 = int.Parse(ReadLine());

Write("Введите Второе число: ");
int number2 = int.Parse(ReadLine());

if (number1*number1 == number2 || Math.Pow(number2,2) == number1)
{
    WriteLine($"ДА!");
}
else
{
    WriteLine($"НЕТ.");
}
