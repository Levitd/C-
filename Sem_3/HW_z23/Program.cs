using System.Text.RegularExpressions;
//Задача 20
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число больше 0: ");
    int N = int.Parse(ReadLine());

    string pow3N =  "";

    for (int i=1; i<=N; i++){
        pow3N = pow3N + ((pow3N!="") ? ", " :"") +Math.Pow(i,3);
    }

     WriteLine($"{pow3N}");
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

