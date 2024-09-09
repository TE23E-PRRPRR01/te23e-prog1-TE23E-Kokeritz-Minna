//frågesport om en serie 


Console.Clear();

Console.WriteLine("Dags att ha en frågesport, vilket ämne vill du ha? (Star wars/Batfamily)");

string Fandom = Console.ReadLine();
string svar; //vad avnändare svar
int poäng;

void SantFalsk (string facit){
    if (facit == svar) poäng += 1; 
}