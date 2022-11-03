// Задача 49
// Задайте двумерный массив, Элементы с четным индексом возведем в квадрат



using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    WriteLine("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 20);

    PrintArray(array);
    SqrtArrayEven(array);
    WriteLine();
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

///Создание двумерного массива рандом
double[,] GetArray(int rows, int colums, int min, int max)
{
    double[,] result = new double[rows, colums];
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
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(3, ' ')} ");
        }
        WriteLine();
    }
}
// возведем в квадрат элементы массива, у которых оба индекса четные
void SqrtArrayEven(double[,] inArray)
{
    for (int i = 2; i < inArray.GetLength(0); i++)
    {
        for (int j = 2; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0
                && j % 2 == 0)
            {
                inArray[i, j] = Math.Pow(inArray[i, j], 2);
            }
        }
    }
}