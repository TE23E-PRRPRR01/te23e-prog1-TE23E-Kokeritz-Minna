// Slumpa många tal och spara i lista

Console.Clear();

//globala variabler
List<int> ListaSlumpTal = [];

// Ber användaren att ange antal sumpade tal 
Console.Write("Ange antal slumptal: ");
int antal = int.Parse(Console.ReadLine());

// Ber användaren att ange min o max värde
Console.Write("Ange ett min värde: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ange antal max värde: ");
int max = int.Parse(Console.ReadLine());

// loopar det antal många gånger 
for (int i = 0; i < antal; i++)
{
    // slumpa ett tal min-max
    int slumpTal = Random.Shared.Next(min, max + 1);

    //Lägg till i listan
    ListaSlumpTal.Add(slumpTal);

    Console.WriteLine(slumpTal);
}

foreach (var tal in ListaSlumpTal)
{
    Console.Write(tal + " ");
}