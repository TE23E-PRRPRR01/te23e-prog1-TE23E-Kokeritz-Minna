/******************************************************
*********************** M A I N ***********************
*******************************************************/
using System.Xml.Serialization;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

List<string> ordspråkLista = [];
string filnamn = "ordsprak.txt";
int menyVal = -1;

ordspråkLista = LäsOrdspråk(filnamn, ordspråkLista);

while (menyVal != 0)
{
    VisaMeny();
    menyVal = HeltalParse();
    Console.Clear();

    switch (menyVal)
    {
        case 1: // spara 
            SkrivOrdspråk(ordspråkLista);
            SparaAllaOrdspråk(false, filnamn, ordspråkLista);
            LäsOrdspråk(filnamn,ordspråkLista);

            GåVidare();
            break;

        case 2: // läs alla
            ListaOrdspråk(ordspråkLista, false);

            GåVidare();
            break;

        case 3: // slumpa 
            SlumpaOrdspråk(ordspråkLista);
            GåVidare();
            break;

        case 4: //sök
            SökOrdspråk(ordspråkLista);
            GåVidare();
            break;

        case 5:
            ListaOrdspråk(ordspråkLista, true);
            Console.WriteLine("---- Vilken rad ska raderas ----");
            int rad = HeltalParse();
            ordspråkLista = RaderaOrdspråk(ordspråkLista, rad-1); 
            SparaAllaOrdspråk(false, filnamn, ordspråkLista);
            LäsOrdspråk(filnamn, ordspråkLista);

            break;

        case 0: //avsluta 
            Console.WriteLine("---- Loggar ut ----");
            break;


        default:
            Console.WriteLine("Fel: Ogilitigt alternativ");
            break;
    }
}


/*******************************************;***********
********************* M E T O D E R *******************
*******************************************************/

static int HeltalParse()
{
    int heltal;
    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades) break;
        else Console.WriteLine("Fel: Inte ett heltal");
    }
    return heltal;
}

static void GåVidare()
{
    Console.ReadLine();
    Console.Clear();
}

static void VisaMeny()
{
    Console.WriteLine("""
            ------- MENY -------
            1. Spara Ordspråk
            2. Läs alla Ordspråk
            3. Slumpa fram ett Ordspråk 
            4. Sök efter Ordspråk
            5. Raddera ett Ordspråk 
            0. Avlsuta
            --------------------
            """);
}

/// <summary>
/// Spara alla ordspråk som finns i listan till txt filen
/// </summary>
/// <param name="text">ska texten visas</param>
/// <param name="filnamn"> filnmanet</param>
/// <param name="Lista"> ordspråk lista</param>
static void SparaAllaOrdspråk(bool text, string filnamn, List<string> Lista)
{
    File.WriteAllLines(filnamn, Lista);
    if (text) Console.WriteLine("---- Alla ordspråk har sparats ----");
}


/// <summary>
/// Skriver in ett nytt ordspråk i en lista
/// </summary>
/// <param name="Lista">ordspråkslistan</param>
static void SkrivOrdspråk(List<string> Lista)
{
    Console.WriteLine("---- Skriv in ett ordspråk -----");
    string nyttOrdspråk = Console.ReadLine();
    Lista.Add(nyttOrdspråk);
    Console.WriteLine("---- Ordspråk har lagts till ----");
}


/// <summary>
/// läser upp alla ordspråk i listan
/// </summary>
/// <param name="Lista"> ordspråkslistan</param>
/// <param name="numrering">ska sen ha numrering eller inte </param>
static void ListaOrdspråk(List<string> Lista, bool numrering)
{
    Console.WriteLine("---- Lista på alla ordspråk ----");
    if (numrering == false) foreach (var ordspråk in Lista) Console.WriteLine("- " + ordspråk);
    if (numrering == true)
    for (int i = 0; i < Lista.Count(); i++) Console.WriteLine($"{i+1} {Lista[i]}");

    Console.WriteLine("--------------------------------");
}

/// <summary>
/// Slumpa ut ett nytt ordspråk 
/// </summary>
/// <param name="Lista">ordsrpåkslistan</param>
static void SlumpaOrdspråk(List<string> Lista)
{
    int slumptal = Random.Shared.Next(0, Lista.Count());
    Console.WriteLine("---- Slumpat Ordspråk ----");
    Console.WriteLine(Lista[slumptal]);
}

/// <summary>
/// söker efter ett ordspråk från listan med ett sökord. 
/// </summary>
/// <param name="Lista"></param>
static void SökOrdspråk(List<string> Lista)
{

    int räknare = 0;
    Console.WriteLine("---- Ange sökterm ----");
    string sökterm = Console.ReadLine();
    foreach (var ordspråk in Lista)
    {
        if (ordspråk.ToLower().Contains(sökterm) == true) Console.WriteLine("- " + ordspråk);
        else räknare ++;
    }

    if (räknare == Lista.Count()) Console.WriteLine("---- Inga ordsrpåk hittade ----");
}

/// <summary>
/// Radera ett ordsrpåk från listan
/// </summary>
/// <param name="Lista">ordsrpåk</param>
/// <param name="rad">rad</param>
/// <returns></returns>
static List<string> RaderaOrdspråk(List<string> Lista, int rad)
{
    Lista.RemoveAt(rad);
    Console.WriteLine("---- Ordspråkets har raderats ----");
    return Lista;
}


/// <summary>
/// Läs in alla ordspråk från txt filen och spara i listan. 
/// </summary>
/// <param name="filnamn"> filnamnet </param>
/// <param name="Lista">ordsrpåkslistan</param>
/// <returns></returns>
static List<string> LäsOrdspråk(string filnamn, List<string> Lista)
{
    if (File.Exists(filnamn))Lista = File.ReadAllLines(filnamn).ToList();
    else Console.WriteLine("Fel: fil finns inte ");

    return Lista;
} 




