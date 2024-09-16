//ett litet spel -gissa ett hemligt heltal 
using System.Globalization;

Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");

Console.Write("Var god ange min värde:");
int min = int.Parse(Console.ReadLine());

Console.Write("Var god ange max värde:");
int max = int.Parse(Console.ReadLine());

int Vinstnr = Random.Shared.Next(min, max+1);
int gissning;
int gissAntal = 0;

while (true)
{
    Console.WriteLine($"Gissa ett tall {min}-{max}");
    //string gissningString = Console.ReadLine();
    gissning = int.Parse(Console.ReadLine());
    gissAntal +=1;

    if (gissning == Vinstnr) {
        Console.WriteLine("Du gissade rätt"); 
        break;
    }

    else if (gissning > max || gissning < min) Console.WriteLine("Du kan inte förstå instruktioner");

    else
    {
        if (gissning > Vinstnr) Console.WriteLine($"{gissning} är för högt");
        if (gissning < Vinstnr) Console.WriteLine($"{gissning} är för lågt");


        Console.WriteLine("vill du gissa igen? (ja/nej)");
        if (Console.ReadLine().ToLower() == "nej") break;
        
    }
}
Console.WriteLine($"tack för att du spelade du gissade {gissAntal} gr");