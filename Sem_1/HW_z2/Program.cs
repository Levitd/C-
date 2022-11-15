// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
using static System.Console;

Clear();

Write("Введите Первое число: ");
int number1 = Convert.ToInt32(ReadLine());

Console.Write("Введите Второе число: ");
int number2 = Convert.ToInt32(ReadLine());

int min =0, max=0, rav=0;

if (number1>number2) {
    min=number2;
    max=number1;
} else if (number1<number2) {
    min=number1;
    max=number2;
} else {
    rav=1;
}
if (rav == 1){
    WriteLine("Введенные числа равны!");
} else {
    WriteLine($"Число {max} больше чем {min}");
}
