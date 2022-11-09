// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

Console.Clear();

Console.Write("Введите Первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите Второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите Третье число: ");
int number3 = int.Parse(Console.ReadLine());

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

Console.WriteLine($"Максимальное из введенных чисел: {max}");

