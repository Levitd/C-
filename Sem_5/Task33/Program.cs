//Задача 33

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    WriteLine("Введите через пробел массив: ");
    int[] Array = GetArrayString(ReadLine());

    Write("Введите искомый элемент массива: ");
    int find = int.Parse(ReadLine());

    WriteLine($"[{String.Join(",", Array)}]");
 
    int findElement = FoundInArray(find, Array);
    if (FindElement(Array, find))
    {
        WriteLine($"Искомый элемент найден!");
    }
    else
    {
        WriteLine($"Искомый элемент не найден");
    }

    if (findElement != -1)
    {
        WriteLine($"Искомый элемент находится на {findElement} позиции в массиве");
    }
    else
    {
        WriteLine($"Искомый элемент не найден");
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
//Поиск в массиве и возврат индекса элемента
int FoundInArray(int find, int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] == find)
        {
            return i;
        }
    }
    return -1;
}
//Поиск элемента в массиве и ответ Да/Нет
bool FindElement(int[] inArray, int el)
{
    foreach (int item in inArray)
    {
        if (item == el)
        {
            return true;
        }
    }
    return false;
}