using System;
using System.Windows.Forms;

namespace Magasin
{
    public partial class PanierForm : Form
    {
        private Panier panier;

        public PanierForm(Panier panier)
        {
            InitializeComponent();
            this.panier = panier;
            AfficherPanier();
        }
        public event Action<Commande> CommandeValidee;


        private void AfficherPanier()
        {
            btnPasserCommande.Enabled = panier.Articles.Count > 0;
            listBoxPanier.Items.Clear();
            foreach (var article in panier.Articles)
            {
                listBoxPanier.Items.Add($"{article.Nom} - {article.Prix:C} x {article.Quantite}");
            }
            lblTotal.Text = $"Total : {panier.CalculerTotal():C}";
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

            // Créer une nouvelle commande
            var commande = new Commande(panier);

            // Valider la commande
            commande.ValiderCommande();

            // Notifier MainWindow pour ajouter la commande à l'historique
            CommandeValidee?.Invoke(commande);

            // Afficher le récapitulatif de la commande
            MessageBox.Show(commande.ToString(), "Commande validée", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Vider le panier
            panier = new Panier();
            AfficherPanier();
        }




        private void listBoxPanier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
