using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int sqr = Convert.ToInt32(Math.Pow(number,2));

WriteLine($"Число {sqr} является квадратом числа {number}");
