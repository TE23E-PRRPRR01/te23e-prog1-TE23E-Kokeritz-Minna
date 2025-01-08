Console.Clear();

SägHej();
VisaMeny();

/****************************************************
*************************METODER*********************
****************************************************/

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
static void SägHej()
{
    Console.WriteLine("hej på dig");
}

/// <summary>
/// Metod för att skriva ir en meny 
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
            1. Lägg till uppgift 
            2. Ta bort uppgift 
            3. Skriv ut alla uppgifter
            4. Avsluta
            """);
}

HeltalParse();

/// <summary>
/// metod för att skirva in något och kollar om det är ett heltal. 
/// Om det är det så fortsätter programmet annars visas ett felmedlenade
/// </summary>
/// <returns>int heltal</returns>
static int HeltalParse()
{
    int heltal;
    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades) break;
        else Console.WriteLine("Fel:inte ett heltal");
    }
    return heltal;
}
