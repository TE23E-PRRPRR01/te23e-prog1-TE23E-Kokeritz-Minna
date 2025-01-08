/******************************************************
*********************** M A I N ***********************
*******************************************************/

Console.Clear();

SägHejNamn("Jim");
HeltalParse();
KvadreratTal(5);

/******************************************************
********************* M E T O D E R *******************
*******************************************************/

/// <summary>
/// Skriv ut hälsning 
/// </summary>
/// <param name="namn">namnet</param>
static void SägHejNamn(string namn){
    Console.WriteLine($"Hej {namn}");
}

/// <summary>
/// Kolla om ett svar är ett heltal,
/// </summary>
/// <returns>int heltal</returns>
static int HeltalParse(){
    int heltal;
    while (true)
    {
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if(lyckades) break;
        else Console.WriteLine("Fel: Inte ett heltal");
    }
    return heltal;
}

/// <summary>
/// Kvadrerat ett tat
/// </summary>
/// <param name="tal">talet som ska kvadreras </param>

static void KvadreratTal(int tal){
    Console.WriteLine($"{tal} i kvadrat blir {tal*tal}");
}
