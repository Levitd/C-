Console.Clear();

Console.Write("Введите Числовое обозначение дня недели: ");
int number = int.Parse(Console.ReadLine());
string dayOfWeek = "";

switch (number) {
    case 1:
        dayOfWeek = "Понедельник";
        break;
    case 2:
        dayOfWeek = "Вторник";
        break;
    case 3:
        dayOfWeek = "Среда";
        break;
    case 4:
        dayOfWeek = "Черверг";
        break;
    case 5:
        dayOfWeek = "Пятница";
        break;
    case 6:
        dayOfWeek = "Суббота";
        break;
    case 7:
        dayOfWeek = "Воскресенье";
        break;
    default:
        dayOfWeek = "Введено не правильное значение дня недели! Допустимые значение от 1 до 7";
        break;
}

Console.WriteLine($"День недели : {dayOfWeek}.");

