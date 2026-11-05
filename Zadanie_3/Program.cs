bool IsGameOver2 = false;
int sila = 20;
int bron = 50;
int pktZycia = 60;
int maksZdrowie = 100;
int zdrowiePrzeciwnika = 100;
while (!IsGameOver2)
{
    Console.WriteLine("Wybierz czynność: atak/leczenie");
    bool czynnoscWybrana = false;
    while (!czynnoscWybrana)
    {
        string czynnosc = Console.ReadLine()!;
        if (czynnosc == "atak")
        {
            int obrazenia = CalculateDamage(sila, bron);
            Console.WriteLine("Obrazenia: " + obrazenia);
            czynnoscWybrana = true;
            zdrowiePrzeciwnika -= obrazenia;
            Console.WriteLine("Pozostałe zdrowie przeciwnika: " + zdrowiePrzeciwnika);
        }
        else if (czynnosc == "leczenie")
        {
            pktZycia = Heal(pktZycia, maksZdrowie);
            czynnoscWybrana = true;
            Console.WriteLine("Punkty Życia: " + pktZycia);
        }
        else
        {
            Console.WriteLine("Czynność niedostępna");
        }
    }
    Console.WriteLine("Przeciwnik atakuje");
    Random rnd = new Random();
    int dmgPrzeciwnika = rnd.Next(1, 10);
    pktZycia -= dmgPrzeciwnika;
    Console.WriteLine("Punkty Życia: " + pktZycia);
    if (IsGameOver(pktZycia) == true || IsGameOver(zdrowiePrzeciwnika) == true)
    {
        IsGameOver2 = true;
    }
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

bool IsGameOver(int health)
{
    if (health <= 0)
    {
        Console.WriteLine("KONIEC WALKI");
        return true;
    }
    else
    {
        return false;
    }
}