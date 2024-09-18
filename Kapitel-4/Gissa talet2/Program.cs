//ett litet spel -gissa ett hemligt heltal 
using System.ComponentModel.DataAnnotations;
using System.Globalization;

Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");

int min;
int max;

do
{
    Console.Write("Var god ange min värde:");
    min = int.Parse(Console.ReadLine());

    Console.Write("Var god ange max värde:");
    max = int.Parse(Console.ReadLine());

    if (min >= max) Console.WriteLine("min måste vara mindre en max");
    Console.WriteLine();

} while (min >= max);

int Vinstnr = Random.Shared.Next(min, max + 1);
int gissning;
int gissAntal = 0;

while (true)
{
    Console.WriteLine($"Gissa ett tall {min}-{max}");
    //string gissningString = Console.ReadLine();
    gissning = int.Parse(Console.ReadLine());
    gissAntal += 1;

    if (gissning == Vinstnr)
    {
        Console.WriteLine("Du gissade rätt");
        break;
    }

    else if (gissning > max || gissning < min) Console.WriteLine("Du kan inte förstå instruktioner");

    else
    {
        if (gissning > Vinstnr) Console.WriteLine($"{gissning} är för högt");
        if (gissning < Vinstnr) Console.WriteLine($"{gissning} är för lågt");


        //extra del om man vill bli frågad att avbryta har kommenterats bort för den var jobbig men fungerar
        //Console.WriteLine("vill du gissa igen? (ja/nej)");
        //if (Console.ReadLine().ToLower() == "nej") break;

    }
}
Console.WriteLine($"tack för att du spelade du gissade {gissAntal} gr");