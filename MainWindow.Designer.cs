﻿
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(376, 214);
            listBox1.TabIndex = 0;
            // 
            // btnAjouterArticle
            // 
            btnAjouterArticle.Location = new Point(402, 13);
            btnAjouterArticle.Name = "btnAjouterArticle";
            btnAjouterArticle.Size = new Size(121, 23);
            btnAjouterArticle.TabIndex = 1;
            btnAjouterArticle.Text = "Ajouter un article";
            btnAjouterArticle.UseVisualStyleBackColor = true;
            btnAjouterArticle.Click += this.BtnAjouterArticle_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
