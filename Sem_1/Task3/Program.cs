Console.Clear();

Console.Write("Введите Число: ");
int number = int.Parse(Console.ReadLine());
int startNumber = -number;

Console.WriteLine("");
while (startNumber <= number){
    if (startNumber != -number){
        Console.Write(", ");
    }
    Console.Write(startNumber);
    startNumber++;
}