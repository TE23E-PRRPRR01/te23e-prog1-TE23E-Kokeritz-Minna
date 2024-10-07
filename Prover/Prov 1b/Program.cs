//Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Console.Clear();
Console.WriteLine(@"Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.");

Console.Write("Vad heter du? ");
string namn = Console.ReadLine();
int skattesatsen = 0;
//programmloop
while (true)
{
    Console.Write("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    // har användaren matat in vettiga siffror
    if (bruttolön < 10000 || bruttolön > 1000000) Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");

    else
    {

        // vad är skattesatsen 
        if (bruttolön >= 10000 && bruttolön < 145000) skattesatsen = 22;
        if (bruttolön >= 145000 && bruttolön < 515000) skattesatsen = 33;
        if (bruttolön >= 515000) skattesatsen = 53;

        //räknar ut nettolönen
        int nettolön = bruttolön * (100 - skattesatsen) / 100;
        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {skattesatsen}%.");
    }

    Console.Write("Vill du göra en ny beräkning? (j/n) ");
    if (Console.ReadLine().ToLower().Trim() == "n") break;
}