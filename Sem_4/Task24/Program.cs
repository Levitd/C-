using System;
using static System.Console;

Clear();

Write("Введите N: ");
int N=int.Parse(ReadLine());
int summa = GetSumNumbers(N);
WriteLine($"СУмма - {summa}");

int GetSumNumbers(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}