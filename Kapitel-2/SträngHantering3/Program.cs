/*Extrahera det sista ordet i meningen 
"Det bästa målet är en nattlång rast, där elden tänds och brödet bryts i hast."
*/

Console.Clear();

Console.WriteLine("Försök 6 ");

string mening = "Det bästa målet är en nattlång rast, där elden tänds och brödet bryts i hast.";
string [] ord = mening.Split( );


Console.WriteLine(ord.Last());


//Console.WriteLine(ord.Length);

/*foreach(string i in ord){
    Console.WriteLine(i);
}*/
//string SistaOrd = ord.Last();