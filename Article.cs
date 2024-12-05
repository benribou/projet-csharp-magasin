using System;

namespace Magasin
{
    public class Article
    {
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public int Quantite { get; set; }

        public Article(string nom, decimal prix, int quantite)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prix: {Prix:C}, Quantité: {Quantite}");
        }

        public void Ajouter(int quantity)
        {
            Quantite += quantity;
        }

        public void Retirer(int quantity)
        {
            if (quantity > Quantite)
            {
                throw new InvalidOperationException("Quantité insuffisante en stock.");
            }
            Quantite -= quantity;
        }
    }
}