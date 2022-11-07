// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 0;
    int maxElement = 10;
    int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), minElement, maxElement);

    PrintArray(array);
    int MinRow = GetMinRowSumArray(array);

    WriteLine($"Минимальная сумма в строке: {MinRow}");
    


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
int GetMinRowSumArray(int[,] inArray)
{
    int minSum=0;
    int sumRow =0; 
    int row = -1;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int s = 0; s < inArray.GetLength(1) - 1; s++)
        {
            sumRow += inArray[i, s];
        }
        if (minSum > sumRow || i==0) 
        {
            minSum= sumRow;
            row=i;
        }
        sumRow=0;
    }
    return row;
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
