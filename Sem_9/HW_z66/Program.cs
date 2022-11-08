// Задача 66. Сумма натуральных числет от M до N. Используем рекурсию


using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();
try
{
    Write("Сумма натуральных числет от M до N. Введите М и N через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine($"Сумма чисел равна: {SumNumber(int.Parse(nums[0]), int.Parse(nums[1]))}");

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

int SumNumber(int M, int N)
{
    if (M > N) return 0;
    return (M + SumNumber(M + 1, N));
}