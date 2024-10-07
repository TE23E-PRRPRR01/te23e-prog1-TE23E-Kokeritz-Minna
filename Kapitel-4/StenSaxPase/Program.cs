//Avvancerat sten sax påse med fem alternativ. 

/*
Sten krossar sax
Sten krossar ödla
    Sax klipper papper
    Sax halshugger ödla
Påse täcker sten
Påse avvisar Spock
    Ödla äter papper
    Ödla förgiftar Spock
Spock krossar sax
Spock smälter sten
    neutralt mor själv
*/

using System.Collections.Specialized;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

string dataVal = "";
int poäng = 0;
int dataPoäng = 0;

while (true)
{

    string Val = "";
    int Nummer = Random.Shared.Next(1, 6); // ett random tal mellan alternativen. 

    //Enklare förståelse för vilken siffra korelare med vilket alternativ
    if (Nummer == 1) dataVal = "sten";
    else if (Nummer == 2) dataVal = "sax";
    else if (Nummer == 3) dataVal = "påse";
    else if (Nummer == 4) dataVal = "ödla";
    else if (Nummer == 5) dataVal = "spock";

    void vinst()
    {
        Console.WriteLine($"Datorn valde: {dataVal}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Val} vinner över {dataVal}, Grattis");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");
        poäng++;
    }
    void förlust()
    {
        Console.WriteLine($"Datorn valde: {dataVal}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{Val} förlora för {dataVal}, better luck next time");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");

        dataPoäng++;
    }
    void neutralt()
    {
        Console.WriteLine($"Datorn valde: {dataVal}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Det blev lika");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
    }

    while (Val != "sten" && Val != "sax" && Val != "påse" && Val != "ödla" && Val != "spock")
    {
        Console.WriteLine("Vad är ditt val (sten/sax/påse/ödla/spock)");
        Console.Write("Ditt val: ");
        Val = Console.ReadLine().ToLower();
    }

    switch (dataVal)
    {
        case "sten":
            if (Val == "sten") neutralt();
            else if (Val == "sax") förlust();
            else if (Val == "påse") vinst();
            else if (Val == "ödla") förlust();
            else if (Val == "spock") vinst();
            break;

        case "sax":
            if (Val == "sax") neutralt();
            else if (Val == "sten") vinst();
            else if (Val == "påse") förlust();
            else if (Val == "ödla") förlust();
            else if (Val == "spock") vinst();
            break;

        case "påse":
            if (Val == "påse") neutralt();
            else if (Val == "sax") vinst();
            else if (Val == "sten") förlust();
            else if (Val == "ödla") vinst();
            else if (Val == "spock") förlust();
            break;

        case "ödla":
            if (Val == "ödla") neutralt();
            else if (Val == "sax") förlust();
            else if (Val == "påse") vinst();
            else if (Val == "sten") vinst();
            else if (Val == "spock") förlust();
            break;

        case "spock":
            if (Val == "spock") neutralt();
            else if (Val == "sax") förlust();
            else if (Val == "påse") vinst();
            else if (Val == "ödla") vinst();
            else if (Val == "sten") förlust();
            break;

    }

    Console.WriteLine($"du har just nu {poäng} datorn har {dataPoäng}");
    Console.WriteLine("Om du vill avsluta skriv 'bryt'");

    if (Console.ReadLine().ToLower() == "bryt")
    {
        if (poäng > dataPoäng) Console.WriteLine("Du är den riktiga sten sax påse spock ödla mästaren.");
        else Console.WriteLine("Du blev precis besegrad av ett simpelt programm. Borde kanske kört några fler gånger");
        break;
    }
}