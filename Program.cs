decimal Crediter(decimal solde, decimal montant)

{

    if (montant > 0)

    {
        solde += montant;
    }

    else

    {
        Console.WriteLine("Montant invalide");
    }
 
    return solde;

}
 

decimal solde = 1000m;

decimal montant = 150m;
 
solde = Crediter(solde, montant);
 
Console.WriteLine($"Solde : {solde}");
 