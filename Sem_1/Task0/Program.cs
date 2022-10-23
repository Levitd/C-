Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
int sqr2 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа = {sqr}");
Console.WriteLine($"Квадрат числа = {sqr2}");