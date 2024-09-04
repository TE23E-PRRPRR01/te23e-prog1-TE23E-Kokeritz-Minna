string Fråga(string frågeText) {
    string? svar;
    do {
        Console.Write(frågeText);
        svar = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(svar));
    return svar;
    /* while (true) {
        Console.Write(frågeText);
        string svar = Console.ReadLine();
        if (svar != "") return svar;
    } */
}

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

String varelse,adjektiv,namn,pronomen,egenskap,aktivitet;

while (true)
{
    varelse = Fråga("Ange en varelse:");
    adjektiv = Fråga("Ange ett adjektiv:");
    namn = Fråga("Ange ett namn:");
    pronomen = Fråga("Ange ett pronomen:");
    egenskap = Fråga("Ange en egenskap:");
    aktivitet = Fråga("Ange en aktivitet:");

    if (varelse == adjektiv && adjektiv == namn && namn == pronomen && pronomen == egenskap && egenskap == aktivitet && aktivitet == varelse) {
       Console.WriteLine("du sa samma sak för allt, försök igen");
       continue; 
    }
    break;
} 
Console.WriteLine($"Det var en gång en {adjektiv} {varelse}, som hette {namn}. {pronomen} var en {egenskap} {varelse} som gillade att {aktivitet}.");