/*Användaren ska kunna bestämma hur många tärningar de vill kasta, och hur många sidor varje tärning ska ha.
Därefter ska programmet simulera tärningskasten och skriva ut resultatet av varje kast. */

Console.Clear();

Console.Write("Hur många tärningar vill du kasta: ");
int antal = int.Parse(Console.ReadLine());

for (int i = 0; i < antal; i++)
{
    int tärning = Random.Shared.Next(1,7);
    Console.WriteLine(tärning);
}