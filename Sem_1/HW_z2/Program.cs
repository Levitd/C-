using System;

Console.Clear();

Console.Write("Введите Первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите Второе число: ");
int number2 = int.Parse(Console.ReadLine());

int min =0, max=0, rav=0;

if (number1>number2) {
    min=number2;
    max=number1;
} else if (number1<number2) {
    min=number1;
    max=number2;
} else {
    rav=1;
}
if (rav == 1){
    Console.WriteLine("Введенные числа равны!");
} else {
    Console.WriteLine($"Число {max} больше чем {min}");
}
