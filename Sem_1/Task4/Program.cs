using System;

Console.Clear();

Console.Write("Введите Трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int ostatok = number % 10;

Console.WriteLine($"Последнее число: {ostatok}");
