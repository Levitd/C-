// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите размер массивов через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 0;
    int maxElement = 10;
    int[,] array1 = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), minElement, maxElement);
    int[,] array2 = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), minElement, maxElement);

    WriteLine("Массив 1: ");
    PrintArray(array1);
    WriteLine("Массив 2: ");
    PrintArray(array2);
    WriteLine("Произведение 1 и 2 массивов: ");
    int[,] GenerationArray = GetGenerationArray(array1, array2);

    PrintArray(GenerationArray);
    
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
int[,] GetGenerationArray(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            result[i,j] = inArray1[i, j] * inArray2[i, j];
        }
    }
    return result;
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
