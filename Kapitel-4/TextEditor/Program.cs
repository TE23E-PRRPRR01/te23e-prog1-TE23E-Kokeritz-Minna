/*Skapa ett program med en huvudloop och en meny som låter användaren skriva och läsa en textfil. Menyalternativen bör vara:
Skriv till fil
Läs från fil
Avsluta programmet*/

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int val = 0;

Console.WriteLine("""
================
   Texteditor
================
""");

while (val != 3)
{

    Console.WriteLine("""
    Välj ett av följande alternativ:
    1) Skriv till fil 
    2) läs in fil
    3) Avlsuta programmet
    """);
    val = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (val)
    {

        case 1:
            Console.Write("skriv in en text: ");
            string Nytext = Console.ReadLine();
            File.AppendAllText("textfil.txt",Nytext + Environment.NewLine);
            //                                          ny rad ^
            Console.WriteLine("Texten har sprats i filen textfil.txt");
            Console.WriteLine();
            break;

        case 2:
            string text = File.ReadAllText ("textfil.txt"); 
            Console.WriteLine(text);
            break;

        case 3:
            Console.WriteLine("tack för idag :)");
            break;

        default:
            Console.WriteLine("ogiltigt svar");
            break;
    }
}