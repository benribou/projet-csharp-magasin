namespace Magasin
{
    partial class HistoriqueForm
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
            listBoxHistorique = new ListBox();
            SuspendLayout();
            // 
            // listBoxHistorique
            // 
            listBoxHistorique.Location = new Point(12, 12);
            listBoxHistorique.Name = "listBoxHistorique";
            listBoxHistorique.Size = new Size(766, 289);
            listBoxHistorique.TabIndex = 0;
            // 
            // HistoriqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxHistorique);
            Name = "HistoriqueForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxHistorique;
    }
}