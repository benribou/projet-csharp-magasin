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
                new ArticleType("T-shirt", 15.00m, 20, TypeArticle.Vêtements)
            };
        }

        private void AfficherArticles()
        {
            listBox1.Items.Clear();
            foreach (var article in articles)
            {
                listBox1.Items.Add($"{article.Nom} - {article.Prix:C} - Quantité : {article.Quantite}");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            AfficherArticles();
        }
    }
}
