// Задача 53
// Напишите программу, которая меняет местами првую и последнюю строку массива
// !!!В записи решается другая задача: меняются местами строки и столбцы!!!!


using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 10);

    PrintArray(array);
    ChangeLineArray(array);

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
//Замена первой и последней строк массива
void ChangeLineArray(int[,] inArray)
{
    int temp = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        temp = inArray[0, j];
        inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
        inArray[inArray.GetLength(0) - 1, j] = temp;
    }
}

//Создание двумерного массива 
int[,] GetArray(int rows, int colums, int max)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int znak = new Random().Next(0, 2);
            int el = new Random().Next(0, max + 1);
            result[i, j] = el * ((znak == 0) ? -1 : 1);
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