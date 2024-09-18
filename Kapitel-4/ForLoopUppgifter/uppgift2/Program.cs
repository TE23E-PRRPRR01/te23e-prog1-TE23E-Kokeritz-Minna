/*Skapa ett program som ber användaren att mata in ett tal. 
Programmet ska sedan använda en for-loop för att räkna ner från det inmatade talet till noll. 
För varje iteration ska programmet också skriva ut summan av alla tal som hittills har skrivits ut.*/

Console.Clear();

Console.WriteLine("var vanlig skriv ett tal");
Console.Write("TAL: ");
int tal = int.Parse(Console.ReadLine());
int summa = 0;

for (int i = tal; i > -1; i--)
{
    summa = summa + i;

    Console.WriteLine($"Tal:{i}");
    Console.WriteLine($"Summa: {summa}");
}

