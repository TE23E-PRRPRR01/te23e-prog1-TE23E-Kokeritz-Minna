Console.Clear();

List<(string namn, int ålder)> personer = [];

int menyVal = 0;
string filnamn = "register.csv";
List<string> ListatempPerson = [];


while (menyVal != 3)
{
    Console.WriteLine("""
                ----------------------
                  1. Registrer person
                  2. Visa registrerade
                  3. Avsluta
                ----------------------
                """);

    do menyVal = HeltalParse();
    while (menyVal > 3);

    switch (menyVal)
    {
        case 1:
            Console.Write("Ange namn: ");
            string namn = Console.ReadLine();

            Console.Write("Ange ålder: ");
            int ålder = HeltalParse();

            personer.Add((namn, ålder));
            Console.WriteLine();
            Console.WriteLine($"{namn}, har lagts till i listan");

            break;

        case 2:
            Console.WriteLine("Registrerade personer: ");
            foreach ((string namn, int ålder) person in personer)
            {
                Console.WriteLine($"{person.namn} är {person.ålder}");
            }
            Console.WriteLine();

            foreach ((string namn, int ålder) person in personer)
            {
                string tempPerson = person.ToString();
                tempPerson.Trim('(', ')', ' ');

                ListatempPerson.Add(tempPerson);
            }

            File.WriteAllLines(filnamn, ListatempPerson);
            break;

        case 3:
            Console.WriteLine("Hej då");
            break;
    }
}




/* *****************
       Metoder 
******************* */

int HeltalParse()
{
    int heltal;

    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades) break;
        else Console.WriteLine("Fel: Inte ett heltal");
    }
    return heltal;
}
