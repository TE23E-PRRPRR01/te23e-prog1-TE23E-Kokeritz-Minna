/* Skapa ett enkelt kortspel där målet är att tvinga datorn att få över 21 poäng.
Du och datorn får poäng genom att dra kort, där varje kort är värt mellan 1 och 10 poäng.
Du vinner om datorn får 21 poäng eller mer. */

using System.Diagnostics;

Console.Clear();

Console.WriteLine(@"Du ock datorn kommer dra kort tills en av er når 21 påäng.
Spelar som får exakt 21 poäng vinner först. Om man går över 21 förlorar man. 
Om båda spelarna väljer att passa är den som är närmast som vinner.");

int dataSumma = 0;
//vem som börjar. 
string spelare = "du";
int startSpelare = Random.Shared.Next(2);
if (startSpelare == 0) spelare = "dator";
if (startSpelare == 1) spelare = "du";


while (true)
{
    //vilken spelare som spelar
    switch (spelare)
    {
        case "dator":
            int dataTal = Random.Shared.Next(1, 11);
            dataSumma = dataSumma + dataTal;
            goto case "du";

        case "du":

            Console.Write("vill du dra ett kort (j/n)?: ");
            if (Console.ReadLine().ToLower() == "n") break;

            goto case "dator";
    }


    break;
}