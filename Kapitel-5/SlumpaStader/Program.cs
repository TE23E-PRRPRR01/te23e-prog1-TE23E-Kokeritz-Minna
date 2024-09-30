
Console.Clear();
Console.WriteLine("Slumpa städer");

// Skapa en lista kort
List<string> kortlek = ["Toronta", "Otawa", "Krakow", "Stockholm", "Göteborg", "Yokohama", "Seul", "Washignton", "Kairo", "Wien", "Taliin", "Munchen", "Oslo"];

//slumpar ut 5 kort
for (int i = 0; i < 2; i++)
{
    //slumpa index 0-12
    int index = Random.Shared.Next(0, 13);
    string kort = kortlek[index];
    Console.WriteLine($"Din stad är {kort}");
}
