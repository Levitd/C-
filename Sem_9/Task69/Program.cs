// Задача 69. Принимаем 2 числа, возводит число A в степень B.  Используем рекурсию


using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();
try
{
    Write("Возводим число A в степень B. Введите A и B через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine(DegreeNumber(int.Parse(nums[0]), int.Parse(nums[1])));
    WriteLine(Pow(int.Parse(nums[0]), int.Parse(nums[1])));

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

int DegreeNumber(int A, int B)
{
    if (B == 0) return 1;
    return (A* DegreeNumber(A, B-1));
}
//Метод от преподавателя
int Pow(int num,int st){
    if(st==0) return 1; //В данному случае это условие никогда не сработает, т.к. выход из рекурсии произойдет по следующему условию
    if(st==1) return num; 
    return (num*Pow(num, st-1));
}