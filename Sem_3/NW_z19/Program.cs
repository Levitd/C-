using System.Text.RegularExpressions;
//Задача 20
using System;
using static System.Console;

Clear();

try
{
    Write("Введите пятизначное число: ");
    int N = Math.Abs(int.Parse(ReadLine()));

    if (N >= 10000 && N < 100000)
    {
        int n1=N/10000;
        int n2=N/1000%10;
        int n4=N/10%10;
        int n5=N%10;
        if (n1 == n5 && n2 ==n4){
            WriteLine($"{n1} = {n5} и {n4} = {n2}. Введенное число палиндром!");
        } else {
            WriteLine($"Введенное число не палиндром.");
        }
        
    }
    else
    {
        WriteLine($"Вы ввели не пятизначное число");
    }


}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

