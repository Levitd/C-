using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

kratno(number);

void kratno(int num){
int ostatok1 = num % 7;
int ostatok2 = num % 23;


if (ostatok1 == 0 && ostatok2 == 0)
    WriteLine($"ДА! Число {num} кратно числам 7 и 23");
else
    WriteLine($"НЕТ Число {num} Не кратно одновременно числам 7 и 23.");
}
