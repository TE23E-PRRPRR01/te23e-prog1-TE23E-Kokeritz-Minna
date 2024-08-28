//Konverterar ett x antal sekunder till timmar minuter och sekunder

Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Ange ett antal sekunder");
String sekString = Console.ReadLine();

int sek = int.Parse(sekString);
int minut = sek/60;
int sekRemain = sek%60;
int timme = minut/60;
int minutRemain = minut%60;

Console.Write($"{sek} sekunder är ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(timme);
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" timmar ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write(minutRemain);
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" minuter och ");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(sekRemain);
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" sekunder");

//Console.WriteLine($"{sek} sekunder är {timme} timmar {minutRemain} minuter och {sekRemain} sekunder");