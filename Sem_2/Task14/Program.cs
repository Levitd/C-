using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());

int ostatok1 = number % 7;
int ostatok2 = number % 23;


if (ostatok1 == 0 && ostatok2 == 0)
{
    WriteLine($"ДА! Число {number} кратно числам 7 и 23");
}
else
{
    WriteLine($"НЕТ Число {number} Не кратно одновременно числам 7 и 23.");
}
