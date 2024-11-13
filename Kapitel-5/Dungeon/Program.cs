//Ett dungeon spel med massor, rum, saker, fiender m.m. 
Console.Clear();

//programm variabler
string rum = "entre";
List<String> inventory = [];
int alt;
string val;
int liv = 5;

while (true)
{


    switch (rum)
    {
        case "entre":
            Console.WriteLine("""
        Du är i entren
        1. Titta runt
        2. Gå till nästa rum
        Vad vill du göra?
        """);

            int.TryParse(Console.ReadLine(), out alt);

            switch (alt)
            {
                case 1:
                    Console.WriteLine("Du tittar i rummet och ser några gammla tavlor");
                    break;

                case 2:
                    Console.WriteLine("... du går in i nästa rum...");
                    rum = "hallen";
                    break;

                default:
                    Console.WriteLine("Du stannar i rummet");
                    break;
            }
            break;

        case "hallen":
            Console.WriteLine("""
        Du är i hallen
        1. Titta runt
        2. Gå till nästa rum
        3. Gå tillbaka
        Vad vill du göra?
        """);

            int.TryParse(Console.ReadLine(), out alt);

            switch (alt)
            {
                case 1:
                    Console.WriteLine("Du ser en nyckel på golvet");
                    Console.Write("Vill du plocka upp nyckeln (j/n)");
                    val = Console.ReadLine().ToLower();
                    if (val == "j")
                    {
                        inventory.Add("nyckel");
                        Console.WriteLine("Du plockar upp nyckeln");
                    }
                    else Console.WriteLine("Du lämnade nycklen");

                    break;

                case 2:
                    Console.WriteLine("... du går in i nästa rum...");
                    rum = "rum1";
                    break;

                case 3:
                    Console.WriteLine("Du går tillbaka till hallen");
                    rum = "hallen";
                    break;

                default:
                    Console.WriteLine("Du stannar i rummet");
                    break;
            }
            break;

        case "rum1":
            Console.WriteLine("Du är i rum 1");

            // slumpa en händelse
            int händelse = Random.Shared.Next(1, 5);

            if (händelse == 1)
            {
                Console.Write("Du ser ett svärd på marken. Vill du plocka upp det (j/n)");
                val = Console.ReadLine().ToLower();
                if (!inventory.Contains("svärd") && val == "j")
                {
                    inventory.Add("svärd");
                    Console.WriteLine("Du har nu ett svärd");
                }
            }
            else if (händelse == 2)
            {
                Console.WriteLine("""
            Ett spöke dyker upp! 
            1. Slås
            2. Fly
            Vad vill du göra?
            """);
                int.TryParse(Console.ReadLine(), out alt);
                switch (alt)
                {
                    case 1:
                        Console.WriteLine("Du försöker slås");
                        if (inventory.Contains("svärd"))
                        {
                            Console.WriteLine("Du slås med ditt svärd och vann. Du fick en Ghost Essence");
                            inventory.Add("ghost essence");
                        }
                        else
                        {
                            Console.WriteLine("du hade inget vapen och förlorade ett liv");
                            Console.WriteLine("[-1 liv]");
                            liv--;
                            if (liv == 0) break;
                        }
                        break;

                    case 2:
                        int slumpTal = Random.Shared.Next(1,4);
                        if (slumpTal == 1) rum = "hallen";
                        else if (slumpTal == 2) rum = "rum2";
                        else if (slumpTal == 3) rum = "rum3";
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("huh?");
                        break;
                }
                break;


            }

            else if (händelse == 3)
            {
                Console.WriteLine("Du trampar på en mina och förlorar ett liv");
                Console.WriteLine("[-1 liv]");
                liv--;
                if (liv == 0) break;
            }

            else if (händelse == 4)
            {
                Console.WriteLine("En fe kommer och hälsar dig god lycka");
                Console.WriteLine("[+1 liv]");
            }
            break;



        default:
            Console.WriteLine("Du är i ett evigt void");
            break;
    }

    break;
}



/* **************************************************************
                        funktioner
***************************************************************** */
