

Compte compte = new Compte();

compte.Numero = "FR001";
compte.Titulaire = "Alice";
compte.Solde = 1000m;

Console.WriteLine($"Solde de départ : {compte.Solde}");

compte.Crediter(200m);
Console.WriteLine($"Apres credit : {compte.Solde}");

compte.Debiter(50m);
Console.WriteLine($"Apres debit : {compte.Solde}");

class Compte
{
    public string Numero {get; set;}
    public string Titulaire {get; set}
    public decimal Solde {get; set}

    public void Crediter (decimal montant)
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
    Solde = Montant;
    }
else
{
    Console.WriteLine("Debit impossible");
}
}
}



 
