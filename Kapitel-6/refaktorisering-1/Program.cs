/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 *********************************************** */

presentation();

while (true)
{
    string val = Meny();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = HeltalParse();
        RitaFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = HeltalParse();
        RitaTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */

static void presentation()
{
    Console.Clear();
    Console.WriteLine("""
            Program för att rita konsolgrafik
            ===================================
            """);
}

static int HeltalParse()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}


static string Meny()
{
      // Skriva ut menyn
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine();
    return val;
}

static void RitaFyrkant(int tal)
{   
        // Skriv ut fyrkanten
        for (int i = 0; i < tal; i++)
        {
            for (int j = 0; j < tal; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}

static void RitaTriangel(int tal)
{
           // Skriv ut triangeln
        for (int i = 0; i < tal; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}