//program för att konventera temperaturer mellan Fahrenheit och Celsius

using System.Collections;

Console.Clear();

//frågar om användaren konventerar från Farenheit eller celsisu
Console.WriteLine("Är din start temperatur i Farenheit eller Celisus? (F/C)");
char  svar = char.Parse(Console.ReadLine().ToUpper());
double FTemp,CTemp;

switch (svar)
{
    //konventerar tempraturern från farenheit till celsius
    case 'F':
        Console.Write("Ange en temperatur i Fareheit: ");

         FTemp = double.Parse(Console.ReadLine());
         CTemp = (FTemp - 32) * 5 / 9;
        Console.WriteLine($"{FTemp} grader farenheit är {CTemp} grader celsius");

        break;
    //konventerar celsius till farhenheit
    case 'C':
        Console.Write("Ange en temperatur i Celsius: ");

        CTemp= double.Parse(Console.ReadLine());
        FTemp = CTemp * 9 / 5 + 32;
        Console.WriteLine($"{CTemp} grader ceslisu är {FTemp} grader farnheit");
    break; 
    
    //om anvöndaren skrev in ett ogiltigt svar, frågar om igen tills ett giltigt svar givs då den går till korrekt case
    default:
        Console.WriteLine("ogilitigt svar, försök igen");

        while(svar != 'F' && svar != 'C'){
        Console.WriteLine("Är din start temperatur i Farenheit eller Celisus? (F/C)");
        svar = char.Parse(Console.ReadLine().ToUpper());
        }
        if(svar == 'F') goto case 'F';
        if(svar == 'C') goto case 'C';
    break;
}
