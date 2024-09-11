//Konverterar ett x antal sekunder till timmar minuter och sekunder
void WriteInColor(int  tid, ConsoleColor color) {
    Console.ForegroundColor = color;
    Console.Write(tid);
    Console.ForegroundColor = ConsoleColor.White;
}

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

WriteInColor(timme,ConsoleColor.Blue );
Console.Write(" timmar ");

WriteInColor(minutRemain,ConsoleColor.Red);
Console.Write(" minuter och ");

WriteInColor(sekRemain,ConsoleColor.Green);
Console.Write(" sekunder");

//Console.WriteLine($"{sek} sekunder är {timme} timmar {minutRemain} minuter och {sekRemain} sekunder");

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.Write(timme);
//Console.ForegroundColor = ConsoleColor.Red;
//Console.Write(minutRemain);
//Console.ForegroundColor = ConsoleColor.Green;
//Console.Write(sekRemain);