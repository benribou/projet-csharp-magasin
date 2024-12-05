namespace Magasin
{
    public enum TypePromotion
    {
        Pourcentage,
        MontantFixe
    }

    public class Promotion
    {
        public string Code { get; private set; }
        public TypePromotion Type { get; private set; }
        public decimal Valeur { get; private set; }

        public Promotion(string code, TypePromotion type, decimal valeur)
        {
            Code = code;
            Type = type;
            Valeur = valeur;
        }

        public decimal AppliquerPromotion(decimal total)
        {
            if (Type == TypePromotion.Pourcentage)
            {
                return total - (total * (Valeur / 100));
            }
            else if (Type == TypePromotion.MontantFixe)
            {
                return total - Valeur;
            }
            return total;
        }
    }
}