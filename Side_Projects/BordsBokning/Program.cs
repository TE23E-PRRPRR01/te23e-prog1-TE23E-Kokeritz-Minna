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

string tomtBordBeskrivning = "0,Inga gäster,0";

int antalBord = 8;

int menyVal = 0;
int summaGäster = 0;

/*****************************
          Metoder.
******************************/

void läsBordsInformation()
{
    int antalGäster;
    string bordNamn;
    int nota;

    bordsInformation = File.ReadAllLines(filnamn);
    for (int i = 0; i < bordsInformation.Count(); i++)
    {

        Console.Write($"Bord {i + 1} - ");

        if (bordsInformation[i] == tomtBordBeskrivning)
        {
            Console.Write(bordsInformation[i].Trim('0', ','));
        }

        else
        {
            string[] deladBord = bordsInformation[i].Split(',');
            bordNamn = deladBord[1];
            antalGäster = int.Parse(deladBord[0]);
            nota = int.Parse(deladBord[2]);
            Console.Write($"BordsNamn: {bordNamn}, Antal Gäster: {antalGäster}, nota: {nota} kr");

            summaGäster = summaGäster + antalGäster;
        }
        Console.WriteLine();
    }
}

int heltalTryparse()
{
    int heltal;
    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades) break;
        else Console.WriteLine("Fel: inte ett heltal");
    }
    return heltal;
}





if (File.Exists(filnamn) == false)
{
    for (int i = 0; i < antalBord; i++)
    {
            File.AppendAllText(filnamn, tomtBordBeskrivning + Environment.NewLine);
    }
}

// programm loop
while (menyVal != 5)
{
    Console.WriteLine("""
            ---------------------------------------------
                1. Visa alla bord
                2. Lägg till / ändra bordsinforamtion
                3. Markera bord som ledigt
                4. Ange nota
                5. Avsluta 
            ---------------------------------------------
            """);
    menyVal = heltalTryparse();


    switch (menyVal)
    {
        case 1:
            summaGäster = 0;
            Console.WriteLine();

            läsBordsInformation();

            Console.WriteLine("Totalt antal gäster: " + summaGäster);
            Console.ReadLine();
            break;

        case 2:
            läsBordsInformation();
            Console.WriteLine();

            Console.Write("Ange bordsnummret: ");
            int bordsNummer = heltalTryparse();

            Console.Write("Skriv in bordets namn: ");
            string bordsNamn = Console.ReadLine();

            Console.Write("Ange antal gäster: ");
            int antalGäster = heltalTryparse();

            bordsInformation[bordsNummer - 1] = $"{antalGäster},{bordsNamn},{0}";
            File.WriteAllLines(filnamn, bordsInformation);

            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine();
            läsBordsInformation();

            Console.Write("Ange bordsnummret: ");
            bordsNummer = heltalTryparse();

            bordsInformation[bordsNummer - 1] = tomtBordBeskrivning;
            File.WriteAllLines(filnamn, bordsInformation);

            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine();
            läsBordsInformation();

            Console.Write("Ange bordsnummret: ");
            bordsNummer = heltalTryparse();

            Console.Write("Ange nota: ");
            int nota = heltalTryparse();

            string[] deladBord = bordsInformation[bordsNummer-1].Split(',');
            string bordNamn = deladBord[1];
            antalGäster = int.Parse(deladBord[0]);
            deladBord[2] = nota.ToString();

            bordsInformation[bordsNummer-1] = $"{antalGäster},{bordNamn},{nota}";
            File.WriteAllLines(filnamn, bordsInformation);

        break;

        case 5:
            Console.WriteLine();
            Console.WriteLine("Du loggar nu ut. Hej då :)");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Ogilitigt svar försök igen");
            Console.ReadLine();
            break;
    }

}











/*
    List<String> tempList = [];
    for (int i = 0; i < antalBord; i++)
    {
        tempList.Add(tomtBordBeskrivning);
        Console.WriteLine(tempList);
    }

    bordsInformation = tempList.ToArray();
    File.WriteAllLines(filnamn, bordsInformation);
*/

    /*   Array.Resize( ref bordsInformation, antalBord);
      foreach (var item in bordsInformation) Console.WriteLine(item);

     for (int i = 0; i < bordsInformation.Count(); i++)
      {
          bordsInformation[i] = tomtBordBeskrivning;
      }
      File.WriteAllLines(filnamn, bordsInformation); */