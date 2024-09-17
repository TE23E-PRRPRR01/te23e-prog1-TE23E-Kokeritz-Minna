/*Extrahera alla ord i meningen 
"Ja visst gör det ont när knoppar brister." 
som innehåller mer än 5 bokstäver.*/

string mening = "Ja visst gör det ont när knoppar brister.";

string [] ord = mening.Split();

foreach (string i in ord)
{
    if (i.Trim('.').Length >= 5 ) Console.WriteLine(i.Trim('.').ToLower());
}
