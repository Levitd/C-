//Задача 41

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    WriteLine("Введите через пробел массив: ");
    int[] Array = GetArrayString(ReadLine());

    WriteLine($"[{String.Join(",", Array)}]");

    WriteLine($"Элементов больше 0:  {PositivInArray(Array)}");



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
//Подсчет кол-ва элементов больше 0
int PositivInArray(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}
