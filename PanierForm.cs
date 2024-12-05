using System;
using System.Windows.Forms;

namespace Magasin
{
    public partial class PanierForm : Form
    {
        private Panier panier;
        private Promotion promotionActive = null;

        private readonly List<Promotion> promotions = new List<Promotion>
            {
                new Promotion("PROMO10", TypePromotion.Pourcentage, 10), // Réduction de 10%
                new Promotion("REDUCTION5", TypePromotion.MontantFixe, 5) // Réduction de 5 €
            };


        public PanierForm(Panier panier)
        {
            InitializeComponent();
            this.panier = panier;
            AfficherPanier();
        }
        public event Action<Commande> CommandeValidee;


        private void AfficherPanier()
        {
            listBoxPanier.Items.Clear();
            foreach (var article in panier.Articles)
            {
                listBoxPanier.Items.Add($"{article.Nom} - {article.Prix:C} x {article.Quantite}");
            }

            decimal total = panier.CalculerTotal();

            if (promotionActive != null)
            {
                total = panier.AppliquerPromotion(promotionActive);
            }

            lblTotal.Text = $"Total : {total:C}";
        }


        private void btnSupprimerDuPanier_Click(object sender, EventArgs e)
        {
            if (listBoxPanier.SelectedIndex != -1)
            {
                var article = panier.Articles[listBoxPanier.SelectedIndex];
                panier.RetirerArticle(article);
                AfficherPanier();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPasserCommande_Click(object sender, EventArgs e)
        {
            if (panier.Articles.Count == 0)
            {
                MessageBox.Show("Votre panier est vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var commande = new Commande(panier, promotionActive);

            commande.ValiderCommande();

            CommandeValidee?.Invoke(commande);

            MessageBox.Show(commande.ToString(), "Commande validée", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panier = new Panier();
            promotionActive = null;
            AfficherPanier();
        }


        private void BtnAppliquerPromo_Click(object sender, EventArgs e)
        {
            string codePromo = txtCodePromo.Text.Trim();

            var promo = promotions.FirstOrDefault(p => p.Code.Equals(codePromo, StringComparison.OrdinalIgnoreCase));
            if (promo != null)
            {
                promotionActive = promo;
                MessageBox.Show($"Code promo '{promo.Code}' appliqué avec succès !", "Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AfficherPanier();
            }
            else
            {
                MessageBox.Show("Code promo invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxPanier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanierForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCodePromo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
