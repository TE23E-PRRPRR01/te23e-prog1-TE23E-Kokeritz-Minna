/* *************************************************
 * Namn: SummeraTal
 * Beskrivning: Ett program för att summera tal
 * Datum: 2024-09-01
 *********************************************** */

Console.Clear();
Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");

int poäng = 0; // Poängräkning för utmaningen

while (true)
{
    VIsaMeny();

    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Ange storlek: ");
        int storlek = heltalparse();
        char tecken = bestämTecken();

        RitaFyrkant(storlek, tecken);
    }
    else if (val == "2")
    {
        Console.Write("Ange höjd: ");
        int höjd = heltalparse();

        char tecken = bestämTecken();
        Ritatriangel(höjd, tecken);

    }
    else if (val == "3")
    {
        Console.Write("Ange bredd: ");
        int bredd = heltalparse();

        Console.Write("Ange höjd: ");
        int höjd = heltalparse();

        char tecken = bestämTecken();
        Ritarektangel(höjd, bredd, tecken);
    }


    else if (val == "4")
    {
        Console.Write("Ange höjd: ");
        int höjd = heltalparse();
        char tecken = bestämTecken();
        RitaPyramid(höjd, tecken);
    }

    else if (val == "5")
    {
      sparaFigur();
    }
    else if (val == "6")
    {
        senasteFigurSparat();
    }
    else if (val == "7")
    {
       int korrektSvar = slumpaTal();

        Console.Write("Gissa storleken på figuren: ");
        int gissning = heltalparse();;
       
        Rättar(gissning, korrektSvar, poäng);
    
        Console.WriteLine($"Nuvarande poäng: {poäng}");
        RitaFugur(korrektSvar);
      
    }

    else
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen.");
    }

    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
    Console.ReadKey();
    Console.Clear();
}


/* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                       M E T O D E R 
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */


static void VIsaMeny()
{
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Skriv ut rektangel
    4. Skriv ut pyramid
    5. Spara figur
    6. Läs in sparad figur
    7. Utmaning: Gissa storleken
    8. Avsluta
    """);
}

static int heltalparse()
{
    string input = Console.ReadLine();
    int heltal;
    while (!int.TryParse(input, out heltal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        input = Console.ReadLine();
    }
    return heltal;
}

static char bestämTecken()
{
    Console.Write("Ange ett tecken att rita med: ");
    char tecken = Console.ReadKey().KeyChar;
    Console.WriteLine();
    return tecken;
}


static void RitaFyrkant(int storlek, char tecken)
{
    for (int i = 0; i < storlek; i++)
    {
        for (int j = 0; j < storlek; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}
static void Ritatriangel(int höjd, char tecken)
{
    for (int i = 0; i < höjd; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}
static void Ritarektangel(int höjd, int bredd,char tecken)
{
      for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < bredd; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
}
static void RitaPyramid(int höjd,char tecken)
{
        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < höjd - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
}


static void sparaFigur()
{
        Console.WriteLine("Ange figur att spara:");
        string figur = Console.ReadLine();
        File.WriteAllText("figur.txt", figur);
        Console.WriteLine("Figuren har sparats!");
}

static void senasteFigurSparat()
{
       if (File.Exists("figur.txt"))
        {
            Console.WriteLine("Senast sparade figur:");
            Console.WriteLine(File.ReadAllText("figur.txt"));
        }
        else
        {
            Console.WriteLine("Ingen sparad figur hittades.");
        }
}

static int Rättar(int gissning, int korrektSvar, int poäng)
{
        if (gissning == korrektSvar)
        {
            Console.WriteLine("Rätt gissat! Du får 1 poäng.");
            poäng++;
        }
        else
        {
            Console.WriteLine($"Fel! Rätt svar var {korrektSvar}.");
        }

    return poäng;
}

static int slumpaTal()
{
    Random slump = new Random();
    int korrektSvar = slump.Next(3, 10);
    return korrektSvar;
}

static void RitaFugur(int korrektSvar)
{
      for (int i = 0; i < korrektSvar; i++)
        {
            for (int j = 0; j < korrektSvar; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}