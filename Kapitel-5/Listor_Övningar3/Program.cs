Console.Clear();

/* *************************
          Variabler
**************************** */

int menyval = 0;

List<string> ActionLista = [];
List<string> ÄdevntyrLista = [];


/* *************************
            Main
**************************** */
while (menyval != 0)
{
    Console.WriteLine($"""
        1. Visa alla action spel 
        2. Registrera ett action spel
        3. Visa alla Adventyrs spel
        4. Registrera ett ädventyrspel 

        0. Avlsuta programmet
        """);

    menyval = HeltalParse();
    
    switch (menyval)
    {
        case 1:
            VisaSpel(ActionLista, "action");
            Console.ReadLine();
            break;

        case 2:
            RegistreraSpel(ActionLista, "action");
            Console.ReadLine();
            break;

        case 3:
            VisaSpel(ÄdevntyrLista, "ädventyrs");
            Console.ReadLine();
            break;

        case 4:
            RegistreraSpel(ÄdevntyrLista, "ädventyrs");
            Console.ReadLine();
            break;

        case 0:
            Console.WriteLine("Du loggar nu ut");
            break;

        default:
            Console.WriteLine("Fel: ogiltigt svar ");
            break;
    }
}



/* *************************
          Metoder
**************************** */

int HeltalParse()
{
    int heltal = 0;
    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades) break;
        else Console.WriteLine("Fel: inte ett heltal");
    }
    return heltal;
}

void VisaSpel(List<string> lista, string genre)
{
    Console.WriteLine($"Lista på alla {genre}-spel");
    foreach (var spel in lista)
    {
        Console.WriteLine($"-{spel}");
    }
}

void RegistreraSpel(List<string> lista, string genre)
{  
    Console.Write("Ange antal spel: ");
    int antal = HeltalParse();

    for (int i = 0; i < antal; i++)
    {
        Console.Write($"Ange ett {genre}-spel: ");
        lista.Add(Console.ReadLine());
    }
}