/*Byt ut alla mellanslag i meningen 
"Nog finns det mål och mening i vår färd - men det är vägen, som är mödan värd."
med #-tecken.*/

Console.Clear();

string mening = " Nog finns det mål och mening i vår färd - men det är vägen, som är mödan värd. ";
mening = mening.Trim().Replace(' ','#'); // tar bort blank spaces före och efter + erkätter alla mallanslag med #
Console.WriteLine(mening); // skriver ut den nya meningen