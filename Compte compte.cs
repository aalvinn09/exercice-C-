

class Compte
{
    public string Numero { get; set; }
    public string Titulaire { get; set; }
    public decimal Solde { get; set; }

    public Compte(string numero, string titulaire)
    {
        Numero=numero;
        Titulaire=titulaire;
        Solde=0m;

    }

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
            Console.WriteLine("Débit impossible.");
        }
    }
}