Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Write("Ange en varelse: ");
String varelse = Console.ReadLine();
Console.Write("Ange ett adjectiv: ");
String adjectiv = Console.ReadLine();
Console.Write("Ange ett namn: ");
String namn = Console.ReadLine();
Console.Write("Ange ett pronomen eller title: ");
String pronomen = Console.ReadLine();
Console.Write("Ange ett egenskap: ");
String egenskap = Console.ReadLine();
Console.Write("Ange en aktivitet: ");
String aktivitet = Console.ReadLine();

if (varelse == adjectiv && adjectiv == namn && namn == pronomen && pronomen == egenskap && egenskap == aktivitet && aktivitet == varelse)
{
    Console.WriteLine("du sa samma sak för allt, försök igen");

    Console.Write("Ange en varelse: ");
    varelse = Console.ReadLine();
    Console.Write("Ange ett adjectiv: ");
    adjectiv = Console.ReadLine();
    Console.Write("Ange ett namn: ");
    namn = Console.ReadLine();
    Console.Write("Ange ett pronomen ekker title: ");
    pronomen = Console.ReadLine();
    Console.Write("Ange ett egenskap: ");
    egenskap = Console.ReadLine();
    Console.Write("Ange en aktivitet: ");
    aktivitet = Console.ReadLine();
}
if (varelse == " ")
{
    Console.WriteLine("du skrev inget försök igen");
    Console.Write("Ange en varelse: ");
    varelse = Console.ReadLine();
}

if (adjectiv == " ")
{
    Console.WriteLine("du skrev inget försök igen");
    Console.Write("Ange ett adjectiv: ");
    adjectiv = Console.ReadLine();
}

if (namn == " ")
{
    Console.WriteLine("du skrev inget försök igen");
    Console.Write("Ange ett namn: ");
    namn = Console.ReadLine();
}

if (pronomen == " ")
{
    Console.WriteLine("du skrev inget försök igen");
    Console.Write("Ange ett pronomen eller title: ");
    pronomen = Console.ReadLine();
}

if (egenskap == " ")
{
    Console.WriteLine("du skrev inget försök igen");
    Console.Write("Ange en egenskap: ");
    egenskap = Console.ReadLine();
}

if (varelse == " ")
{
    Console.WriteLine("du skrev inget försök igen");
    Console.Write("Ange en aktivitet: ");
    aktivitet = Console.ReadLine();
}
Console.WriteLine($"Det var en gång en {adjectiv} {varelse}, som hette ,{namn}. {pronomen} var en {egenskap} {varelse} som gillade att {aktivitet}.");

//Det var en gång en {adjektiv} {varelse}, som hette ,{namn}. {pronomen} var en {egenskap} {varelse} som gillade att {aktivitet}.