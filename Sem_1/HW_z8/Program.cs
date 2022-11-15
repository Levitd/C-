// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using static System.Console;

Clear();

Write("Введите Число: ");
int number = Convert.ToInt32(ReadLine());
int startNumber = 2;

WriteLine("");
while (startNumber <= number)
{
    if (startNumber != 2)
    {
        Write(", ");
    }
    Write(startNumber);
    startNumber = startNumber + 2;
}