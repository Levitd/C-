using System.Text.RegularExpressions;
//Задача 20
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число больше 0: ");
    int N = int.Parse(ReadLine());

    string powN =  "";

    for (int i=1; i<=N; i++){
        powN = powN + ((powN!="") ? ", " :"") +Math.Pow(i,2);
    }

     WriteLine($"{powN}");
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

