
var compte1 = new Compte("FR001", "Alice", 1000m);
var compte2 = compte1;

compte2.Crediter(500m);

Console.WriteLine(compte1.Solde);
