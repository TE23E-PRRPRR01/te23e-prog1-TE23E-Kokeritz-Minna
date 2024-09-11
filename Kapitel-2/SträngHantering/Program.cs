/* Extrahera alla ord i meningen 
"Den mätta dagen, den är aldrig störst. Den bästa dagen är en dag av törst." 
som börjar med bokstaven "d".*/
Console.Clear();

String Mening = "Den mätta dagen, den är aldrig störst. Den bästa dagen är en dag av törst.";
String [] ord = Mening.Split(' '); //delar upp meningen i ord


//skriv ut alla ord som börjar på D. 
foreach (string i in ord){
    String FörstaBokstav = i.Substring(0,1).ToUpper(); // hittar första bokstaven
    if (FörstaBokstav == "D")  Console.WriteLine(i); // skriver ut om första bokstaven är ett D
}