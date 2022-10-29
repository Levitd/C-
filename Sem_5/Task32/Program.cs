//Задача 32

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


    int[] Array = GetArray(N, min, max);
    WriteLine($"[{String.Join(",", Array)}]");
    /*
        for (int i = 0; i < N; i++)
        {
            Array[i] = -Array[i];
        }
        */
    InversArray(Array);
    WriteLine($"[{String.Join(",", Array)}]");


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

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void InversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = -inArray[i];
    }
}