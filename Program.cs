
Compte compte = new Compte("FR001", "Alice");
Compte compte2 = new Compte("FR002", "Bob", 500m);

Console.WriteLine("Compte 1");
Console.WriteLine($"Numéro : {compte1.Numero}");
Console.WriteLine($"Titulaire : {compte1.Titulaire}");
Console.WriteLine($"Solde  : {compte1.Solde}");

Console.WriteLine();


Console.WriteLine("Compte 2");
Console.WriteLine($"Numéro : {compte2.Numero}");
Console.WriteLine($"Titulaire : {compte2.Titulaire}");
Console.WriteLine($"Solde : {compte2.Solde}");

 
