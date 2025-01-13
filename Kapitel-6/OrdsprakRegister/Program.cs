/******************************************************
*********************** M A I N ***********************
*******************************************************/

Console.Clear();

List<string> ordspråkLista = [];
bool avsluta = false;
//int menyVal = -1;

while (avsluta != true)
{
    // visa menyn
  /*   VisaMeny();
    menyVal = HeltalParse(); */

    switch (Meny())
    {
        case 1:
            break;
            
        case 2:
            break;
            
        case 3:
            break;
            
        case 4:
            break;
            
        case 0:
            break;
            

        default:
            Console.WriteLine("Fel: Ogilitigt alternativ");
            break;
    }
}


/*******************************************;***********
********************* M E T O D E R *******************
*******************************************************/

static int HeltalParse()
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

static void VisaMeny()
{
    Console.WriteLine("""
            ------- MENY -------
            1. Spara Ordspråk
            2. Läs alla Ordspråk
            3. Slumpa fram ett Ordspråk 
            4. Sök efter Ordspråk
            0. Avlsuta
            """);
}

static int Meny()
{
    Console.WriteLine("""
            ------- MENY -------
            1. Spara Ordspråk
            2. Läs alla Ordspråk
            3. Slumpa fram ett Ordspråk 
            4. Sök efter Ordspråk
            0. Avlsuta
            """);

    int menyVal = HeltalParse();
    return menyVal;
}