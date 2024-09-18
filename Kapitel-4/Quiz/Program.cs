// vill lägga till att frågorna är i sin egna funktion
// inte hårdkoda frågorna + classerna. 


using System.ComponentModel;
using System.Xml.Schema;


Console.Clear();

Console.WriteLine(@"
Det här är ett quiz om Star Wars (frågor tagna från random quiz på nätet)
Du får ett poäng för rätt svar och ett minus poäng för fel svar");
Console.ReadLine();

Console.WriteLine("Vad är ditt namn? ");
string namn = Console.ReadLine();

var foo = new Fråga();

int poäng;
int total;

int Rätta(char facit)
{

    Console.Write("Ditt svar: ");
    total++; // tar upp antal totalpoäng med 1

    //ser till att svaret är a, b eller c
    char svar = 'e'; // en random bokstav som inte är abc 

    do svar = char.Parse(Console.ReadLine().ToLower()); //läser in och registrerar svaret 
    while (svar != 'a' && svar != 'b' && svar != 'c'); // tills det är anitngen abc 

    if (svar == facit)
    {
        Console.WriteLine("Rätt svar");
        poäng++;
    }
    else
    {
        Console.WriteLine("Fel svar");
        poäng--;
    }
    return poäng;
}

// ger specifika responses beroende på hur många poäng du fick. Kan kägga till flera med flera else if
void respons(int slutpoäng)
{
    if (slutpoäng == total) Console.WriteLine("Alla rätt grattis!");
    else if (slutpoäng <= total / 2) Console.WriteLine(poäng + " är inte det värsta, men du kan göra bättre");
    else if (slutpoäng > total / 2) Console.WriteLine("Inte dåligt, inte dåligt, faktiskt ganska bra");
    else if (slutpoäng == 0) Console.WriteLine("Du är sämst.");
    else if (slutpoäng < 0) Console.WriteLine("Du lyckades få minuspoäng hur är det äns möjligt???");
}

// all kod som hanterar filavlästning har blivit hjälpt vid skrivningen av pappa
//Läser in frågan från en fil
var Frågor = new List<Fråga>();
foreach (var frågeRad in File.ReadLines("frågor.txt"))
{
    //delar upp frågan i delar 
    string[] frågeDelar = frågeRad.Split(',');
    //Console.WriteLine(string.Join(" --- ", frågeDelar));         kontrollerar att den delats upp 

    //anger varje del ett värde i fråga beroende på indexen. 
    Fråga lästFråga = new Fråga
    {
        frågeText = frågeDelar[0],
        altA = frågeDelar[1],
        altB = frågeDelar[2],
        altC = frågeDelar[3],
        facit = char.Parse(frågeDelar[4])
    };
    Frågor.Add(lästFråga); // lägger in den nya frågan i fråga listan. 
}

while (true)
{
    //resetar räknarna
    poäng = 0;
    total = 0;

    //skriver och rättar frågan. 
    foreach (var dennaFråga in Frågor)
    {
        dennaFråga.SkrivFråga();

        //ser till att svaret är a, b eller c
        char svar = 'e'; // en random bokstav som inte är abc 
        Console.Write("Ditt svar: ");
        do svar = char.Parse(Console.ReadLine().ToLower()); //läser in och registrerar svaret 
        while (svar != 'a' && svar != 'b' && svar != 'c'); // tills det är anitngen abc 

        if (dennaFråga.Rätta(svar) == true) poäng++;
        else poäng--;
        Console.WriteLine();
        total++;
    }
    //slut stadiet får respons beroende på procent av totalpoängen. 
    Console.WriteLine();
    Console.WriteLine($"Du fick {poäng} poäng av {total} möjliga ");
    respons(poäng);

    Console.WriteLine($"{namn} vill du spela igen? (ja/nej)");
    if (Console.ReadLine().ToLower() == "nej") break;
}



/*    
    Console.WriteLine(@"
Vem gjorde C-3P0? 
a) Anakin Skywalker
b) En nabooian servant
c) Cliegg Lars");
    Rätta('a');

    Console.WriteLine(@"
Ved hette Boba Fetts farkost? 
a) P-5000
b) Marauder
c) Slave 1");
    Rätta('c');


    Console.WriteLine(@"
Ved heter Darth Tyranus egentligen? 
a) Tera Sinube
b) Yan dooku
c) Sheev Palpatine");
    Rätta('b');
 */


/*  Console.WriteLine(@"
Vem är Hondo Ohnaka?
a) En Jedi
b) En Pirat
c) En senator");
 Rätta('b');

 Console.WriteLine(@"
Vilken klon lämnade armen? 
a) Cut
b) Ponds
c) Thire");
 Rätta('a'); */

/*   Console.WriteLine(@"
Vilket ckompani var Rex comandör i? 
a) 332nd
b) 501st
c) 212th");
  Rätta('a');

  Console.WriteLine(@"
Hur många medlemmar har jedirådet? 
a) 10
b) 6
c) 12");
  Rätta('c');
*/