

Console.Clear();

List<String> namnLista = ["Sune", "Bob", "Jerry", "Bob"];
int val = 0;

while (val != 9)
{
    Console.WriteLine("""

    ---------------------------
        Vad vill du göra? 
        1. Visa listan
        2. Lägg till namn
        3. Ta bort namn 
        4. Sök efter namn 
        5. Sortera listan
        6. Töm listan
        7. Räkna listan 
        8. Rensa dubletter
        9. Avsluta programmet
    ----------------------------

    """);
    while (true)
    {
        bool san = int.TryParse(Console.ReadLine(), out val);
        if (san) break;
    }

    switch (val)
    {
        case 1:
            läsLista();

            Console.ReadLine();
            break;

        case 2:
            Console.Write("Ange ett namn att lägga till: ");
            namnLista.Add(Console.ReadLine());
            läsLista();

            Console.ReadLine();
            break;

        case 3:

            Console.Write("Ange ett namn att ta bort: ");
            string namnTaBort = Console.ReadLine();

            if (namnLista.Contains(namnTaBort))
            {
                namnLista.Remove(namnTaBort);
                läsLista();
            }

            else Console.WriteLine($"Fel: {namnTaBort} finns inte i listan ");

            Console.ReadLine();
            break;

        case 4:

            Console.WriteLine("Ange ett namn att söka efter: ");
            string namnSök = Console.ReadLine();
            if (namnLista.Contains(namnSök))
            {
                Console.WriteLine($"{namnSök} finns i listan");
            }

            else Console.WriteLine($"{namnSök} finns inte i listan");

            Console.ReadLine();
            break;

        case 5:
            Console.Write("Vill du sortera listan? (j/n): ");
            if (Console.ReadLine().ToLower() == "j")
            {
                namnLista.Sort();
                läsLista();
            }

            Console.ReadLine();
            break;

        case 6:
            namnLista.Clear();
            Console.WriteLine("Listan har tömts");

            Console.ReadLine();
            break;

        case 7:
            Console.WriteLine($"Det finns {namnLista.Count()} namn i listan");

            Console.ReadLine();
            break;

        case 8:
            if (namnLista.Count() != namnLista.Distinct().Count())
            {
                Console.WriteLine("listan är inte unik ");
                namnLista.Distinct().ToList();
                while (namnLista.Count() != namnLista.Distinct().Count())
                {

                    foreach (string namn in namnLista)
                    {
                        while (namnLista.Contains(namn))
                        {
                            namnLista.Remove(namn);
                        }
                    }
                }

                läsLista();
            }

            else Console.WriteLine("Det finns inga dubletter i listan ");

            Console.ReadLine();
            break;

        case 9:
            Console.WriteLine("Hej då :)");
            break;

        default:
            Console.WriteLine("Ogiltigt alternativ");
            break;

    }

}


Console.WriteLine("Hej");


void läsLista()
{
    Console.WriteLine($"Nuvarande lista: {string.Join(", ", namnLista)}");
}


/* 
     string sparaNamn = namn;
                    string sparaNamn2 = namn;
                    Console.WriteLine(sparaNamn + sparaNamn2);
                    namnLista.Remove(namn);
                    Console.WriteLine("1");

                    if (namnLista.Contains(sparaNamn))
                    {
                        Console.WriteLine("2 " + sparaNamn);
                        namnLista.Remove(sparaNamn);
                        Console.WriteLine("3");
                    }

                    Console.WriteLine("4 " + sparaNamn2);
                    namnLista.Add(sparaNamn2);
                    Console.WriteLine("5"); */