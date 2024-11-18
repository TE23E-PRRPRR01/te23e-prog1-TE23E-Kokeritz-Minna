/*Skapa en loop som körs 10 gånger.
Varje gång loopen körs ska den skriva ut ditt namn, exempelvis 

Ändra loopen så att den också skriver ut en stigande siffra framför namnet.
Läs in ett tal från användaren som anger hur många gånger loopen ska köras.
*/

Console.Clear();

//variabler
List<string> listaNamn = ["Minna"];
int heltal;
bool play = true;

while (true)
{


    parseSvar("Ange antal repitaioner: ");

    for (int i = 0; i < heltal; i++)
    {
        Console.WriteLine($"{i + 1}. {listaNamn[0]}");
    }

    Console.WriteLine("""

-----------------------

""");
    //Beräkningar 
    parseSvar("Ange ett tal: ");
    int talet = heltal;

    while (play)
    {
        Console.Write("""
    ----------------------
    1. Multiplicera med 2
    2. Dividera med 2 
    3. Adderar med 2
    4. Subtrahera med 2
    5. Kvadrera talet
    6. Upphöja med 3   
    7. Avsluta beräkningen
    ----------------------
    Vad vill du göra: 
    """);
        parseSvar("");

        switch (heltal)
        {
            case 1:
                Console.WriteLine($"{talet} Multiplicerat med 2 blir: {talet * 2}");
                Console.ReadLine();
                

                break;

            case 2:
                Console.WriteLine($"{talet} Dividerat med 2 blir: {talet / 2}");
                Console.ReadLine();
                
                break;

            case 3:
                Console.WriteLine($"{talet} Adderat med 2 blir: {talet + 2}");
                Console.ReadLine();
                
                break;

            case 4:
                Console.WriteLine($"{talet} Subtraherat med 2 blir: {talet - 1}");
                Console.ReadLine();
                
                break;

            case 5:
                Console.WriteLine($"{talet} kvadrerat blir: {Math.Pow(talet,2)}");
                Console.ReadLine();
                
                break;

            case 6:
                Console.WriteLine($"{talet} upphöjt med 3 blir: {Math.Pow(talet,3)}");
                Console.ReadLine();
                
                break;

            case 7:
                play = false;
                break;
        }

    }

    Console.WriteLine("Vill du avsulta (j/n)");
    if (Console.ReadLine() == "j") break;
}

/**********************
        Metoder 
***********************/

int parseSvar(string medelande)
{
    while (true)
    {
        Console.Write(medelande);
        bool korrekt = int.TryParse(Console.ReadLine(), out heltal);
        if (korrekt) break;
        else Console.WriteLine("Felaktigt svar försök igen.");
    }
    return heltal;
}
