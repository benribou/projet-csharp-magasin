namespace Magasin
{
    partial class AjoutArticleForm
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
            labelNom = new Label();
            textNom = new TextBox();
            txtPrix = new TextBox();
            label1 = new Label();
            txtQuantite = new TextBox();
            label2 = new Label();
            btnAjouter = new Button();
            btnAnnuler = new Button();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(22, 23);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(91, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom de l'article";
            // 
            // textNom
            // 
            textNom.Location = new Point(22, 41);
            textNom.Name = "textNom";
            textNom.Size = new Size(187, 23);
            textNom.TabIndex = 1;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(22, 104);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(187, 23);
            txtPrix.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 86);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "Prix";
            // 
            // txtQuantite
            // 
            txtQuantite.Location = new Point(22, 174);
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new Size(187, 23);
            txtQuantite.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 156);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantité";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(134, 215);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += this.btnAjouter_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(22, 215);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 7;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // AjoutArticleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Controls.Add(txtQuantite);
            Controls.Add(label2);
            Controls.Add(txtPrix);
            Controls.Add(label1);
            Controls.Add(textNom);
            Controls.Add(labelNom);
            Name = "AjoutArticleForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox textNom;
        private TextBox txtPrix;
        private Label label1;
        private TextBox txtQuantite;
        private Label label2;
        private Button btnAjouter;
        private Button btnAnnuler;
    }
}