namespace Magasin
{
    public partial class MainWindow : Form
    {
        private List<Article> articles;

        public MainWindow()
        {
            InitializeComponent();
            InitialiserArticles();
            AfficherArticles();
        }

        private void InitialiserArticles()
        {
            articles = new List<Article>
            {
                new Article("Stylo", 1.50m, 100),
                new ArticleType("Pomme", 0.80m, 50, TypeArticle.Alimentaire),
                new ArticleType("T-shirt", 15.00m, 20, TypeArticle.V�tements)
            };
        }

        private void AfficherArticles()
        {
            listBox1.Items.Clear();
            foreach (var article in articles)
            {
                listBox1.Items.Add($"{article.Nom} - {article.Prix:C} - Quantit� : {article.Quantite}");
            }
        }

        private void BtnAjouterArticle_Click(object sender, EventArgs e)
        {
            using (var form = new AjoutArticleForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var nouvelArticle = form.Tag as Article;
                    if (nouvelArticle != null)
                    {
                        articles.Add(nouvelArticle);
                        AfficherArticles();
                    }
                }
            }
        }

        private void BtnModifierArticle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // R�cup�rer l'article s�lectionn�
                var article = articles[listBox1.SelectedIndex];

                // Ouvrir le formulaire de modification avec les donn�es de l'article
                using (var form = new AjoutArticleForm(article))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // R�cup�rer les nouvelles donn�es de l'article
                        var updatedArticle = form.Tag as Article;
                        if (updatedArticle != null)
                        {
                            article.Nom = updatedArticle.Nom;
                            article.Prix = updatedArticle.Prix;
                            article.Quantite = updatedArticle.Quantite;

                            // Mettre � jour l'affichage
                            AfficherArticles();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un article � modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isItemSelected = listBox1.SelectedIndex != -1;

            btnModifierArticle.Visible = isItemSelected;
            btnSupprimerArticle.Visible = isItemSelected;
        }



        private void BtnSupprimerArticle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var article = articles[listBox1.SelectedIndex];
                var result = MessageBox.Show($"�tes-vous s�r de vouloir supprimer l'article : {article.Nom} ?", "Supprimer",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    articles.RemoveAt(listBox1.SelectedIndex);
                    AfficherArticles();
                }
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            AfficherArticles();
        }
    }
}
