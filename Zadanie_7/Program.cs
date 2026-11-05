//przykład
int Heal(int health, int amount) => health + amount;
Heal(health, 10);

//poprawka
int Heal(int health, int amount) => health + amount;
health = Heal(health, 10);



//przykład
if (health < 20)
{
    string warning = "Mało zdrowia!";
}

Console.WriteLine(warning);

//poprawka
string warning = " ";
if (health < 20)
{
    warning = "Mało zdrowia!";
}

Console.WriteLine(warning);



//przykład
int CalculateDamage(int strength, int weaponDamage)
{
    Console.Write("Czy chcesz zaatakować? ");
    string? answer = Console.ReadLine();
    Console.WriteLine("Rozpoczynam animację ataku...");
    return strength + weaponDamage;
}

//poprawka
int CalculateDamage(int strength, int weaponDamage)
{
    Console.Write("Czy chcesz zaatakować? ");
    string? answer = Console.ReadLine();
    int damage = 0;
    if (answer == "tak")
    {
        Console.WriteLine("Rozpoczynam animację ataku...");
        damage = strength + weaponDamage;
    }
    else
    {
        Console.WriteLine("Nie wykonano ataku.");
    }
    return damage;
}



//przykład
