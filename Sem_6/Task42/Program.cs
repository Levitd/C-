//Задача 42
//Десятичное число в двоичное

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите Десятичное число: ");
    int N = int.Parse(ReadLine());
    Write("Введите, в какую систему перевести: ");
    int Sys = int.Parse(ReadLine());

    string b1 = Convert.ToString(N, Sys);
    WriteLine($"{b1}");
    WriteLine($"{DecToNums(N, Sys)}");


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

string DecToNums(int Dec, int sys)
{
    string result = "";
    string chars = "0123456789ABCDEF";
    //while(Dec>0) //решение из семинара
    while (true)
    {
        /* решение из семинара
        int k=Dec/sys;
        int ost=Dec-k*sys;
        result=chars[ost].ToString()+result;
        Dec/=sys;
        */
        result = chars[(Dec % sys)].ToString() + result;
        Dec = Dec / sys;
        if (Dec < sys) return ((Dec > 0) ? chars[Dec].ToString() : "") + result;
    }
}