/*Extrahera alla ord i meningen 
"Bryt upp, bryt upp! Den nya dagen gryr. Oändligt är vårt stora äventyr." 
som har mer än tre bokstäver.
*/

Console.Clear();

string mening = "Bryt upp, bryt upp! Den nya dagen gryr. Oändligt är vårt stora äventyr.";

string [] ord = mening.Split();

foreach (string i in ord)
{
      if (i.Trim('!', '.' ,  ',' , '?').Length > 3) // if a trimed down ord är större en tre bokstäver kommer den skriva ut ordet.
    {
        Console.WriteLine(i.Trim('!', '.' ,  ',' , '?'));
    }
}