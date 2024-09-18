/* Använd en for-loop för att skapa ett program som ritar ut ett rätvinkligt triangel med hjälp av stjärntecken (“*”). 
Användaren ska kunna ange triangelns höjd. */

Console.Clear();
Console.Write("Höjd: ");
int höjd = int.Parse(Console.ReadLine());

for (int i = 1; i <= höjd; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}