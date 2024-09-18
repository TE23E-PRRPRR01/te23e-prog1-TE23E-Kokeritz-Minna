/* Skapa ett enkelt kortspel där målet är att tvinga datorn att få över 21 poäng.
Du och datorn får poäng genom att dra kort, där varje kort är värt mellan 1 och 10 poäng.
Du vinner om datorn får 21 poäng eller mer. */

Console.Clear();

Console.WriteLine(@"Du ock datorn kommer dra kort tills en av er når 21 påäng.
Spelar som får exakt 21 poäng vinner först. Om man går över 21 förlorar man. 
Om båda spelarna väljer att passa är den som är närmast som vinner.");

string spelare = "du";
int startSpelare = Random.Shared.Next(1,3);
if (startSpelare == 1) spelare = "datorn";
if (startSpelare == 2) spelare = "du";

while (true) {
    

switch (spelare) 
{
    case "datorn":

    break;

    case "du":

    break;
}



}