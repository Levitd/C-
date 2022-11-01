//Задача 39

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

    WriteLine($"[{String.Join(",", ReversArray1(Array))}]");
    ReversArray2(Array);
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
int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
void ReversArray2(int[] inArray)
{
    int temp;
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}