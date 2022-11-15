// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
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
*/
//----------------------------------------------------------


// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
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
*/
//--------------------------------------------------------------------------------------

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
using static System.Console;
using System;

Console.Clear();

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (GetEvenNumber(number1))
{
    Console.WriteLine($"{number1} - число четное");
}
else
{
    Console.WriteLine($"{number1} - число Нечетное");
}

static bool GetEvenNumber(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
*/
// -----------------------------------------------------------------------------

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using static System.Console;

Clear();

Write("Введите Число: ");
int number = Convert.ToInt32(ReadLine());
int startNumber = 2;

WriteLine("Вариант 1: ");
while (startNumber <= number)
{
    Write($"{startNumber} ");
    startNumber = startNumber + 2;
}

//Вариант 2
startNumber = 1;

WriteLine();
WriteLine("Вариант 2: ");
while (startNumber <= number)
{
    if (startNumber % 2 == 0)
    {
        Write($"{startNumber} " );
    }
    startNumber++;
}