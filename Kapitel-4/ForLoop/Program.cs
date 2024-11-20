
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


Console.Clear();
Console.Write("Höjd:");
int.TryParse(Console.ReadLine(), out int rad);

for (int i = 1; i <= rad; i++)
{
    for (int j = 0; j < rad - i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    for (int j = 2; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

int stamHöjd = rad / 3;
int stamBredd = rad % 2 == 0 ? 2 : 1;

for (int i = 0; i < stamHöjd; i++)
{
    for (int j = 1; j < rad - stamBredd / 2; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < stamBredd; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}


Console.Clear();

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

Console.Clear();
Console.Write("Höjd: ");
int height = int.Parse(Console.ReadLine());

for (int i = height; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}




Console.Clear();

Console.WriteLine("Ange två tal en på varje rad");
int.TryParse(Console.ReadLine(), out int tal1);
int.TryParse(Console.ReadLine(), out int tal2);

Console.WriteLine($"""
        Multiplikationstabbel för {tal1} till 10   
        |1| |2| |3| |4| |5| |6| |7| |8| |9| |10|
        |{tal1*1}| |{tal1*2}| |{tal1*3}| |{tal1*4}| |{tal1*5}| |{tal1*6}| |{tal1*7}| |{tal1*8}| |{tal1*9}| |{tal1*10}|   
        """);

Console.WriteLine($"""
        Multiplikationstabbel för {tal2} till 10   
        |1| |2| |3| |4| |5| |6| |7| |8| |9| |10|
        |{tal2*1}| |{tal2*2}| |{tal2*3}| |{tal2*4}| |{tal2*5}| |{tal2*6}| |{tal2*7}| |{tal2*8}| |{tal2*9}| |{tal2*10}|   
        """);