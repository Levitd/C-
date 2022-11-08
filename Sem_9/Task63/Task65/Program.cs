// Задача 65. Вывести натуральные числа от M до N. Используем рекурсию

// Задача 63
// Вывести вcе натуральные числа в интервале от 1 до N

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Вывести вcе натуральные числа в интервале от М до N. Введите М и N через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine(PrintNumber(int.Parse(nums[0]), int.Parse(nums[1])));

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
    Write("Ошибка выполнения!");
}

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}