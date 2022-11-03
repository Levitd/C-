// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 10);

    PrintArray(array);

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
double[,] GetArray(int rows, int colums, int max)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int znak = new Random().Next(0, 2);
            double el = new Random().NextDouble() ;
            result[i, j] = Math.Round(el* max * ((znak==0) ? -1 : 1), 2);
        }
    }
    return result;
}
//Печать двумерного массива
void PrintArray(double[,] inArray)
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