//Program för att registrera förnamn och efternamn

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Sign in");

Console.Write("Ange Förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange Efternamn: ");
string efternamn = Console.ReadLine();

Console.WriteLine("Hej," + förnamn + " " + efternamn);
Console.ReadLine();


Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Log in");

Console.Write("Förnamn: ");
string logFörnamn = Console.ReadLine();
Console.Write("Efternamn: ");
string logEfternamn = Console.ReadLine();

if (logFörnamn==förnamn && logEfternamn ==efternamn)
{
    Console.WriteLine($"Välkommen {förnamn} {efternamn}");
}
else
{
    Console.WriteLine("Något gick fel, försök igen");
}