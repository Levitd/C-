//Задача 43
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

//x=(b2-b1)/(k1-k2)
//y=k1*x+b1

//Если подставить введенные данные в исходные формулы, то ответ -0,5; -0,5
//Откуда взяли У=5,5 не знаю

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    WriteLine("Ищем точку пересечения двух прямых заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2");
    WriteLine("Введите через пробел числа b1 k1 b2 k2: ");
    decimal[] Array = GetArrayString(ReadLine());

    WriteLine($"{String.Join(" ", Array)}");

    decimal[] pointOfCross = getPointOfCross(Array);

    WriteLine($"Пересекутся в точке: {String.Join(" ", pointOfCross)}");



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

//Создание массива из строки, элементы через пробел
decimal[] GetArrayString(string strangArray)
{
    string[] nums = strangArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    decimal[] result = new decimal[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}
//Решение упавнения
decimal[] getPointOfCross(decimal[] a)
{   //0  1  2  3
    //2  5  4  9
    //b1 k1 b2 k2
    //x=(b2-b1)/(k1-k2)
    //y=k1*x+b1
    decimal[] xy = new decimal[2];
    xy[0] = ((a[2] - a[0]) / (a[1] - a[3]));
    xy[1] = a[1] * xy[0] + a[0];
    return xy;

}
