//Задача 35

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите кол-во элементов массива: ");
    int N = int.Parse(ReadLine());
    Write("Введите минимальный элементов массива: ");
    int min = int.Parse(ReadLine());
    Write("Введите максимальный элемент массива: ");
    int max = int.Parse(ReadLine());
    Write("Введите начало и конец отрезка через пробел: ");
    int[] ArrayLine = GetArrayString(ReadLine());
    int start = ArrayLine[0];
    int end = ArrayLine[1];

    int[] Array = GetArray(N, min, max);

    WriteLine($"[{String.Join(",", Array)}]");

    int countElementLine = GetCountInArray(Array, start, end);

    WriteLine($"В указанном отрезке {countElementLine} элементов.");

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

//Создание массива размером N элементов, полученных рандомно в указанном диапазоне
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
//Создание массива из строки, элементы через пробел
int[] GetArrayString(string strangArray)
{
    string[] nums = strangArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}
//Поиск кол-ва элементов массива лежащих в диапазоне
int GetCountInArray(int[] inArray, int n1, int n2)
{
    int result = 0;
    foreach (int item in inArray)
    {
        if (item >= n1 && item <= n2)
        {
            result++;
        }
    }
    return result;
}
