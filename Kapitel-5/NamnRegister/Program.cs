
using System.Runtime.Intrinsics.Arm;

Console.Clear();

List<string> namnlista = [];
int val = 0;
int rad;


//programmloop
while (val != 5)
{

    // visa en meny
    Console.Write(""" 

    1) Registrera namn
    2) Ändra namn
    3) Ta bort ett namn
    4) Skriv ut namnnen 
    5) Avsluta 
    Ange ditt val: 
    """);

    int.TryParse(Console.ReadLine(), out val);

    switch (val)
    {
        case 1:
            Console.Write("Ange ett namn: ");
            namnlista.Add(Console.ReadLine());
            break;

        case 2:
            for (int i = 0; i < namnlista.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {namnlista[i]}");
            }

            Console.WriteLine("Vilken rad vill du ändra på? ");
            rad = int.Parse(Console.ReadLine());
            Console.Write("Skriv in det nya namnet: ");
            namnlista[rad - 1] = Console.ReadLine();
            break;

        case 3:
            for (int i = 0; i < namnlista.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {namnlista[i]}, ");
            }

            Console.WriteLine("Vilken rad vill du ta bort? ");
            rad = int.Parse(Console.ReadLine());    
            namnlista.RemoveAt(rad-1);
            break;

        case 4:
            for (int i = 0; i < namnlista.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {namnlista[i]}, ");
            }
            break;

        case 5:
            Console.WriteLine("Hej då :)");
            break;

        default:
            Console.WriteLine("ogilitigt svar försök igen :)");
            break;
    }

}

