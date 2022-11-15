// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
using static System.Console;

Clear();

Write("Введите Первое число: ");
int number1 = Convert.ToInt32(ReadLine());

Write("Введите Второе число: ");
int number2 = Convert.ToInt32(ReadLine());

Console.Write("Введите Третье число: ");
int number3 = Convert.ToInt32(ReadLine());

int max;

if (number1 > number2)
{
    max = number1;
}
else if (number1 < number2)
{
    max = number2;
}
else
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

WriteLine($"Максимальное из введенных чисел: {max}");

