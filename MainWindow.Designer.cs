
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
            btnAjouterArticle.BackColor = Color.Green; // Fond vert
            btnAjouterArticle.ForeColor = Color.White; // Texte en blanc
            btnAjouterArticle.FlatStyle = FlatStyle.Flat; // Style plat
            btnAjouterArticle.FlatAppearance.BorderSize = 0; // Suppression de la bordure
            btnAjouterArticle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point); // Texte en gras
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
            btnModifierArticle.Visible = false;
            btnModifierArticle.Location = new Point(12, 286);
            btnModifierArticle.Name = "btnModifierArticle";
            btnModifierArticle.Size = new Size(95, 27);
            btnModifierArticle.TabIndex = 2;
            btnModifierArticle.Text = "Modifier";
            btnModifierArticle.UseVisualStyleBackColor = true;
            btnModifierArticle.BackColor = Color.Orange; // Fond orange
            btnModifierArticle.ForeColor = Color.White; // Texte en blanc
            btnModifierArticle.FlatStyle = FlatStyle.Flat; // Style plat
            btnModifierArticle.FlatAppearance.BorderSize = 0; // Suppression de la bordure
            btnModifierArticle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point); // Texte en gras
            btnModifierArticle.Click += BtnModifierArticle_Click;

            // 
            // btnSupprimerArticle
            // 
            btnSupprimerArticle.Visible = false;
            btnSupprimerArticle.Location = new Point(118, 286);
            btnSupprimerArticle.Name = "btnSupprimerArticle";
            btnSupprimerArticle.Size = new Size(95, 27);
            btnSupprimerArticle.TabIndex = 3;
            btnSupprimerArticle.Text = "Supprimer";
            btnSupprimerArticle.UseVisualStyleBackColor = true;
            btnSupprimerArticle.BackColor = Color.Red;
            btnSupprimerArticle.ForeColor = Color.White;
            btnSupprimerArticle.FlatStyle = FlatStyle.Flat;
            btnSupprimerArticle.FlatAppearance.BorderSize = 0;
            btnSupprimerArticle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimerArticle.Click += BtnSupprimerArticle_Click;

            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 507);
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
    }
}
