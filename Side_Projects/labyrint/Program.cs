

/* skapa en Labyrint i konsolfönstret och låta användaren navigera 
genom Labyrinten med piltangenterna och hitta en utgång.*/

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Clear();


/* Variabler */

// Skapar två dimmenionell array --> spelplan 
int[,] spelplan ={
            { 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 4, 1},
            { 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1},
            { 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            { 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1},
            { 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1},
            { 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1},
            { 1, 0, 4, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1},
            { 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1},
            { 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1},
            { 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1},
            { 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 4, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1}
            };

for (int rad = 0; rad < spelplan.GetLength(0); rad++)
{
    for (int kol = 0; kol < spelplan.GetLength(1); kol++)
    {
        Console.SetCursorPosition(kol * 2, rad);

        if (spelplan[rad, kol] == 0) Console.Write("⬜️");
        if (spelplan[rad, kol] == 1) Console.Write("⬛");
        if (spelplan[rad, kol] == 2) Console.Write("🔴");
        if (spelplan[rad, kol] == 3) Console.Write("🔵");
        if (spelplan[rad, kol] == 4) Console.Write("⭐");

    }
}

Console.WriteLine("""

        ⬜️ = Öppet
        ⬛ = Vägg
        🔴 = Mål
        🔵 = Start
        ⭐ = Poäng
        """);


Console.CursorVisible = false;


while (true)
{
    ConsoleKeyInfo tangetTryckning = Console.ReadKey(true);

    switch (tangetTryckning.Key)
    {
        case ConsoleKey.UpArrow:
            break;

        case ConsoleKey.DownArrow:
            break;

        case ConsoleKey.LeftArrow:
            break;

        case ConsoleKey.RightArrow:
            break;
        default:
        break;
    }
}















/* int[,] spelplan ={
            { 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 4, 1},
            { 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1},
            { 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
            { 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1},
            { 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1},
            { 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1},
            { 1, 0, 4, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
            { 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1},
            { 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1},
            { 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1},
            { 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1},
            { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1},
            { 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 4, 0, 0, 0, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1}
            }; */