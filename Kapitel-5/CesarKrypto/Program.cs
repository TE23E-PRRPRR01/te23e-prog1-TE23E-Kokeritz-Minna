
// ett programm för att kryptering av med Ceasar-schiffer
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Clear();
Console.WriteLine("ett programm för att kryptering av med Ceasar-schiffer");


// alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// ange en bokstav 
Console.Write("Ange ett medellande: ");
string medellande = Console.ReadLine().ToUpper();
int nyckel = 0;

while (true)
{
    Console.Write("Ange en nyckel (1-9): ");
    nyckel = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (nyckel > 9 || nyckel < 1) Console.WriteLine("Nyckeln måste vara mellan 1-9");
    else break;
    Console.WriteLine();
}

foreach (char bokstav in medellande)
{
    // hitta en bokstavs position [index]
    int index = alfabetet.IndexOf(bokstav);

    // om bokstaven finns i alfabetet 
    if (index != -1)
    {
        // ceasar-hrypptering, addera en nyckel
        int nyIndex = index + nyckel;
        
        if (nyIndex >= alfabetet.Length)  nyIndex -= alfabetet.Length;
        // börja om från början

        char kryptBokstav = alfabetet[nyIndex];
       Console.Write(kryptBokstav);

    }
    else
    {
       // Console.WriteLine($"Bokstaven är oförendrad: {bokstav}");
       Console.Write(bokstav);
    }
}



