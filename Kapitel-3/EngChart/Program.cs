//Programm som simulerar kända enginering flowchart 
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;

//funktion to colour text
void WriteInColour (string text, ConsoleColor colour){
    Console.ForegroundColor = colour;
    Console.WriteLine("text");
    Console.ForegroundColor = ConsoleColor.White;
}


Console.WriteLine("Välkommen till ingengörens flödesschema");

// Show a ASCii art
Console.WriteLine(@" 

Luv Dragons  _)               (_
            _) \ /\%/\ /\_/\ / (_
           _)  \\(0 0) (0 0)//  (_
Art by     )_ -- \(oo) (oo)/ -- _(
 VampLadee  )_ / /\\__,__//\ \ _(
             )_ /   --;--   \ _(
         *.    ( (  )) ((  ) )    .*
           '...(____)z z(____)...'


");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

//check if answer is yes or no

if (answer =="y")
{
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    
    if (answer=="y")
    {
        WriteInColour("No problem", ConsoleColor.Green);
    }
    else
    {
        WriteInColour("pls use ducktape!", ConsoleColor.Red);
    }
}
else
{
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();

    if (answer=="y")
    {
        WriteInColour("Pls use VD-40!", ConsoleColor.Red);
    }
    else
    {
        WriteInColour("No problem", ConsoleColor.Green);
    }
    
}
