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
   
    int[] Array = GetArray(N, 1, 1000);

    WriteLine($"[{String.Join(",", Array)}]");

    int sum = GetCountInArray(Array);

    WriteLine($" Сумма нечетных элементов: {sum}");


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
//Поиск суммы элементов стоящх на нечетных позициях
int GetCountInArray(int[] inArray)
{
    int count = 0, sum=0;
    foreach (int item in inArray)
    {
        if (count%2==1)
        {
            sum+=item;
        }
        count++;
    }
    return sum;
}
