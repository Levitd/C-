// Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);

    PrintArrayTwo(array);

    double[] sumColumsSrednee = GetSumColumsSrednee(array);
    WriteLine();
    PrintArray(sumColumsSrednee);

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

//Создание двумерного массива 
int[,] GetArray(int rows, int colums, int min, int max)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
//Печать двумерного массива
void PrintArrayTwo(int[,] inArray)
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
//Печать одномерного массива с форматированием
void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Write($"{Math.Round(inArray[i], 2).ToString().PadLeft(5, ' ')} ");
    }
}

double[] GetSumColumsSrednee(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    int length = Math.Min(inArray.GetLength(0), inArray.GetLength(1));
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sumColums = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j] += inArray[i, j];
        }
    }
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = result[i] / inArray.GetLength(0);
    }
    return result;
}