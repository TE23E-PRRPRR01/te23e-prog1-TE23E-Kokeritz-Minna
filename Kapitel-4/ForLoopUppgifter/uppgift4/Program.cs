/*Skapa ett program där användaren först får mata in en startpunkt och en slutpunkt. 
Därefter ska programmet skriva ut alla jämna tal som finns mellan start- och slutpunkten. 
Tips: Använd modulus-operatorn (%) för att kontrollera om ett tal är jämnt eller inte.*/

Console.Clear();

Console.Write("Ange en startpunkt: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Ange en slutpunkt: ");
int slut = int.Parse(Console.ReadLine());

for (int i = start; i < slut+1; i++)
{
    if(i%2 == 0) Console.WriteLine(i);
}

