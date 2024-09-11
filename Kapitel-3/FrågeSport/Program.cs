//frågesport om en serie 


using System.Globalization;

Console.Clear();

Console.WriteLine("Dags att ha en frågesport, vilket ämne vill du ha? (Star wars(sw)/Batfamily(dc))");

string ämne = Console.ReadLine().ToLower();
string svar; //vad avnändare svarade
int poäng = 0;

int Fråga(string fråga, string facit){
    Console.WriteLine(fråga);
    svar = Console.ReadLine().ToLower();
    if (facit == svar) poäng +=1;
    return poäng;
}
    
switch (ämne)
{

    case "dc":
        Fråga("Vem var den första robinen (efternamn)","grayson");
        Fråga("Vem är Duke Thomas (hero name)", "signal");
        Fråga("Vad var Nightwing innan han blev intagen av Wayne (yrke)", "akrobat");
        Fråga("Vas är Katrine Kanes relation med Bruce Wayne", "kusin");
        Console.WriteLine($"du fick {poäng}/4 poäng");    

        break;

    case "sw":
        Fråga("Hur gammal var Ahsoka tano när hon blev Anakins padawan","14");
        Fråga("","");
        Console.WriteLine($"du fick {poäng} poäng");
        break;

    default:
        Console.WriteLine("ogiltigt svar");
        break;
}