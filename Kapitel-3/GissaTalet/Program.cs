//ett litet spel -gissa ett hemligt heltal 
Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");
int Vinstnr = Random.Shared.Next(1, 101);
int gissning;

do
{
    Console.WriteLine("Gissa ett tall 1-100");
    //string gissningString = Console.ReadLine();
    gissning = int.Parse(Console.ReadLine());

    if (gissning == Vinstnr) Console.WriteLine("Du gissade rätt");

    else if (gissning > 100) Console.WriteLine("Du kan inte förstå instruktioner");

    else
    {
        if (gissning > Vinstnr) Console.WriteLine($"{gissning} är för högt");
        if (gissning < Vinstnr) Console.WriteLine($"{gissning} är för lågt");
    }
} while (gissning != Vinstnr);