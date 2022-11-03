// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


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

    Write("Введите позицию искомого элемента, через пробел : ");
    string[] foundElement = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arrayElement = new int[] { int.Parse(foundElement[0]), int.Parse(foundElement[1]) };

    PrintArray(array);

    double[] element = GetFoundElementInArray(array, arrayElement);

    if (element[0] > 0)
    {
        Write($"Значение искомого элемента: {element[1]}");
    }
    else
    {
        Write("По указанным координатм элемента в масиве нет!");
    }

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
double[] GetFoundElementInArray(double[,] inArray, int[] element)
{
    double[] result = new double[2];
    if (element[0] < inArray.GetLength(0)
        && element[1] < inArray.GetLength(1))
    {
        result[0] = 1;
        result[1] = inArray[element[0], element[1]];
    }
    else
    {
        result[0] = -1;
    }
    return result;
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
            double el = new Random().NextDouble();
            result[i, j] = Math.Round(el * max * ((znak == 0) ? -1 : 1), 2);
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