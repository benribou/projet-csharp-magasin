namespace Magasin
{
    public enum TypeArticle
    {
        Alimentaire,
        Vêtements,
        Droguerie
    }

    public class ArticleType : Article
    {
        public TypeArticle Type { get; set; }

        public ArticleType(string nom, decimal prix, int quantite, TypeArticle type)
            : base(nom, prix, quantite)
        {
            Type = type;
        }

        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Type : {Type}");
        }
    }
}