// Задача 61
// Показать треугольник Паскаля  


using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите количество строк в треугольнике Паскаля: ");
    int rows = int.Parse(ReadLine());



    int[,] array = GetArray(rows);

    PrintTrianglePascal(array);

    WriteLine("Решение от Преподавателя:");
    PrintTriangle(rows);
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
/*catch
{
    Write("Ошибка выполнения!");
}*/
//Печать треугольника паскаля
void PrintTrianglePascal(int[,] inArray)
{
    int MyWindowWidth = Math.Max(WindowWidth - 1, 6);
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        SetCursorPosition(((MyWindowWidth - i * 4) / 2), i + 1);
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j <= i)
            {
                Write($"{inArray[i, j].ToString().PadLeft(2).PadRight(4)}");
            }
            else
            {
                continue;
            }
        }
        WriteLine();
    }
}

//Создание двумерного массива Паскаля 
int[,] GetArray(int rows)
{
    int[,] result = new int[rows, rows];
    result[0, 0] = 1;
    result[1, 0] = 1;
    result[1, 1] = 1;

    for (int i = 2; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j == 0 || j == i)
            {
                result[i, j] = 1;
            }
            else if (j < i)
            {
                result[i, j] = result[i - 1, j - 1] + result[i - 1, j];
            }
        }
    }
    return result;
}
int factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++)
        {
            Write("   ");
        }
        for (int c = 0; c <= i; c++)
        {
            Write("    ");
            Write(factorial(i) / (factorial(c) * factorial(i - c)));
        }
        WriteLine();
    }
}
