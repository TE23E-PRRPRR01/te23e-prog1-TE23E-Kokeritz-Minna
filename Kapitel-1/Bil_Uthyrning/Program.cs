//Program för att beräkna kostnaden för att hyra bil hos en biluthyrningsfirma.
//Startavgiften är 500 kr
//Kostnaden per mil är 5 kr
//Kostnad per dag är 100 kr

Console.Clear();

Console.Write("Hur många mil har du kört? ");
String milString = Console.ReadLine();
Console.Write("Hur många dagar har du kört? ");
String dagString = Console.ReadLine();

int mil = int.Parse(milString);
int dag = int.Parse(dagString);
int milKost = mil * 5;
int dagKost = dag * 100;

int kostnad = 500 + milKost + dagKost;

Console.WriteLine($"Din totala kostnad är {kostnad} kr");