bool petla = true;
string komenda = " ";
while (petla)
{
    Console.WriteLine("Wybierz opcję");
    Console.WriteLine("[1] atak");
    Console.WriteLine("[2] obrona");
    Console.WriteLine("[3] leczenie");
    komenda = Console.ReadLine();
    if (komenda != "1" && komenda != "2" && komenda != "3")
    {
        Console.WriteLine("Zła komenda");
    }
    else
    {
        petla = false;
    }
}
ReadCommand(komenda);

void ReadCommand(string command)
{
    if (command == "1")
    {
        Console.WriteLine("Wybrano Atak");
    }
    else if (command == "2")
    {
        Console.WriteLine("Wybrano Obronę");
    }
    else
    {
        Console.WriteLine("Wybrano Leczenie");
    }
}
