using System.Diagnostics;
// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;
using System.Diagnostics;
{
    
}

Clear();
try
{
    Write("Введите размер Трехмерного массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 10;
    int maxElement = 99;
    int notRepeat = 1;
    if (notRepeat == 1)
    {
        int countElemen = int.Parse(nums[0]) * int.Parse(nums[1]) * int.Parse(nums[2]);
        if (countElemen > (maxElement - minElement))
        {
            WriteLine("Создаваемый массив больше чем заданное кол-во уникальных элементов");
            return;
        }
    }
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    int[,,] array = GetArray3x(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), minElement, maxElement, notRepeat);

    PrintArray3x(array);

    stopwatch.Stop();
    Console.WriteLine($"Затраченное время: {1000L*1000L*stopwatch.ElapsedTicks/Stopwatch.Frequency}(мкс).");


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

//Создание трехмерного массива 
int[,,] GetArray3x(int x, int y, int z, int min, int max, int notRepeat)
{
    int[,,] result = new int[x, y, z];
    string el = string.Empty;
    int foundEl = -1;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                while (true)
                {
                    result[i, j, k] = new Random().Next(min, max + 1);
                    if (notRepeat == 1)
                    {
                        foundEl = el.IndexOf(result[i, j, k].ToString());
                        if (foundEl == -1) break;
                    }
                    else break;
                }
                el += result[i, j, k].ToString() + ", ";
            }
        }
    }
    return result;
}

//Печать трехмерного массива
void PrintArray3x(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k].ToString().PadLeft(2, ' ')}({i},{j},{k}) ");
            }
        }
        WriteLine();
    }
}
