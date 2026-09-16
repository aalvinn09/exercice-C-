
Compte compte = new Compte();

compte.Titulaire = "Alice";

compte.Crediter(1000m);

Console.WriteLine($"Titulaire : {compte.Titulaire}");
Console.WriteLine($"Solde : {compte.Solde}");

compte.Crediter(200m);
Console.WriteLine($"Après crédit : {compte.Solde}");

compte.Debiter(50m);
Console.WriteLine($"Après débit : {compte.Solde}");


class Compte
{
    public string Numero { get; private set; }
    public string Titulaire { get; set; }
    public decimal Solde { get; private set; }

    public void Crediter(decimal montant)
    {
        if (montant > 0)
        {
            Solde += montant;
        }
    }

    public void Debiter(decimal montant)
    {
        if (montant > 0 && montant <= Solde)
        {
            Solde -= montant;
        }
        else
        {
            Console.WriteLine("Débit impossible");
        }
    }
}


 
