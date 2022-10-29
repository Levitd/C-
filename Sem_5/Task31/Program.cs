//Задача 31

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    //Write("Введите кол-во элементов массива: ");
    //int N = int.Parse(ReadLine());

    int[] Array = GetArray(12, -9, 9);
    int positivSum = 0;
    int negativSum = 0;

    foreach (int item in Array)
    {
        Write($"{item} ");
        if(item>0){
            positivSum+=item;
        } else {
            negativSum+=item;
        }
    }

    WriteLine($"[{String.Join(",", Array)}]");

    WriteLine($"Сумма положительных элементов: {positivSum}");
    WriteLine($"Сумма Отрицательных элементов: {negativSum}");

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