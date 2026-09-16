Compte compte1 = new Compte();
Compte compte2 = new Compte();

 
compte1.Numero = "FR001";
compte1.Titulaire = "Alice";
compte1.Solde = 1000m;

compte2.Numero = "FR002";
compte2.Titulaire = "Bob";
compte2.Solde = 500m;


Console.WriteLine("Compte 1 :");
Console.WriteLine($"Numéro : {compte1.Numero}");
Console.WriteLine($"Titulaire : {compte1.Titulaire}");
Console.WriteLine($"Solde : {compte1.Solde}");

Console.WriteLine();

Console.WriteLine("Compte 2 :");
Console.WriteLine($"Numéro : {compte2.Numero}");
Console.WriteLine($"Titulaire : {compte2.Titulaire}");
Console.WriteLine($"Solde : {compte2.Solde}");


compte1.Solde = 1500m;

Console.WriteLine();
Console.WriteLine("Après modification du compte 1 :");

Console.WriteLine($"Solde compte 1 : {compte1.Solde}");
Console.WriteLine($"Solde compte 2 : {compte2.Solde}");


class Compte
{
    public string Numero { get; set; }
    public string Titulaire { get; set; }
    public decimal Solde { get; set; }
}