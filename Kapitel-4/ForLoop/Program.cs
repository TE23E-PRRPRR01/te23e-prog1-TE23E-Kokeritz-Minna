
Console.Clear();

int summan = 0;

Console.Write("jämmna siffror: ");
for (int i = 0; i < 20; i++)
{
    //summan = summan + (i+1); // adderar alla siffror 
    if (i % 2 == 0) Console.Write(i + ", ");
}

Console.WriteLine();
Console.Write("Udda siffror: ");
for (int i = 0; i < 20; i++)
{
    //summan = summan + (i+1); // adderar alla siffror 
    if (i % 2 != 0) Console.Write(i + ", ");
}



Console.Clear();
Console.Write("Höjd: ");
int höjd = int.Parse(Console.ReadLine());

for (int i = 1; i <= höjd; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}