namespace FenêtreFond
{
    partial class FenêtreBleuRouge
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStats = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnBleu = new System.Windows.Forms.Button();
            this.BtnRouge = new System.Windows.Forms.Button();
            this.BtnHDroite = new System.Windows.Forms.Button();
            this.BtnHDroit = new System.Windows.Forms.Button();
            this.BtnBGauche = new System.Windows.Forms.Button();
            this.BtnHGauche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStats
            // 
            this.BtnStats.Location = new System.Drawing.Point(122, 293);
            this.BtnStats.Name = "BtnStats";
            this.BtnStats.Size = new System.Drawing.Size(84, 26);
            this.BtnStats.TabIndex = 0;
            this.BtnStats.Text = "Stats";
            this.BtnStats.UseVisualStyleBackColor = true;
            this.BtnStats.Click += new System.EventHandler(this.BtnStats_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(122, 348);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(84, 26);
            this.BtnQuitter.TabIndex = 1;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnBleu
            // 
            this.BtnBleu.Location = new System.Drawing.Point(122, 84);
            this.BtnBleu.Name = "BtnBleu";
            this.BtnBleu.Size = new System.Drawing.Size(84, 26);
            this.BtnBleu.TabIndex = 2;
            this.BtnBleu.Text = "Bleu";
            this.BtnBleu.UseVisualStyleBackColor = true;
            this.BtnBleu.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnRouge
            // 
            this.BtnRouge.Location = new System.Drawing.Point(122, 141);
            this.BtnRouge.Name = "BtnRouge";
            this.BtnRouge.Size = new System.Drawing.Size(84, 26);
            this.BtnRouge.TabIndex = 3;
            this.BtnRouge.Text = "Rouge";
            this.BtnRouge.UseVisualStyleBackColor = true;
            this.BtnRouge.Click += new System.EventHandler(this.BtnRouge_Click);
            // 
            // BtnHDroite
            // 
            this.BtnHDroite.Location = new System.Drawing.Point(244, 1);
            this.BtnHDroite.Name = "BtnHDroite";
            this.BtnHDroite.Size = new System.Drawing.Size(84, 26);
            this.BtnHDroite.TabIndex = 4;
            this.BtnHDroite.Text = "Haut/Droite";
            this.BtnHDroite.UseVisualStyleBackColor = true;
            this.BtnHDroite.Click += new System.EventHandler(this.BtnHDroite_Click);
            // 
            // BtnHDroit
            // 
            this.BtnHDroit.Location = new System.Drawing.Point(244, 441);
            this.BtnHDroit.Name = "BtnHDroit";
            this.BtnHDroit.Size = new System.Drawing.Size(84, 26);
            this.BtnHDroit.TabIndex = 5;
            this.BtnHDroit.Text = "Bas/Droite";
            this.BtnHDroit.UseVisualStyleBackColor = true;
            this.BtnHDroit.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnBGauche
            // 
            this.BtnBGauche.Location = new System.Drawing.Point(2, 441);
            this.BtnBGauche.Name = "BtnBGauche";
            this.BtnBGauche.Size = new System.Drawing.Size(84, 26);
            this.BtnBGauche.TabIndex = 6;
            this.BtnBGauche.Text = "Bas/Gauche";
            this.BtnBGauche.UseVisualStyleBackColor = true;
            this.BtnBGauche.Click += new System.EventHandler(this.BtnBGauche_Click);
            // 
            // BtnHGauche
            // 
            this.BtnHGauche.Location = new System.Drawing.Point(2, 1);
            this.BtnHGauche.Name = "BtnHGauche";
            this.BtnHGauche.Size = new System.Drawing.Size(84, 26);
            this.BtnHGauche.TabIndex = 7;
            this.BtnHGauche.Text = "Haut/Gauche";
            this.BtnHGauche.UseVisualStyleBackColor = true;
            this.BtnHGauche.Click += new System.EventHandler(this.BtnHGauche_Click);
            // 
            // FenêtreBleuRouge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 468);
            this.Controls.Add(this.BtnHGauche);
            this.Controls.Add(this.BtnBGauche);
            this.Controls.Add(this.BtnHDroit);
            this.Controls.Add(this.BtnHDroite);
            this.Controls.Add(this.BtnRouge);
            this.Controls.Add(this.BtnBleu);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnStats);
            this.Location = new System.Drawing.Point(500, 100);
            this.Name = "FenêtreBleuRouge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FenêtreBleuRouge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStats;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnBleu;
        private System.Windows.Forms.Button BtnRouge;
        private System.Windows.Forms.Button BtnHDroite;
        private System.Windows.Forms.Button BtnHDroit;
        private System.Windows.Forms.Button BtnBGauche;
        private System.Windows.Forms.Button BtnHGauche;
    }
}

