// Skapa Lista med slumpade tal

/***********************************************************************
                          |     Main     | 
************************************************************************/

//Validera användarens inmatning 

Console.Clear();

// dekalera variabler
// skapa en lista för att spara de slumpade talen 
List<int> listaSlumpTal = [];
int heltal;


int antal = LäsInHeltal("Ange antal slumptal: ");

Console.WriteLine();
Console.WriteLine($"Du vill ha {antal} slumptal");
Console.WriteLine();

int min = LäsInHeltal("Ange min gräns: ");

Console.WriteLine();
Console.WriteLine($"Du vill ha {min} som min gräns");
Console.WriteLine();

int max = LäsInHeltal("Ange max gräns: ");

Console.WriteLine();
Console.WriteLine($"Du vill ha {max} som max gräns");
Console.WriteLine();


Console.WriteLine("Dina slumpade tal är: ");
for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine(slumptal);
}

/*********************************************************************************
                          |    Mina egan Metoder  | 
**********************************************************************************/

int LäsInHeltal( string medelande)
{

    while (true)
    {
        // fråga användaren hur många slumptal som ska generas 
        Console.Write(medelande);

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);

        if (lyckades) break;
        else Console.WriteLine("Svaret måste vara ett heltal");
    }

    return heltal;
}

