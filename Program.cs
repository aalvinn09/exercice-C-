
Compte compte = new Compte("FR001", "Alice");

Console.WriteLine($"Numéro : {compte.Numero}");
Console.WriteLine($"Titulaire : {compte.Titulaire}");
Console.WriteLine($"Solde initial : {compte.Solde}");

compte.Crediter(500m);

Console.WriteLine($"Solde après crédit : {compte.Solde}");


 
