// spelet Blackjack, även kallat 21:an

using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.VisualBasic.FileIO;

Console.Clear();
Console.WriteLine("Spelet BlackJack");

/*kortens värde
2-10 = 2-10
J, Q, K= 10 
A  = 1 eller 11 */
//Variabler
int summaSpelare;
int summaDator;
int kort;
//@todo Efterlikna riktig kortlek ta bort kort 


int TaKortSpelare(int summa)
{
    summaSpelare = summa;
    kort = Random.Shared.Next(1, 14);  //@todo J Q K A ?
    if (kort == 11 || kort == 12 || kort == 13) kort = 10;
    summaSpelare += kort;               // if kort = 11,12,13, kort = 10  ?
    Console.WriteLine("Du fick " + kort);
    return summaSpelare;
}


// loop för att spela igen
while (true)
{
    summaDator = 0;
    summaSpelare = 0;

    //dela ut 2 kort till spelaren 
    kort = Random.Shared.Next(1, 14);  //@todo J Q K A ?
    Console.Write("kort:" + kort + " su:" + summaSpelare);
    if (kort == 11 || kort == 12 || kort == 13) kort = 10;
    summaSpelare += kort;               // if kort = 11,12,13, kort = 10  ?


    /* kort = Random.Shared.Next(1, 11);  //@todo J Q K A ?
    summaSpelare += kort;               // if kort = 11,12,13, kort = 10  ? if kort = 15 kort = 11
    Console.Write("kort:" + kort + " su:" + summaSpelare);
 */
    kort = Random.Shared.Next(1, 11);
    summaSpelare += kort;
    Console.Write("kort:" + kort + " su:" + summaSpelare);


    Console.WriteLine();

    //dela ut 2 kort till datorn
    kort = Random.Shared.Next(1, 11);  //@todo J Q K A ?
    summaDator += kort;
    Console.Write(" kort:" + kort + " su:" + summaDator);
    kort = Random.Shared.Next(1, 11);
    summaDator += kort;
    Console.Write(" kort:" + kort + " su:" + summaDator);

    Console.WriteLine();


    //flera gånger (loop)
    while (true)
    {
        // skriv ut summorna 
        Console.WriteLine($"Spelaren har {summaSpelare}");
        Console.WriteLine($"Datorn har {summaDator}");

        //stanna eller dra ett kort? 
        Console.Write("Vill du ha ett nytt kort? (j/n)");
        if (Console.ReadLine().ToLower() == "n")
        {
            //@Todo datorn får ta extra kort <= 17
            // taKort(summaDator); 
            
            while (summaDator < 17)
            {
                kort = Random.Shared.Next(1, 11);
                summaDator += kort;
                Console.WriteLine($"Datorn fick {kort}");
            }


            // vem har vunnit? 
            // den som har närmast 21 har vunnit 
            if (summaSpelare > summaDator && summaSpelare < 21) Console.WriteLine("vinsten är din");
            else Console.WriteLine("Förlusten är din");
            break;     //@todo stanna --> pass      Datorn får ta extra kort 
        }

        //ta ett extra kort
        TaKortSpelare(summaSpelare);
        /* 
                kort = Random.Shared.Next(1, 11);
                summaSpelare += kort;
                Console.WriteLine($"Du fick {kort}"); */

        //datorn får ett nytt kort
        kort = Random.Shared.Next(1, 11);
        summaDator += kort;
        Console.WriteLine($"Datorn fick {kort}");

        // Vem har vunnit 
        // Har datorn fått 21 har den vunnit 
        if (summaDator == 21)
        {
            Console.WriteLine("vinsten är din");
            break;
        }
        // Har spelaren fått 21 har hen vunnit 
        if (summaSpelare == 21)
        {
            Console.WriteLine("vinsten är din");
            break;
        }

        // Är spelaren tjock?

        if (summaSpelare > 21)
        {
            Console.WriteLine("Förlusten är din");
            break;
        }

        // Är datorn tjock?
        if (summaDator > 21)
        {
            Console.WriteLine("Vinsten är din");
            break;
        }
    }

    Console.WriteLine("vill du spela igen (no)");
    if (Console.ReadLine() == "no") break;
}