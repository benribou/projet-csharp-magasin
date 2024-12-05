namespace Magasin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());

            var article1 = new Article("Stylo", 1.50m, 100);
            var article2 = new ArticleType("Pomme", 0.80m, 50, TypeArticle.Alimentaire);
            var article3 = new ArticleType("T-shirt", 15.00m, 20, TypeArticle.Vêtements);

            article1.Afficher();
            article2.Afficher();
            article3.Afficher();
        }
    }
}