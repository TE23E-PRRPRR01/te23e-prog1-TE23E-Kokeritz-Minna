//admin från alla tillfällen + while loop + Meny
//ändra i frågorna
// ta bort fråga 

using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization;
using System.Xml.Schema;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

Console.WriteLine(@"
Det här är ett quiz om Star Wars (frågor tagna från random quiz på nätet)
Du får ett poäng för rätt svar och ett minus poäng för fel svar,
Om du har skrivit mer en än bokstav när du svarar kommer programmet räkna förstabokstaven som svaret");
Console.ReadLine();

Console.WriteLine("Vad är ditt namn? ");
string namn = Console.ReadLine();
int val = 0;


if (namn == "admin")
{
    while (val != 5)
    {
        Console.WriteLine("""
        Välkommen tillbaka admin; vad vill du göra?
        1) Läs upp frågorna  
        2) Lägg till en fråga
        3) Ändra en fråga 
        4) Ta bort en fråga
        5) Avsluta admin mode
        """);
        int.TryParse(Console.ReadLine(), out val);
        switch (val)
        {
            case 1:
                LäsInFråga();
                break;

            case 2:
                AdminNyFråga();
                break;

            case 3:
                AdminÄndraFråga();
                break;

            case 4:
                Console.WriteLine("denna kod är inte skriven ignorera den i all framtid ");
                break;

            case 5:
                Console.WriteLine("Din tid i admin mode är slut, vad är ditt namn Admin?");
                namn = Console.ReadLine();
                break;

            default:
                Console.WriteLine("ogilitigt svar");
                break;
        }

    }
}
//if (namn == "admin") LäsInFråga();
//if (namn == "admin") AdminNyFråga();
//if (namn == "admin") AdminÄndraFråga();

Console.WriteLine();

var foo = new Fråga();

int poäng;
int total;

// ger specifika responses beroende på hur många poäng du fick. Kan kägga till flera med flera else if
void respons(int slutpoäng)
{
    if (slutpoäng == total) Console.WriteLine("Alla rätt grattis!");
    else if (slutpoäng == 0) Console.WriteLine("Du är sämst.");
    else if (slutpoäng < 0) Console.WriteLine("Du lyckades få minuspoäng hur är det äns möjligt???");
    else if (slutpoäng <= total / 2) Console.WriteLine(poäng + " är inte det värsta, men du kan göra bättre");
    else if (slutpoäng > total / 2) Console.WriteLine("Inte dåligt, inte dåligt, faktiskt ganska bra");
}

void LäsInFråga()
{
    var frågor = new List<string>(File.ReadLines("frågor.txt"));
    for (int i = 0; i < frågor.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {frågor[i]}");
    }
    Console.ReadLine();
}

void AdminNyFråga()
{
    Console.Write(@"Skriv frågan i detta format: {frågetext?},{altA},{altb},{altc},{facit(a/b/c)}
    NyFråga: ");

    while (true)
    {
        string nyFråga = Console.ReadLine();

        string[] delar = nyFråga.Split(',');
        if (delar.Length == 5 && (delar[4] == "a" || delar[4] == "b" || delar[4] == "c"))
        {
            File.AppendAllText("frågor.txt", nyFråga + Environment.NewLine);
            Console.WriteLine("Frågan har lagts till");
            Console.WriteLine();
            break;
        }
        else Console.WriteLine("Formatet är fel, var vänlig försök igen");

    }

}

void AdminÄndraFråga()
{
    var frågor = new List<string>(File.ReadLines("frågor.txt"));
    Console.WriteLine("Välj en rad att ändra på. (ange radnummret)");
    Console.WriteLine();

    for (int i = 0; i < frågor.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {frågor[i]}");
    }


    int valdRad = int.Parse(Console.ReadLine());
    if (valdRad > 0 && valdRad < frågor.Count + 1)
    {
        while (true)
        {

            Console.WriteLine("skriv in den nya frågan");
            string ändradFråga = Console.ReadLine();
            frågor[valdRad - 1] = ändradFråga;

            string[] delar = ändradFråga.Split(',');
            if (delar.Length == 5 && (delar[4] == "a" || delar[4] == "b" || delar[4] == "c"))
            {
                File.WriteAllLines("frågor.txt", frågor);
                Console.WriteLine("Frågan har ändrats");
                Console.WriteLine();
                break;
            }
            else Console.WriteLine("Formatet är fel, var vänlig försök igen");
        }
    }
    else Console.WriteLine("Ogiltigt svar");
}

// nästan all kod som hanterar filavlästning har blivit hjälpt vid skrivningen av min pappa och chat gpt

//Läser in frågan från en fil
var frågor = new List<Fråga>();
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
    frågor.Add(lästFråga); // lägger in den nya frågan i fråga listan. 
}


while (true)
{
    //resetar räknarna
    poäng = 0;
    total = 0;

    //skriver och rättar frågan. 
    foreach (var dennaFråga in frågor)
    {
        dennaFråga.SkrivFråga();

        //ser till att svaret är a, b eller c
        char svar = 'e'; // en random bokstav som inte är abc 
        Console.Write("Ditt svar: ");

        //while(svar != 'a' && svar != 'b' && svar != 'c')svar = char.Parse(Console.ReadLine().Substring(0, 1).ToLower()); // fungerar gillar dock andra bättre.
        do svar = char.Parse(Console.ReadLine().Substring(0, 1).ToLower()); //läser in och registrerar svaret samt klipper bort alla bokstäver förutom dem första 
        while (svar != 'a' && svar != 'b' && svar != 'c'); // tills det är anitngen abc  // fungerar halft kan hantera mer än en karaaktär men inskrvivningen blir funky. 

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