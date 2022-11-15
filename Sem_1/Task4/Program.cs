using System;

Console.Clear();

Console.Write("Введите Трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int ostatok = number % 10;

    Console.WriteLine($"Последнее число: {ostatok}");
} else 
{
 Console.WriteLine($"Ввели не трехзначное число!");   
}
