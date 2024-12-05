﻿using System;
using System.Collections.Generic;

namespace Magasin
{
    public class Panier
    {
        public List<Article> Articles { get; private set; }

        public Panier()
        {
            Articles = new List<Article>();
        }

        public void AjouterArticle(Article article, int quantite)
        {
            var existingArticle = Articles.Find(a => a.Nom == article.Nom);
            if (existingArticle != null)
            {
                existingArticle.Quantite += quantite;
            }
            else
            {
                Articles.Add(new Article(article.Nom, article.Prix, quantite));
            }
        }

        public void RetirerArticle(Article article)
        {
            Articles.Remove(article);
        }

        public decimal CalculerTotal()
        {
            decimal total = 0;
            foreach (var article in Articles)
            {
                total += article.Prix * article.Quantite;
            }
            return total;
        }
    }
}