using System;
using static System.Console;

Clear();

Write("Введите Трехзначное число: ");
int number = int.Parse(ReadLine());

WriteLine($"Вторя цифра от введенного числа: {number/10-number/100*10}");
