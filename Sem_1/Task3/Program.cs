Console.Clear();

Console.Write("Введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = -number;

Console.WriteLine("");
while (startNumber <= number){
    if (startNumber != -number){
        Console.Write(", ");
    }
    Console.Write(startNumber);
    startNumber++;
}