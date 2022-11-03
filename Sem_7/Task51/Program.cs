// Задача 51
// Задайте двумерный массив, Сумма элеметов на главной диагонали



using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    WriteLine("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);

    int sumElement = GetSumMainDiagonal(array);

    PrintArray(array);
    WriteLine($"Сумма элементов на главной диагонали: {sumElement}");

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
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(2, ' ')} ");
        }
        WriteLine();
    }
}
int GetSumMainDiagonal(int[,] inArray)
{
    int result = 0;
    int length = Math.Min(inArray.GetLength(0), inArray.GetLength(1));
    for (int i = 0; i < length; i++)
    {
        result += inArray[i, i];
    }
    return result;
}