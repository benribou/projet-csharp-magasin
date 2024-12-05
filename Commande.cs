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
        public Promotion Promotion { get; private set; }
        public EtatCommande Etat { get; private set; }

        public Commande(Panier panier, Promotion promotion = null)
        {
            IdCommande = Guid.NewGuid().ToString();
            Panier = panier;
            Promotion = promotion;
            Etat = EtatCommande.EnAttente;
        }

        public decimal CalculerTotalCommande()
        {
            decimal total = Panier.CalculerTotal();

            if (Promotion != null)
            {
                total = Panier.AppliquerPromotion(Promotion);
            }

            return total;
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
            return $"Commande #{IdCommande}\n" +
                   $"Total : {CalculerTotalCommande():C}\n" +
                   $"État : {Etat}\n" +
                   $"Promotion : {(Promotion != null ? Promotion.Code : "Aucune")}";
        }
    }

}
