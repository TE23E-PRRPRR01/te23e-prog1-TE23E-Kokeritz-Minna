/* Skapa ett program som innehåller en array med minst 5 årtal, minst ett av årtalen ska finnas med två gånger. 
Användaren ska få skriva in ett årtal när programmet körs. 
Programmet ska skriva ut alla index som detta årtal finns på i arrayen. 
Om årtalet inte fanns på någon plats så ska programmet skriva "Årtalet kunde inte hittas". */

using System.Diagnostics.Contracts;

Console.Clear();

int[] årtalLista = [2024, 2031, 1954, 700, 1100, 1954];
bool finns = false;

Console.WriteLine("Ange ett årtal: ");
int.TryParse(Console.ReadLine(), out int årtal);

for (int i = 0; i < årtalLista.Length; i++)
{
    if (årtalLista[i] == årtal)
    {
        Console.WriteLine($"{årtal} finns på index {i}");
        finns = true;
    }
}

if (finns == false) Console.WriteLine("Årtalet kunde inte hittas");