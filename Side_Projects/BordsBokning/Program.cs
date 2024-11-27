/* Centralrestaurangen har 8 bord och dess personal vill ha ett program 
där de enkelt kan skriva in ett namn för varje bord samt hur många som sitter på bordet.
Bordshanteraren ska lagra all bordsinformation i en textfil. */

using System.Reflection;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

Console.WriteLine("Detta är Centralrestaurangens bordshanterare");


/*****************************
          Variabler.
******************************/

string[] bordsInformation = [];

string filnamn = "centralbord.csv";

string tomtBordBeskrivning = "0,Inga gäster";

int antalBord = 8;

int menyVal = 0;

/*****************************
          Metoder.
******************************/

void läsBordsInformation()
{
    bordsInformation = File.ReadAllLines(filnamn);
    foreach (var bord in bordsInformation)
    {
        Console.WriteLine(bord);
    }
}

// Kontrollera att "centralbord.csv" finns annrs skapas den 
//TBC...
if (File.Exists(filnamn) == false)
{
    File.Create(filnamn);
}


// programm loop
while (menyVal != 4)
{
    Console.WriteLine("""
            ---------------------------------------------
                1. Visa alla bord
                2. Lägg till / ändra bordsinforamtion
                3. Markera bord som ledigt
                4. Avsluta 
            ---------------------------------------------
            """);
    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out menyVal);
        if (lyckades) break;
    }


    switch (menyVal)
    {
        case 1:
            Console.WriteLine();

            Console.WriteLine("hej");
            for (int i = 0; i < bordsInformation.Count(); i++)
            {

                Console.Write($"Bord {i + 1} - ");

                if (bordsInformation[i] == tomtBordBeskrivning)
                {
                    Console.Write(bordsInformation[i].Trim('0', ','));
                }

                else
                {
                    string [] deladBord = bordsInformation[i].Split();
                    Console.WriteLine(deladBord[0]);
                    Console.WriteLine(deladBord[1]);
                }
            Console.WriteLine("godagen");

            }

            Console.WriteLine("då");

            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine(2);

            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine(3);

            Console.ReadLine();
            break;


        case 4:
            Console.WriteLine(4);

            Console.ReadLine();
            break;

        default:
            Console.WriteLine("default");

            Console.ReadLine();
            break;
    }

}