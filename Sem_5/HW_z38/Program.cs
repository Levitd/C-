//Задача 36

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

    WriteLine($"[{String.Join(",", Array)}]");

    int razn = GetMaxInArray(Array)-GetMinInArray(Array);

    WriteLine($" Разницв максимального и минимального элементов: {razn}");


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
//Поиск Максимального элемента массива
int GetMaxInArray(int[] inArray)
{
    int max=0;
    foreach (int item in inArray){
        if (item>max) max=item;
    }
    return max;
}
//Поиск Минимального элемента массива
int GetMinInArray(int[] inArray)
{
    int min=inArray[0];
    foreach (int item in inArray){
        if (item<min) min=item;
    }
    return min;
}

