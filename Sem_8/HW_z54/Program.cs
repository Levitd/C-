// Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// !!! В примере показан массив упорядоченный по возрастанию !!!

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
    SortArray(array);
    
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
void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int max = inArray[i, inArray.GetLength(1)-1];
        int[] index = new[] { i, inArray.GetLength(1)-1};
        for (int s = 0; s < inArray.GetLength(1)-1 ; s++)
        {
            for (int j = inArray.GetLength(1)-2; j>=s  ; j--)
            {
                if ( inArray[i, j]<max)
                {  
                    int temp = inArray[i, j];
                    inArray[i, j] = max;
                    inArray[index[0], index[1]] = temp;
                } else {
                    max=inArray[i, j];
                    index[0] = i ;
                    index[1] = j ;
                }                 
            }
            max=inArray[i,inArray.GetLength(1)-1];
            index[0]=i;
            index[1]=inArray.GetLength(1)-1;
        }
    }
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
