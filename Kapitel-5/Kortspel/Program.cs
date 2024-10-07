Console.OutputEncoding = System.Text.Encoding.Unicode;

// hur man skapar och använder listor
Console.Clear();
Console.WriteLine("Slumpa kort ur ett kortlek");

// Skapa en lista kort
//List<string> kortlek = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];
List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];

//slumpar ut 5 kort
for (int i = 0; i < 5; i++)
{
    //slumpa index i kortleken
    int index = Random.Shared.Next(0, kortlek.Count);
    string kort = kortlek[index];
    Console.WriteLine($"Ditt kort är {kort}");
    //tar bort kortet  
    kortlek.RemoveAt(index);
}
