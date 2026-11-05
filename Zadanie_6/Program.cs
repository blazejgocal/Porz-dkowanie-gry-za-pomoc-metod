bool isRunning = true;
string heroName = "Blazej";
int health = 60;
int maxHealth = 100;
int gold = 200;
int strength = 20;
int weaponDamage = 10;
while (isRunning)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    string command = ReadCommand();

    if (command == "1")
    {
        int damage = CalculateDamage(strength, weaponDamage);
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        health = Heal(health, maxHealth);
        Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
    }
    else
    {
        isRunning = false;
    }
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
    Console.WriteLine("ODPOCZYNEK");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("KONIEC GRY");
    Console.ResetColor();
}

int CalculateDamage(int strenght, int weaponDamage)
{
    return strenght + weaponDamage;
}

int Heal(int health, int maxHealth)
{
    Random rnd = new Random();
    int amount = rnd.Next(15, 50);
    if (health + amount >= maxHealth)
    {
        health = maxHealth;
    }
    else
    {
        health += amount;
    }
    return health;
}

string ReadCommand()
{
    string command = " ";
    bool petla = true;
    while (petla)
    {
        Console.WriteLine("Wybierz czynność:");
        Console.WriteLine("[1] atak");
        Console.WriteLine("[2] odpoczynek");
        Console.WriteLine("[3] koniec gry");
        string? command2 = Console.ReadLine();
        if (command2 != "1" && command2 != "2" && command2 != "3")
        {
            Console.WriteLine("Nieprawidłowa czynność");
        }
        else
        {
            petla = false;
            command = command2;
        }
    }
    return command;
}