/*Skapa ett program som frågar användaren efter en textsträng och ett heltal n.
  Använd en for-loop för att skriva ut textsträngen n gånger.*/

using System.Runtime.Intrinsics.Arm;

Console.Clear();

Console.Write("Ange en textSträng: ");
string textSträng = Console.ReadLine();
Console.Write("Ange ett heltal: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n ; i++)
{
    Console.WriteLine(textSträng);
}
