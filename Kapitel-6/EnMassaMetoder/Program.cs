/******************************************************
*********************** M A I N ***********************
*******************************************************/

Console.Clear();

SägHejNamn("Jim");
HeltalParse();
KvadreratTal(5);
UpprepaText("hej", 3);
CelsiusTillFahrenheit(20);
skrivFyrkant(2);
AllaTaltillTalet(5);
TärningsKast(2);
Console.WriteLine(RäknarBokstäver("Hej!"));
Console.WriteLine(AntalVokaler("Hello"));
Console.WriteLine(AntalKonsonanter("Hello"));
Console.WriteLine(AntalSiffror("1jhsfj2"));
Console.WriteLine(AntalOrd("Why are we still here just to suffer"));

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

/// <summary>
/// skriver ut en text ett X antal gånger
/// </summary>
/// <param name="text"> texten</param>
/// <param name="antal">antal gånger</param>

static void UpprepaText( string text, int antal){
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

/// <summary>
/// En metod för att omvandla celsus till farenheit
/// </summary>
/// <param name="C">Grader i Celsisus</param>
static void CelsiusTillFahrenheit(int C){
    int F = C * 9/5 + 32;
    Console.WriteLine($"{C} grader Celsius motsvarar {F} grader Fahrenheit");
}

/// <summary>
/// Skriver ut en "fyrkant" med en x stor sida
/// </summary>
/// <param name="sida">antal # på varje rad</param>
static void skrivFyrkant (int sida){
    for (int i = 0; i < sida; i++)
    {
        for (int j = 0; j < sida; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }
}


/// <summary>
/// skriver ut alla tal fram tills givna talet 
/// </summary>
/// <param name="tal">givna tale</param>
static void AllaTaltillTalet (int tal){
    for (int i = 1; i < tal+1; i++)
    {
        Console.WriteLine(i);
    }
}

/// <summary>
/// Gör ett tärningskast och säger siffran. 
/// </summary>
/// <param name="antal"> hur många gånger som tärningen slås</param>
static void TärningsKast(int antal){
    for (int i = 0; i < antal; i++)
    {
        int tärning = Random.Shared.Next(1,7);
        Console.WriteLine("tärningen visar " + tärning);
    }
}

/// <summary>
/// Räknar alla bokstäver i en valfri text och returnerar antalet
/// </summary>
/// <param name="text">texten</param>
/// <returns>antal tecken i "text" </returns>
static int RäknarBokstäver (string text){
    int antalBokstäver = text.Length;
    return antalBokstäver;
}

/// <summary>
/// Räknare alla vokaler i en given text 
/// </summary>
/// <param name="text">texten</param>
/// <returns>antal vokalaer</returns>
static int AntalVokaler(string text){
    int räknare = 0;
    foreach (var bokstav in text.ToUpper())
    {
        if (bokstav == 'A' || bokstav == 'E' || bokstav =='I' || bokstav =='O' || bokstav =='U' || bokstav =='Y' || bokstav =='Å' || bokstav =='Ä' || bokstav =='Ö')
        {
            räknare ++;
        }
    }
    return räknare;
}

/// <summary>
/// I Praktik räknar den alla konsonater i en given text 
/// Räknar egentligen allting som inte är vokaler så tecken också. 
/// </summary>
/// <param name="text">texten </param>
/// <returns>antal "konsoanter"</returns>
static int AntalKonsonanter(string text){
    int räknare = 0;
    foreach (char bokstav in text.ToUpper())
    {
        if (bokstav !=  'A' && bokstav !=  'E' && bokstav != 'I' && bokstav != 'O' && bokstav != 'U' && bokstav != 'Y' && bokstav != 'Å' && bokstav != 'Ä' && bokstav != 'Ö')
        {
            räknare ++;
        }
    }
    return räknare;
}

// TBC::::::::
static int AntalSiffror(string text){
    int räknare = 0;
    foreach (var bokstav in text)
    {
        if (bokstav ==  1 || bokstav == 2 || bokstav == 3 || bokstav == 4|| bokstav == 5 || bokstav == 6 || bokstav == 7 || bokstav == 8 || bokstav == 9  || bokstav  == 0)
        {
            räknare ++;
        }
    }
    return räknare;
}


static int AntalOrd(string text){
    return text.Split(" ").Length;
}