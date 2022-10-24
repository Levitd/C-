using System;
using static System.Console;

Clear();

Write("Введите Первое число: ");
int number1=int.Parse(ReadLine());
Write("Введите Второе число: ");
int number2=int.Parse(ReadLine());

//int number1 = new Random().Next(10, 100);
//int number2 = new Random().Next(1, 10);
int ostatok = number1 % number2;

if (ostatok == 0)
{
    WriteLine($"Число {number2} кратно числу {number1}");
}
else
{
    WriteLine($"Число {number2} Не кратно числу {number1}. Остаток от деления {ostatok}");
}
