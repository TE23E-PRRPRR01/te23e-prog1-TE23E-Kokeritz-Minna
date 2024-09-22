using System.Drawing;
using System.Xml.Schema;

//Alla koder som hanterar klasser har jag fått stort hjälp från pappa. 
class Fråga
{
    public string frågeText;
    public string altA;
    public string altB;
    public string altC;
    public char facit;

    public void SkrivFråga()
    {
        Console.WriteLine(frågeText);
        Console.WriteLine("a)" + altA);
        Console.WriteLine("b)" + altB);
        Console.WriteLine("c)" + altC);
    }

   public bool Rätta(char svar)
    {
        if (svar == facit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rätt svar");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel svar");
            Console.ForegroundColor = ConsoleColor.White;
            return false;
        }
    }


    
}
