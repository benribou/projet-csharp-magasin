using System;
using System.Windows.Forms;

namespace Magasin
{
    public partial class AjoutArticleForm : Form
    {
        public AjoutArticleForm()
        {
            InitializeComponent();
        }

        public AjoutArticleForm(Article article) : this()
        {
            if (article != null)
            {
                textNom.Text = article.Nom;
                txtPrix.Text = article.Prix.ToString();
                txtQuantite.Text = article.Quantite.ToString();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNom.Text))
            {
                MessageBox.Show("Veuillez entrer un nom valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrix.Text, out decimal prix) || prix <= 0)
            {
                MessageBox.Show("Veuillez entrer un prix valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantite.Text, out int quantite) || quantite < 0)
            {
                MessageBox.Show("Veuillez entrer une quantité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Tag = new Article(textNom.Text, prix, quantite);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }


}
