/* Skapa ett nytt konsolprojekt Lyckohjulet
Användaren ska kunna välja ett nummer mellan 1 och 10, och datorn kommer slumpmässigt att generera ett nummer i samma intervall.
Om användarens nummer matchar datorns, vinner de spelet!
Användarens interaktion med programmet kan se ut så här:

1. Användaren startar programmet och blir ombedd att gissa ett nummer mellan 1 och 10.
2. Användaren skriver in sitt valda nummer.
3. Programmet genererar ett slumpmässigt nummer mellan 1 och 10.
4. Programmet jämför användarens nummer med det slumpmässigt genererade numret.
5. Programmet meddelar användaren om de vann (det vill säga om numren matchar) eller förlorade.

Användaren ska ha tre försök att gissa rätt nummer. */

using System.Runtime.Intrinsics.Arm;

Console.Clear();

int slumpTal = Random.Shared.Next(1, 11);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine();
    Console.WriteLine("Gissa ett heltal mellan 1 och 10 ");
    Console.Write("ditt Tal:");
    int gissa = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (gissa == slumpTal) Console.WriteLine("Du vann!!!!");
    else Console.WriteLine("Fel! Försök igen");
}

Console.WriteLine($"Talet var: {slumpTal}");