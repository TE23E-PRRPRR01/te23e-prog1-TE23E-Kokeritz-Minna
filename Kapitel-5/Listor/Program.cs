//använda listor för skapa/hantera sammlingar 

Console.Clear();

//lista på frukter "äpple", "appelsin", "annans  
List<string> frukter = ["hello", "äpple", "jordgubbe", "mango"];

Console.Write("Min fruktlista: ");
for (int i = 0; i < frukter.Count; i++)
{
    Console.Write($"{frukter[i]}, ");
}

Console.WriteLine();

// ändra i listan 
frukter[0] = "passionsfrukt";
Console.Write("Min fruktlista: ");
foreach (var frukt in frukter)
{
    Console.Write($"{frukt}, ");
}

Console.WriteLine();

// skapa en lista 
List<string> böcker = ["Percy Jackson", "Harry Potter", "Lord of the Rings", "Alice in Wonderland"];
foreach (var bok in böcker)
{
    Console.Write($"{bok}, ");

}

List<string> filmer = ["Star Wars", "Avengers", "Matris", "Cinderella"];
for (int i = 0; i < filmer.Count; i++)
{
    Console.Write($"{filmer[i]}, ");

}


// skapa ett register
Console.Clear();

//En tom lista
List<string> namnlista = [];

while (true)
{
    Console.Write("Ange ett namn: ");

    namnlista.Add(Console.ReadLine());

    // skriv ut hela listan på en rad 
    foreach (var namn in namnlista)
    {
        Console.Write($"{namn}, ");
    }
    Console.WriteLine();
}