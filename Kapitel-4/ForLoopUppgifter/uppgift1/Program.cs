/*Skapa ett program som ber användaren att mata in ett tal. 
Programmet ska sedan skriva ut alla tal från 1 till det tal som användaren matade in.*/

Console.Clear();
Console.WriteLine("Var vänlig skriv in ett tal");
Console.Write("TAL: ");
int tal = int.Parse(Console.ReadLine());

for (int i = 1; i < tal+1 ; i++)
{
    Console.WriteLine(i);
}