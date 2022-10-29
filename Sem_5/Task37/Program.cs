//Задача 37

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите кол-во элементов массива, минимальный и максимальный элемет массива, через пробел: ");
    int[] ArrayLine = GetArrayString(ReadLine());
    int N = ArrayLine[0];
    int min = ArrayLine[1];
    int max = ArrayLine[2];

    int[] Array = GetArray(N, min, max);

    WriteLine($"[{String.Join(",", Array)}]");

    int[] mult = GetMultInArray(Array);

    WriteLine($"[{String.Join(",", mult)}]");


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
//Нахождение произведения пар чисел в массиве
int[] GetMultInArray(int[] inArray)
{
    int sizeMultArray = (inArray.Length % 2) == 0 ? inArray.Length / 2 : inArray.Length / 2 + 1; //Если кол-во элементов четное, новый массив половина от начального, если нечетное, то еще +1
    int[] multArray = new int[sizeMultArray];
    for (int i = 0; i < sizeMultArray; i++)
    {
        if (i >= inArray.Length - i - 1)
        {
            multArray[i] = inArray[i];
        }
        else
        {
            multArray[i] = inArray[i] * inArray[inArray.Length - i - 1];
        }
    }
    return multArray;
}

