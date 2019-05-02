namespace PremierProjet
{
    partial class FrmBienvenue
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
            this.lblBienvenueTexte = new System.Windows.Forms.Label();
            this.lblBienvenueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenueTexte
            // 
            this.lblBienvenueTexte.AutoSize = true;
            this.lblBienvenueTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueTexte.Location = new System.Drawing.Point(71, 85);
            this.lblBienvenueTexte.Name = "lblBienvenueTexte";
            this.lblBienvenueTexte.Size = new System.Drawing.Size(350, 36);
            this.lblBienvenueTexte.TabIndex = 0;
            this.lblBienvenueTexte.Text = "Bonjour, nous sommes le";
            this.lblBienvenueTexte.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblBienvenueDate
            // 
            this.lblBienvenueDate.AutoSize = true;
            this.lblBienvenueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueDate.Location = new System.Drawing.Point(74, 132);
            this.lblBienvenueDate.Name = "lblBienvenueDate";
            this.lblBienvenueDate.Size = new System.Drawing.Size(39, 36);
            this.lblBienvenueDate.TabIndex = 1;
            this.lblBienvenueDate.Text = "...";
            // 
            // FrmBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenueDate);
            this.Controls.Add(this.lblBienvenueTexte);
            this.Name = "FrmBienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cours C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenueTexte;
        private System.Windows.Forms.Label lblBienvenueDate;
    }
}

