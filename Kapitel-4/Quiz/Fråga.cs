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
            Console.WriteLine("Rätt svar");
            return true;
        }
        else
        {
            Console.WriteLine("Fel svar");
            return false;
        }
    }
}
