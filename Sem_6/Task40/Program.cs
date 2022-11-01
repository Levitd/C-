//Задача 40

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите длины сторон треугльника через пробел: ");
    int[] ArrayLine = GetArrayString(ReadLine());
    int A = ArrayLine[0];
    int B = ArrayLine[1];
    int C = ArrayLine[2];


    if (Treug(A,B,C)){
        WriteLine($"Да");
    } else {
        WriteLine($"Нет");
    }
    


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

bool Treug(int a, int b, int c)
{
    return (a+b>c && a+c>b && b+c>a);
}

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