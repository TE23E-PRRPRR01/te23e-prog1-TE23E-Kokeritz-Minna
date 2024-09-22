/*
Skapa ett program med en huvudloop och en meny som låter användaren välja mellan att subtrahera, dividera eller avsluta programmet.
Använd en while-loop för att fortsätta visa menyn tills användaren väljer att avsluta programmet
Använd sedan en switch-sats för att bestämma vilken kod som ska köras beroende på användarens val i menyn.*/

Console.Clear();
int svar = 0;

while (svar != 3)
{
    Console.WriteLine("""
        
        Vad vill du göra? 
        1) Subtrahera två tal 
        2) Dividera två tal
        3) Avsluta programmet
        """);

    svar = int.Parse(Console.ReadLine());

    switch (svar)
    {
        case 1:
            Console.WriteLine("Skriv in en term på vardera rad:");
            double term1 = double.Parse(Console.ReadLine());
            double term2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{term1} - {term2} = {term1 - term2}");
            break;

        case 2:
            Console.WriteLine("Skriv in täljaren på första raden och nämnaren på andra:");
            double täljare = double.Parse(Console.ReadLine());
            double nämnare = double.Parse(Console.ReadLine());

            Console.WriteLine($"{täljare} / {nämnare} = {täljare / nämnare}");
            break;

        case 3:
            Console.WriteLine("Tack för idag! :)");
            break;

        default:
            Console.WriteLine("Ogilitigt svar");
            break;
    }
}
