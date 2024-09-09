//programm kollar åldersgränser 
/*
    helt imaginära åldersgränser
    10 får köpa ett liv 
    13 får ge ett liv 
    14 får ta ett liv 
    18 får få ett liv
*/

Console.Clear();
Console.Write("Hur gammal är du? ");
int age  = int.Parse(Console.ReadLine());
int köpa = 10;
int ge = 13;
int ta = 14;
int få = 18;


if (age >= få)   Console.WriteLine("Du får köpa, ge, ta och få ett liv");

else if (age >= ta && age < få)  Console.WriteLine("Du får köpa, ge och ta ett liv");    

else if (age >=ge && age < ta)  Console.WriteLine("Du får köpa och ge ett liv");

else if (age >= köpa && age < ge) Console.WriteLine("Du får köpa ett liv");

else Console.WriteLine("Du är för ung för att köpa, ge, ta eller få ett liv");