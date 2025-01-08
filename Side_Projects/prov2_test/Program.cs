/*  
Du ska skapa ett program för att dela ut julklappar.

    Först anger man hur många julklappar som ska delas ut.
    Sedan skriver man in julklapparna som sparas i en lista.
    Man ska kunna skriva ut listan på alla julklappar.
    Man ska kunna byta ut julklapparna.

Utöka programmet så att man kan ange vem som får julklappen.
Se till att programmet inte kraschar om man skriver in felaktig data som ålder eller namn.
Kontrollera att man bara kan mata in vettig data.

Utöka programmet så att en person kan få flera julklappar.
*/

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();


/* Vairabler */

//skapar lista på julklappar
List<String> julklapparLista = [];
// skapa lista för personer med värden för namn och ålder.
List<(string namn, int ålder)> personerLista = [];

List<string> pekare = [];

//variabel för menyval
int menyVal = -1;


Console.WriteLine(""" 
        🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁
        🎄  Julklappslistan  🎄
        🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁

        """);

// anger hur många julklappar som ska ska delas ut.
Console.Write("🎅 Hur många julklappar vill du dela ut i år? ");
int antalKlappar = HeltalParse();

//skriver in lika många julklappar som tidigare angets.
Console.WriteLine("🎄 Julklappar 🎄");
for (int i = 0; i < antalKlappar; i++)
{
    Console.Write($"🎅 Ange julklapp 🎁 {i + 1}: ");
    julklapparLista.Add(Console.ReadLine()); // lägger till dem i listan.
}


//programLoop 
while (menyVal != 0)    // kör så länge användaren inte valt 0/ avsluta
{
    Console.WriteLine("""

            🌟 Välj ett alternativ:
            1. Byt ut en julklapp
            2. Lista alla julklappar
            3. Tilldela julklapp till person
            4. Lista alla klappar och tilldelade person
            5. Lista alla julklappar en person får

            0. Avsluta programmet

            🎅 Ange ditt val:
            """);
    menyVal = HeltalParse();

    // switch case för alla menyalternativ. 
    switch (menyVal)
    {
        case 1:
            // skriver ut all julklappr
            ListaJulklappar();

            Console.Write("🎅 Ange numret på julklappen du vill byta ut: ");
            int alt = HeltalParse();    // skapar en variabel för vilken julklapps som ska ändras på.


            Console.Write("🎅 Ange den nya julklappen: ");
            string nyjulKlapp = Console.ReadLine(); // skapar variabeln för den nya klappen

            //                            den gammlas julklapps index--v              nyaJulklapp --v
            Console.WriteLine($"🎅 Julklappen 🎁 '{julklapparLista[alt - 1]}' har ersatts med '{nyjulKlapp}' */");
            julklapparLista[alt - 1] = nyjulKlapp;     // ny julklapps sparas på den gammalas plats. 

            Console.ReadLine();
            break;

        case 2:
            ListaJulklappar();
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("""
                    1. ny person
                    2. existerande person
                    """);
            int altVal = HeltalParse();

            ListaJulklappar();
            
            switch (altVal)
            {
                case 1:

                    // lägger till så listorna är lika långa.
                    while (personerLista.Count() != julklapparLista.Count())
                    {
                        personerLista.Add(("ingen", 0));
                        pekare.Add("-1");
                    }

                    Console.Write("Ange nummer på klapp som blir tildelad: ");
                    alt = HeltalParse();

                    Console.Write($"Vem får {julklapparLista[alt - 1]}: ");
                    string namnTemp = Console.ReadLine();   // sparar namnet i en varaibel. (Heter temp för enklare skilldring till touples namn)



                    Console.Write($"Ange åldern på {namnTemp}: ");
                    int ålderTemp = HeltalParse();      // sparar ålder i en varaibel. (Heter temp för enklare skilldring till touples ålder)

                    personerLista[alt - 1] = (namnTemp, ålderTemp); // lägger till ett namn och ålder på perosnen
                    pekare[alt - 1] = $"{pekare[alt - 1]} {alt - 1}";

                    break;

                case 2: 
                    for (int i = 0; i < personerLista.Count(); i++)
                    {
                        Console.WriteLine($"{i+1}. {personerLista[i].namn}, {personerLista[i].ålder}");
                    }
                    Console.Write("Ange nummer på person: ");
                    int personIndex = HeltalParse() -1;
                    
                    Console.WriteLine(pekare[personIndex]);


                    break;

                default:
                    Console.WriteLine("ogilitgt svar");
                    break;
            }


            Console.ReadLine();
            break;

        case 4:

            // lägger till så listorna är lika långa.
            while (personerLista.Count() != julklapparLista.Count()) personerLista.Add(("ingen", 0));

            for (int i = 0; i < julklapparLista.Count(); i++)
            {
                Console.WriteLine($"{julklapparLista[i]} får {personerLista[i].namn} som är {personerLista[i].ålder}");
            }

            Console.ReadLine();
            break;

        case 5:

            break;

        case 0:
            Console.WriteLine("""
                    🔔🔔🔔🔔🔔🔔🔔🔔🔔🔔
                    🔔 Gooood Juuuul! 🔔
                    🔔🔔🔔🔔🔔🔔🔔🔔🔔🔔
                    """);
            break;

        default:
            Console.WriteLine("Fel: Ogilitgt svar");
            break;
    }
}





/* ~~~~~~~~~~~~~~~~~~~~~~~~~
           Metoder
~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

// metod för att int.tryparsa en readline. Returnerar ett heltal. 
int HeltalParse()
{
    int heltal = 0;

    while (true)
    {
        // lyckades = true om tryparsen fick input ett heltal,   false om inte 
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades) break;            // avslutar while loopen
        else Console.WriteLine("Fel: inte ett heltal");
    }
    return heltal;          // returnerar heltalet.
}

// metod för att skriva ut alla julklappar i lsitan. 
void ListaJulklappar()
{
    Console.WriteLine("🎄 Lista över julklappar 🎄");
    // kör igenom hela listan. 
    for (int i = 0; i < julklapparLista.Count(); i++)
    {
        Console.WriteLine($"🎁{i + 1}. {julklapparLista[i]}");
    }
}