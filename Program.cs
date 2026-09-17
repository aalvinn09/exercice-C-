
Compte compte = new Compte();

compte.Titulaire = "Alice";

compte.Crediter(1000m);

Console.WriteLine($"Titulaire : {compte.Titulaire}");
Console.WriteLine($"Solde : {compte.Solde}");

compte.Crediter(200m);
Console.WriteLine($"Après crédit : {compte.Solde}");

compte.Debiter(50m);
Console.WriteLine($"Après débit : {compte.Solde}");


 
