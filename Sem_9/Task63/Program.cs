// Задача 63
// Вывести вcе натуральные числа в интервале от 1 до N

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Вывести вcе натуральные числа в интервале от 1 до N. Введите N: ");
    int N = int.Parse(ReadLine());

    PrintNaturalToN(N);
    WriteLine();
    PrintRequrs(1, N); //Решение с рекурсией
    WriteLine();
    WriteLine(PrintNumber(1, N)); // Решение от преподавателя

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
void PrintNaturalToN(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Write($"{i} ");
        if (i % 10 == 0) WriteLine();
    }
}
void PrintRequrs(int num, int N)
{
    if (num == N + 1) return;
    Write($"{num} ");
    num++;
    PrintRequrs(num, N);
}
string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "  " + PrintNumber(start + 1, end));
}