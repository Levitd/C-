// SIF
Console.Write("Введите имя пользователя:");

string? username = Console.ReadLine();

    if (username?.ToLower() == "dim")
    {
        Console.Write("Ура, это же Dim!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.Write(username);
    }
