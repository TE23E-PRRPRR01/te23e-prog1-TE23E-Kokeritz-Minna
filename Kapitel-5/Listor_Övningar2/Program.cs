

Console.Clear();


//Globala variabler
List<string> listaFrukter = ["Mango", "Äpple", "Jordgubb", "Blåbär", "Passionsfrukt"];
List<string> listaNamn = ["Bob", "Sune", "Daniel", "Falicia", "Cisco"];
List<string> listaDrickor = ["Te", "Sprite", "Smoothie", "Fanta Exotic", "Saft"];
List<string> listaFärger = ["Red", "Blue", "Cyan", "Green", "Gold"];
List<int> listaÅr = [1982, 2024, 719, 2099, 1835];


// frukter
Console.WriteLine($"Detta är fem frukter: {string.Join(", ", listaFrukter)}");

// namn 
Console.WriteLine($"Detta är fem namn: {string.Join(", ", listaNamn)}");

//årtal
Console.WriteLine($"Detta är fem årtal: {string.Join(", ", listaÅr)}");


Console.WriteLine($"Sista namnet: {listaNamn.Last()}");
Console.WriteLine($"Första namnet: {listaNamn.First()}");
