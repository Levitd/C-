Console.Clear();

Console.Write("Введите Первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите Второе число: ");
int number2 = int.Parse(Console.ReadLine());

int sqr = Convert.ToInt32(Math.Pow(number1,2));

if (sqr == number2) {
    Console.WriteLine($"Правильно, число {number2} является квадратом числа {number1}");
} else {
    Console.WriteLine($"Не Правильно!!! Число {number2} Не является квадратом числа {number1}");
    Console.WriteLine($"Квадрат числа {number1} будет  {sqr}");
}
