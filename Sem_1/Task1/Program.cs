using System;
using static System.Console;

Clear();

Write("Введите Первое число: ");
int number1 = Convert.ToInt32(ReadLine());

Console.Write("Введите Второе число: ");
int number2 = Convert.ToInt32(ReadLine());

int sqr = Convert.ToInt32(Math.Pow(number1,2));

if (sqr == number2) {
    WriteLine($"Правильно, число {number2} является квадратом числа {number1}");
} else {
    WriteLine($"Не Правильно!!! Число {number2} Не является квадратом числа {number1}");
    WriteLine($"Квадрат числа {number1} будет  {sqr}");
}
