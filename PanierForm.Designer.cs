namespace Magasin
{
    partial class PanierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPanier = new ListBox();
            lblTotal = new Label();
            btnSupprimerDuPanier = new Button();
            btnPasserCommande = new Button();
            txtCodePromo = new TextBox();
            btnAppliquerPromo = new Button();
            SuspendLayout();
            // 
            // listBoxPanier
            // 
            listBoxPanier.Location = new Point(12, 12);
            listBoxPanier.Name = "listBoxPanier";
            listBoxPanier.Size = new Size(300, 199);
            listBoxPanier.TabIndex = 0;
            listBoxPanier.SelectedIndexChanged += listBoxPanier_SelectedIndexChanged;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(12, 220);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(300, 23);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total : 0,00 €";
            // 
            // btnSupprimerDuPanier
            // 
            btnSupprimerDuPanier.Location = new Point(333, 12);
            btnSupprimerDuPanier.Name = "btnSupprimerDuPanier";
            btnSupprimerDuPanier.Size = new Size(103, 23);
            btnSupprimerDuPanier.TabIndex = 2;
            btnSupprimerDuPanier.Text = "Supprimer";
            btnSupprimerDuPanier.UseVisualStyleBackColor = true;
            btnSupprimerDuPanier.Click += btnSupprimerDuPanier_Click;
            // 
            // btnPasserCommande
            // 
            btnPasserCommande.Location = new Point(12, 280);
            btnPasserCommande.Name = "btnPasserCommande";
            btnPasserCommande.Size = new Size(150, 30);
            btnPasserCommande.TabIndex = 0;
            btnPasserCommande.Text = "Passer commande";
            btnPasserCommande.UseVisualStyleBackColor = true;
            btnPasserCommande.Click += BtnPasserCommande_Click;
            // 
            // txtCodePromo
            // 
            txtCodePromo.Location = new Point(12, 250);
            txtCodePromo.Name = "txtCodePromo";
            txtCodePromo.Size = new Size(150, 23);
            txtCodePromo.TabIndex = 1;
            // 
            // btnAppliquerPromo
            // 
            btnAppliquerPromo.Location = new Point(170, 250);
            btnAppliquerPromo.Name = "btnAppliquerPromo";
            btnAppliquerPromo.Size = new Size(142, 23);
            btnAppliquerPromo.TabIndex = 0;
            btnAppliquerPromo.Text = "Appliquer Promo";
            btnAppliquerPromo.Click += BtnAppliquerPromo_Click;
            Controls.Add(btnAppliquerPromo);
            // 
            // PanierForm
            // 
            ClientSize = new Size(467, 336);
            Controls.Add(btnAppliquerPromo);
            Controls.Add(txtCodePromo);
            Controls.Add(btnPasserCommande);
            Controls.Add(btnSupprimerDuPanier);
            Controls.Add(lblTotal);
            Controls.Add(listBoxPanier);
            Name = "PanierForm";
            Load += PanierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPanier;
        private Label lblTotal;
        private Button btnSupprimerDuPanier;
        private Button btnPasserCommande;
        private TextBox txtCodePromo;
        private Button btnAppliquerPromo;
    }
}