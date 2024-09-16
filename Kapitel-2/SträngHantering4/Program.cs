/* Räkna antalet förekomster av bokstaven "e" i meningen 
"På ställen, där man sover blott en gång, blir sömnen trygg och drömmen full av sång.".
*/

using System.ComponentModel;

Console.Clear(); 

string mening = "På ställen, där man sover blott en gång, blir sömnen trygg och drömmen full av sång.";

int antal=0;
foreach (char i in mening) if (i == 'e') antal +=1;

Console.WriteLine($"det finns {antal} e i meningen");