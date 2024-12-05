
namespace Magasin
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btnAjouterArticle = new Button();
            btnModifierArticle = new Button();
            btnSupprimerArticle = new Button();
            btnVoirPanier = new Button();
            BtnAjouterAuPanier = new Button();
            btnVoirHistorique = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(363, 214);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAjouterArticle
            // 
            btnAjouterArticle.BackColor = Color.Green;
            btnAjouterArticle.FlatAppearance.BorderSize = 0;
            btnAjouterArticle.FlatStyle = FlatStyle.Flat;
            btnAjouterArticle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAjouterArticle.ForeColor = Color.White;
            btnAjouterArticle.Location = new Point(12, 12);
            btnAjouterArticle.Name = "btnAjouterArticle";
            btnAjouterArticle.Size = new Size(121, 29);
            btnAjouterArticle.TabIndex = 1;
            btnAjouterArticle.Text = "Ajouter un article";
            btnAjouterArticle.UseVisualStyleBackColor = false;
            btnAjouterArticle.Click += BtnAjouterArticle_Click;
            // 
            // btnModifierArticle
            // 
            btnModifierArticle.BackColor = Color.Orange;
            btnModifierArticle.FlatAppearance.BorderSize = 0;
            btnModifierArticle.FlatStyle = FlatStyle.Flat;
            btnModifierArticle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifierArticle.ForeColor = Color.White;
            btnModifierArticle.Location = new Point(12, 286);
            btnModifierArticle.Name = "btnModifierArticle";
            btnModifierArticle.Size = new Size(80, 27);
            btnModifierArticle.TabIndex = 2;
            btnModifierArticle.Text = "Modifier";
            btnModifierArticle.UseVisualStyleBackColor = false;
            btnModifierArticle.Visible = false;
            btnModifierArticle.Click += BtnModifierArticle_Click;
            // 
            // btnSupprimerArticle
            // 
            btnSupprimerArticle.BackColor = Color.Red;
            btnSupprimerArticle.FlatAppearance.BorderSize = 0;
            btnSupprimerArticle.FlatStyle = FlatStyle.Flat;
            btnSupprimerArticle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSupprimerArticle.ForeColor = Color.White;
            btnSupprimerArticle.Location = new Point(102, 286);
            btnSupprimerArticle.Name = "btnSupprimerArticle";
            btnSupprimerArticle.Size = new Size(84, 27);
            btnSupprimerArticle.TabIndex = 3;
            btnSupprimerArticle.Text = "Supprimer";
            btnSupprimerArticle.UseVisualStyleBackColor = false;
            btnSupprimerArticle.Visible = false;
            btnSupprimerArticle.Click += BtnSupprimerArticle_Click;
            // 
            // btnVoirPanier
            // 
            btnVoirPanier.Location = new Point(393, 56);
            btnVoirPanier.Name = "btnVoirPanier";
            btnVoirPanier.Size = new Size(139, 29);
            btnVoirPanier.TabIndex = 4;
            btnVoirPanier.Text = "Voir le panier";
            btnVoirPanier.UseVisualStyleBackColor = true;
            btnVoirPanier.Click += BtnVoirPanier_Click;
            // 
            // BtnAjouterAuPanier
            // 
            BtnAjouterAuPanier.BackColor = Color.Blue;
            BtnAjouterAuPanier.FlatAppearance.BorderSize = 0;
            BtnAjouterAuPanier.FlatStyle = FlatStyle.Flat;
            BtnAjouterAuPanier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnAjouterAuPanier.ForeColor = Color.White;
            BtnAjouterAuPanier.Location = new Point(233, 286);
            BtnAjouterAuPanier.Name = "BtnAjouterAuPanier";
            BtnAjouterAuPanier.Size = new Size(142, 27);
            BtnAjouterAuPanier.TabIndex = 5;
            BtnAjouterAuPanier.Text = "Ajouter au panier";
            BtnAjouterAuPanier.UseVisualStyleBackColor = false;
            BtnAjouterAuPanier.Visible = false;
            BtnAjouterAuPanier.Click += BtnAjouterAuPanier_Click;
            // 
            // btnVoirHistorique
            // 
            btnVoirHistorique.Location = new Point(393, 95);
            btnVoirHistorique.Name = "btnVoirHistorique";
            btnVoirHistorique.Size = new Size(205, 30);
            btnVoirHistorique.TabIndex = 0;
            btnVoirHistorique.Text = "Historique de commandes";
            btnVoirHistorique.UseVisualStyleBackColor = true;
            btnVoirHistorique.Click += BtnVoirHistorique_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 507);
            Controls.Add(btnVoirHistorique);
            Controls.Add(BtnAjouterAuPanier);
            Controls.Add(btnVoirPanier);
            Controls.Add(btnSupprimerArticle);
            Controls.Add(btnModifierArticle);
            Controls.Add(btnAjouterArticle);
            Controls.Add(listBox1);
            Name = "MainWindow";
            Text = "Ajouter un article";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listBox1;
        private Button btnAjouterArticle;
        private Button btnModifierArticle;
        private Button btnSupprimerArticle;
        private Button btnVoirPanier;
        private Button BtnAjouterAuPanier;
        private Button btnVoirHistorique;
    }
}
