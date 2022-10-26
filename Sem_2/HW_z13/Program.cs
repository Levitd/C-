using System;
using static System.Console;

Clear();

Write("Введите число: ");
try
{
    int number = int.Parse(ReadLine());
    //Так как в условии нет, что заданное число положительное, а знак числа не является цифрой, то искать будем именно третью цифру.
    //Для этого будем оперировать абсолютным значением введеного числа 
    number = Math.Abs(number);

    int lenhgtNumber = number.ToString().Length; //Найдем разрядность введенного числа

    if (lenhgtNumber < 3)
    {
        WriteLine($"Третьей цифры нет");
    }
    else
    {

        while (lenhgtNumber > 3) //Пока число не станет трехзначным, будем делить его на 10
        {
            number = number / 10;
            lenhgtNumber--;
        }
        //Имеем трехзначное число, остаток от деления этого числа на 10 и будет искомое третье число от введенного
        WriteLine($"Третья цифра от введенного числа: {number % 10}");
    }
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели непонять что!");
}

