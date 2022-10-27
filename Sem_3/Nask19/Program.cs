//Задача 18
using System;
using static System.Console;

Clear();


try
{
    Write("Введите номер координатной четверти: ");
    int koord = int.Parse(ReadLine());

    switch (koord)
    {
        case 1:
            WriteLine($"Для первой координатной четерти - X>0, Y>0");
            break;
        case 2:
            WriteLine($"Для второй координатной четерти - X<0, Y>0");
            break;
        case 3:
            WriteLine($"Для третьей координатной четерти - X<0, Y<0");
            break;
        case 4:
            WriteLine($"Для четвертой координатной четерти - X>0, Y<0");
            break;
        default:
            WriteLine($"Введено неправильное значение координатной четверти! Допустимые значения от 1 до 4");
            break;
    }
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

