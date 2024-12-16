/*  ett program som innehåller en array med minst 8 heltal. 
Gå igenom arrayen med hjälp av en loop och hitta det största talet i arrayen. */

Console.Clear();

int [] HeltalLista = [4, 5, 10, 12, 1, 7, 1, 9 ,2, 11, 35, 14];
int störstTal = -10000;

foreach (int tal in HeltalLista)
{
    if(tal > störstTal) störstTal = tal;
}

Console.WriteLine(störstTal);


