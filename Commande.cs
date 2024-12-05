using System;
using System.Collections.Generic;

namespace Magasin
{
    public enum EtatCommande
    {
        EnAttente,
        Validee,
        Annulee
    }

    public class Commande
    {
        public string IdCommande { get; private set; }
        public Panier Panier { get; private set; }
        public EtatCommande Etat { get; private set; }

        public Commande(Panier panier)
        {
            IdCommande = Guid.NewGuid().ToString();
            Panier = panier;
            Etat = EtatCommande.EnAttente;
        }

        public void ValiderCommande()
        {
            Etat = EtatCommande.Validee;
        }

        public void AnnulerCommande()
        {
            Etat = EtatCommande.Annulee;
        }

        public override string ToString()
        {
            return $"Commande #{IdCommande} - Etat : {Etat} - Total : {Panier.CalculerTotal():C}";
        }
    }
}
