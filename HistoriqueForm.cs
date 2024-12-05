using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Magasin
{
    public partial class HistoriqueForm : Form
    {
        private List<Commande> commandes;

        public HistoriqueForm(List<Commande> commandes)
        {
            InitializeComponent();
            this.commandes = commandes;
            AfficherHistorique();
        }

        private void AfficherHistorique()
        {
            listBoxHistorique.Items.Clear();
            foreach (var commande in commandes)
            {
                listBoxHistorique.Items.Add(commande.ToString());
            }
        }
    }
}
