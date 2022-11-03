// Задача 48
// Задайте двумерный массив, Элемен Amn=m+n



using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    WriteLine("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]));

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

//Создание двумерного массива Элемент Amn=m+n
int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = i + j;
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