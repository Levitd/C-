//Задача 34

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите кол-во элементов массива: ");
    int N = int.Parse(ReadLine());
   
    int[] Array = GetArray(N, 100, 1000);

    WriteLine($"[{String.Join(",", Array)}]");

    int count = GetCountInArray(Array);

    WriteLine($" Четных элементов: {count}");


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
//Поиск кол-ва четных элементов массива 
int GetCountInArray(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item%2==0)
        {
            count++;
        }
    }
    return count;
}
