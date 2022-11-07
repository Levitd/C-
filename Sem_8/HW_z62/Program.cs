// Задача 62
//  Заполните спирально массив 4 на 4.

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;
using System.Diagnostics;
{

}

Clear();
try
{
    Write("Введите размер квадратного массива: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    int[,] array = GetArray(int.Parse(nums[0]));

    PrintArray(array);

    stopwatch.Stop();
    Console.WriteLine($"Затраченное время: {1000L * 1000L * stopwatch.ElapsedTicks / Stopwatch.Frequency}(мкс).");


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

//Создание двумерного массива c заполнением по спирали числами с 1.
int[,] GetArray(int rows)
{
    int[,] result = new int[rows, rows];
    int i = 0, j = 0;
    int number = 1;
    
    int minX = 0;
    int minY = 0;
    int maxX = result.GetLength(0);
    int maxY = result.GetLength(1);
    while (minX < maxX)
    {
        while (j < maxY)
        {
            result[i, j] = number;
            number++;
            j++;
        }
        j--;
        i++;
        while (i < maxX)
        {
            result[i, j] = number;
            number++;
            i++;
        }
        i--;
        j--;
        while (j >= minY)
        {
            result[i, j] = number;
            number++;
            j--;
        }
        i--;
        j++;
        while (i > minY)
        {
            result[i, j] = number;
            number++;
            i--;
        }
        i++;
        j++;
        minX++;
        minY++;
        maxX--;
        maxY--;
    }
    return result;
}

//Печать двумерного массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(5, ' ')} ");
        }
        WriteLine();
    }
}

