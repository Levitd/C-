// Задача 57
// Составить частотный словарь массива 


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
    int[] frequencyВictionary = GetfrequencyВictionary(array, minElement, maxElement);

    WriteLine();
    PrintFrequencyВictionary(frequencyВictionary);
    
    WriteLine("Ниже решение от преподавателя");
    int[] rowA=GetRowArray(array);
    SortArray(rowA);
    WriteLine(String.Join(" ", rowA));
    WriteLine();
    PrintData(rowA);

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
// Печать частотного словаря
void PrintFrequencyВictionary(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        string aEnding = "234";
        string ending = string.Empty;
        if (aEnding.IndexOf(inArray[i].ToString()) > -1) ending = "a";
        if (inArray[i] > 0) WriteLine($"{i.ToString().PadLeft(2)} - встречается {inArray[i].ToString().PadLeft(2)} раз{ending}.");
    }
}

//Заполнение частотного словаря массива
int[] GetfrequencyВictionary(int[,] inArray, int min, int max)
{
    int[] result = new int[max - min + 1];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[inArray[i, j]]++;
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
// 
int[] GetRowArray(int[,] inArray)
{
    int[] rowArray = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowArray[index] = inArray[i, j];
            index++;
        }
    }
    return rowArray;
}

void SortArray(int[] rowArray)
{
    for (int i = 0; i < rowArray.Length; i++)
    {
        for (int j = i + 1; j< rowArray.Length; j++)
        {
            if (rowArray[i] > rowArray[j])
            {
                int k = rowArray[i];
                rowArray[i] = rowArray[j];
                rowArray[j] = k;
            }
        }
    }
}
void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            WriteLine($"{el} встречается {count} раз");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count} раз");
}