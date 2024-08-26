//program to check if a user is above required age 
Console.Clear();
Console.ForegroundColor=ConsoleColor.White;

Console.Write("Enter your age: ");
string ageString = Console.ReadLine();
int age = int.Parse(ageString);
if (age>= 16)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Välkommen!");
    Console.ForegroundColor=ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You're not old enough to participate");
    Console.ForegroundColor=ConsoleColor.White;
}