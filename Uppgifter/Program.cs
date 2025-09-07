while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Välj vilken triangel du vill testa:");
    Console.WriteLine();

    WriteOption(1, "Vänsterjusterad rätvinklig triangel");
    WriteOption(2, "Högerjusterad rätvinklig triangel");
    WriteOption(3, "Likbent triangel");

    Console.WriteLine();

    switch (GetChoice())
    {
        case 1:
            var size1 = GetInt("Storlek");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Triangle1.CreateWithSize(size1));
            PressAnyToContinue();
            break;

        case 2:
            var size2 = GetInt("Storlek");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Triangle2.CreateWithSize(size2));
            PressAnyToContinue();
            break;

        case 3:
            var size3 = GetInt("Storlek");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Triangle3.CreateWithSize(size3));
            PressAnyToContinue();
            break;
    }
}

void WriteOption(int number, string description)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($" {number}");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(": ");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine(description);
}

string GetString(string label)
{
    Console.Write(label);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write(": ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    var input = Console.ReadLine() ?? "";
    Console.ForegroundColor = ConsoleColor.Gray;
    return input;
}

int GetChoice()
{
    var input = GetString("Val");
    if (input == "1" || input == "2" || input == "3")
    {
        return input[0] - '0';
    }
    return 0;
}

int GetInt(string label)
{
    var top = Console.CursorTop;
    while (true)
    {
        var rawValue = GetString(label);
        if (int.TryParse(rawValue, out var parsedValue))
        {
            return parsedValue;
        }
        Console.CursorTop = top;
        Console.CursorLeft = 0;
        Console.Write(new string(' ', rawValue.Length));
        Console.CursorLeft = 0;
    }
}

void PressAnyToContinue()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Tryck valfri tangent för att fortsätta...");
    Console.ReadKey(true);
}
