//Задача 45

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите кол-во элементов массива: ");
    int N = int.Parse(ReadLine());

    int[] Array = GetArray(N, 1, 100);
    int[] copyArray = CopyArray(Array);

    WriteLine($"[{String.Join(",", Array)}]");
    WriteLine($"[{String.Join(",", copyArray)}]");

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
int[] CopyArray(int[] inArray)
{
    int[] newArray = new int[inArray.Length];
    for (int i=0; i < inArray.Length; i++)
    {
        newArray[i] = inArray[i];
    }
    return newArray;
}