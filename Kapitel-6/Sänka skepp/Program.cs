/* 
Initialisera spelplan
Placera ut skepp slumpmässigt
Loopa tills spelet är klart
    Rita spelplan
    Läs in koordinater från användaren
    Kontrollera om träff eller miss
    Skriv ut resultat
SpeletSlut 

*/

/* 
Skapa en 2D array spelplan med storleken 10x10 för spelplanen
Skapa en array skepp med bokstäverna för skeppstyperna och en array skeppStorlek med storleken för varje skeppstyp
Skapa en metod InitialiseraSpelplan() som fyller spelplanen med "-" tecken
Skapa en metod PlaceraSkeppSlump() som slumpmässigt placerar ut skeppen på spelplanen
Skapa en metod KanPlaceraUtSkepp() som kontrollerar om ett skepp kan placeras på en viss position på spelplanen
Skapa en metod PlaceraSkepp() som placerar ut ett skepp på spelplanen
Skapa en metod Spela() som loopar tills spelet är klart och låter användaren skjuta på koordinater på spelplanen, och skriver ut om det är träff eller miss
Skapa en metod SpeletSlut() som kontrollerar om spelet är slut och skriver ut resultatet
Skapa en metod RitaSpelplan() som ritar ut spelplanen till konsolen
I huvudprogrammet anropa metoderna InitialiseraSpelplan(), PlaceraSkeppSlump() och Spela() */


char[,] spelaplan = new char[10,10];

static void InitialiseraSpelplan(){
    char[,] spelaplan = {{'-','-','-','-','-','-','-','-','-','-',},
                         {'-','-','-','-','-','-','-','-','-','-',}};
}



for (int i = 0; i < spelaplan.GetLength(0); i++) 
{ 
  for (int j = 0; j < spelaplan.GetLength(1); j++) 
  { 
    Console.WriteLine(spelaplan[i, j]); 
  } 
}  
