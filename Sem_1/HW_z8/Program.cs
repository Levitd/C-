// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Введите Число: ");
int number = int.Parse(Console.ReadLine());
int startNumber = 2;

Console.WriteLine("");
while (startNumber <= number)
{
    if (startNumber != 2)
    {
        Console.Write(", ");
    }
    Console.Write(startNumber);
    startNumber = startNumber + 2;
}