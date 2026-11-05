bool isRunning = true;
string heroName = "blazej";
int health = 50;
int maxHealth = 100;
int gold = 1000;
while (isRunning)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    ShowPanelTitle(heroName, ConsoleColor.Red);
    isRunning = false;
}



void ShowStatus(string name, int health, int maxHealth, int gold)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("====================");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Imię Bohatera: {name}");
    Console.WriteLine($"Punkty Życia: {health}/{maxHealth}");
    Console.WriteLine($"Liczba Złota: {gold}");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("====================");
    Console.ResetColor();
}

void ShowMenu()
{
    Console.WriteLine("Trzy dostępne czynności:");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("ATAK");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("OBRONA");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("LECZENIE");
    Console.ResetColor();
}

void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = backgroundColor;
    Console.Write($" {title.ToUpper()} ");
    Console.ResetColor();
}