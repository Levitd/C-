using System.Data;
//Задача 30

using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();

try
{
    Write("Введите кол-во элементов массива: ");
    int N = int.Parse(ReadLine());

    int[] ArrayBinar = GetRandomArrayBinar(N);

    WriteLine($"[{String.Join(",", ArrayBinar)}]");

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

int[] GetRandomArrayBinar(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
