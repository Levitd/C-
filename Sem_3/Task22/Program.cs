using System.Text.RegularExpressions;
//Задача 20
using System;
using static System.Console;

Clear();

try
{
    Write("Введите число больше 0: ");
    int N = Convert.ToInt32(ReadLine());
    printPow(N);
    
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

void printPow (int num) {
    string powN =  "";

    for (int i=1; i<=num; i++){
        powN = powN + ((powN!="") ? ", " :"") +Math.Pow(i,2);
    }

     WriteLine($"{num}-> {powN}.");
}
//$("\b\b") - \b удаляет 1 символ
