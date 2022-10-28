//Задача 26

using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число: ");
    int N = int.Parse(ReadLine());

    int countNumber=GetCountNumbers(N);

     WriteLine($"Цифр в числе: {countNumber}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}

int GetCountNumbers(int number){
    number = Math.Abs(number);
    int lenghtNum= number.ToString().Length;
    return lenghtNum;
    /*
    Вариант решения из семинара
    int count=0
    while (number>0){
        count++;
        number/=10;
    }
    return count;
    */
}