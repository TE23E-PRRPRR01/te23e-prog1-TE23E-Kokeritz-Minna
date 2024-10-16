// en liten morsekod app 
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("En liten morsekods app");
List<char> alfabet = [ 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                         'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                          'U', 'V', 'W', 'X', 'Y', 'Z', 'Å', 'Ä', 'Ö', ' ',
                          '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                          '.',',','!','?',';',':'];



List<string> morseKod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                          "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
                          "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
                          "-.--", "--..", ".--.-", ".-.-", "---.", "/",

                          ".----", "..---", "...--", "....-", ".....", ".----", "--...", "---..", "----.", "-----",
                          ".-.-.- "," --..-- "," -.-.-- "," ..--.. "," -.-.-. "," ---..."];



// läs in en text
Console.WriteLine("Ange ett medellande att översätta till morse");
string medellande = Console.ReadLine().ToUpper();

//Uppslag i alfabetet 

foreach (char bokstav in medellande)
{
    int index = alfabet.IndexOf(bokstav);
    // hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        Console.Write($"{morseKod[index]} ");

        // spelar ljud
        foreach (char signal in morseKod[index])
        {
            if (signal == '.')
            {
                Console.Beep(1000, 100);
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }

            else if (signal == '-')
            {
                Console.Beep(1000, 300);
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
            else Console.Beep(0, 100);
        }
    }
    else
    {
        Console.WriteLine("?");
    }

    // paus i koden 
    Thread.Sleep(100);
}



//översätter från morse till svenska

Console.WriteLine();
Console.WriteLine("Ange ett morsemedelande att översätta till morse");
string morseMedelande = Console.ReadLine();

//string [] morsetecken = morseMedelande.Split(' ');
foreach (var morseTecken in morseMedelande.Split(' '))
{
    int index = morseKod.IndexOf(morseTecken);
    if (index >= 0)
    {
        Console.Write($"{alfabet[index]}");
    }
    else
    {
        Console.WriteLine("?");
    }
}





// Samma fast med to strin och fortsätta ha en string list ---------
/* Console.WriteLine();


List<string> alfabetS = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                          "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                          "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " "];

foreach (char bokstav in medellande)
{
    int index = alfabetS.IndexOf(bokstav.ToString());
    // hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        Console.Write(morseKod[index]);
       // Console.WriteLine($"{medellande} finns på index {index} vilket är {morseKod[index]} i morsekod");
    }
    else
    {
        Console.WriteLine("?");
    }
} */



// Console.WriteLine($"{medellande} finns på index {index} vilket är {morseKod[index]} i morsekod");