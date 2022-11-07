// Задача 59
// Удалить строку и колонку с минимальным элементовм в массиве  


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
    int[] IndexMinEl = GetMinIndex(array);
    WriteLine("Минимальный элемент - "+ array[IndexMinEl[0],IndexMinEl[1]].ToString()+" с координатами: " +String.Join(" ", IndexMinEl));
    WriteLine();

    int[,] newArray = DelRowColumnInArray(array, IndexMinEl);
    PrintArray(newArray);


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
//Удаление строки и колонки массва
int[,] DelRowColumnInArray(int[,] inArray, int[] inPoint)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i != inPoint[0])
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (j != inPoint[1])
                {
                    result[((i < inPoint[0]) ? i : i - 1), 
                           ((j < inPoint[1]) ? j : j - 1)] = inArray[i,j];
                }
            }
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
// Находим минимальны элемент
// Возврат массива с координатами найденного минимального элемента
int[] GetMinIndex(int[,] inArray)
{
    int minElement = inArray[0, 0];
    int[] indexMinElement = new[] { 0, 0 };
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < minElement)
            {
                minElement = inArray[i, j];
                indexMinElement = new[] { i, j };
            }
        }
    }
    return indexMinElement;
}