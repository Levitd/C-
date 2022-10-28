//Задача 26

using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число: ");
    int N = int.Parse(ReadLine());

    int sumNumber=GetSumNumbers(N);

     WriteLine($"Сумма Цифр в числе: {sumNumber}");
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}

int GetSumNumbers(int number){
    number = Math.Abs(number);
    int lenghtNum= number.ToString().Length;

    int sum=0;
    while (number>0){
        sum=sum+number%10;
        number/=10;
    }
    return sum;
}