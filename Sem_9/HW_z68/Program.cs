// Задача 68. Вычисление формулы Анкермана. Используем рекурсию


using System.Text.RegularExpressions;
using System;
using static System.Console;

Clear();
try
{
    Write("Вычисление функции Анкермана. Введите m и n через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    WriteLine($"Значение функции Аккермана: {Akkernan(decimal.Parse(nums[0]), decimal.Parse(nums[1]))}");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
/*catch
{
    Write("Ошибка выполнения!");
}*/

decimal Akkernan(decimal m, decimal n)
{
    if (m == 0) return n+1;
    if (n ==0 && m>0) return Akkernan(m-1,1);
    if (m>0 && n>0) return Akkernan(m-1, Akkernan(m,n-1));
    else return 0;

}