List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };

List<string> longNames = inventory.FindAll(item => item.Length >= 5);
bool hasPotion = inventory.Exists(item => item == "miecz");

Console.WriteLine(hasPotion);
for (int i = 0; i < longNames.Count; i++)
{
    Console.WriteLine(longNames[i]);
}