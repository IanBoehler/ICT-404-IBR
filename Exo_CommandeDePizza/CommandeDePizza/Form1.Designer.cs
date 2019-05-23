namespace CommandeDePizza
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbTable = new System.Windows.Forms.TextBox();
            this.grpPâtes = new System.Windows.Forms.GroupBox();
            this.RcmdExtra = new System.Windows.Forms.RadioButton();
            this.RcmdFine = new System.Windows.Forms.RadioButton();
            this.RcmdNormal = new System.Windows.Forms.RadioButton();
            this.RcmdEpaisse = new System.Windows.Forms.RadioButton();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCâpres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.lblCommande = new System.Windows.Forms.Label();
            this.cmdCommander = new System.Windows.Forms.Button();
            this.txtCommande = new System.Windows.Forms.TextBox();
            this.grpPâtes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbTable
            // 
            this.LbTable.Location = new System.Drawing.Point(80, 37);
            this.LbTable.Name = "LbTable";
            this.LbTable.Size = new System.Drawing.Size(38, 20);
            this.LbTable.TabIndex = 1;
            // 
            // grpPâtes
            // 
            this.grpPâtes.Controls.Add(this.RcmdEpaisse);
            this.grpPâtes.Controls.Add(this.RcmdNormal);
            this.grpPâtes.Controls.Add(this.RcmdFine);
            this.grpPâtes.Controls.Add(this.RcmdExtra);
            this.grpPâtes.Location = new System.Drawing.Point(40, 60);
            this.grpPâtes.Name = "grpPâtes";
            this.grpPâtes.Size = new System.Drawing.Size(129, 188);
            this.grpPâtes.TabIndex = 3;
            this.grpPâtes.TabStop = false;
            this.grpPâtes.Text = "Pâte";
            this.grpPâtes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RcmdExtra
            // 
            this.RcmdExtra.AutoSize = true;
            this.RcmdExtra.Location = new System.Drawing.Point(18, 21);
            this.RcmdExtra.Name = "RcmdExtra";
            this.RcmdExtra.Size = new System.Drawing.Size(69, 17);
            this.RcmdExtra.TabIndex = 0;
            this.RcmdExtra.TabStop = true;
            this.RcmdExtra.Text = "Extra-fine";
            this.RcmdExtra.UseVisualStyleBackColor = true;
            // 
            // RcmdFine
            // 
            this.RcmdFine.AutoSize = true;
            this.RcmdFine.Location = new System.Drawing.Point(19, 62);
            this.RcmdFine.Name = "RcmdFine";
            this.RcmdFine.Size = new System.Drawing.Size(45, 17);
            this.RcmdFine.TabIndex = 1;
            this.RcmdFine.TabStop = true;
            this.RcmdFine.Text = "Fine";
            this.RcmdFine.UseVisualStyleBackColor = true;
            // 
            // RcmdNormal
            // 
            this.RcmdNormal.AutoSize = true;
            this.RcmdNormal.Location = new System.Drawing.Point(18, 105);
            this.RcmdNormal.Name = "RcmdNormal";
            this.RcmdNormal.Size = new System.Drawing.Size(58, 17);
            this.RcmdNormal.TabIndex = 2;
            this.RcmdNormal.TabStop = true;
            this.RcmdNormal.Text = "Normal";
            this.RcmdNormal.UseVisualStyleBackColor = true;
            // 
            // RcmdEpaisse
            // 
            this.RcmdEpaisse.AutoSize = true;
            this.RcmdEpaisse.Location = new System.Drawing.Point(19, 144);
            this.RcmdEpaisse.Name = "RcmdEpaisse";
            this.RcmdEpaisse.Size = new System.Drawing.Size(62, 17);
            this.RcmdEpaisse.TabIndex = 3;
            this.RcmdEpaisse.TabStop = true;
            this.RcmdEpaisse.Text = "Epaisse";
            this.RcmdEpaisse.UseVisualStyleBackColor = true;
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(242, 81);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 4;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCâpres
            // 
            this.chkCâpres.AutoSize = true;
            this.chkCâpres.Location = new System.Drawing.Point(242, 122);
            this.chkCâpres.Name = "chkCâpres";
            this.chkCâpres.Size = new System.Drawing.Size(59, 17);
            this.chkCâpres.TabIndex = 5;
            this.chkCâpres.Text = "Câpres";
            this.chkCâpres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(242, 165);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 6;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(242, 204);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 7;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(38, 317);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(60, 13);
            this.lblCommande.TabIndex = 8;
            this.lblCommande.Text = "Commande";
            // 
            // cmdCommander
            // 
            this.cmdCommander.Location = new System.Drawing.Point(302, 312);
            this.cmdCommander.Name = "cmdCommander";
            this.cmdCommander.Size = new System.Drawing.Size(75, 23);
            this.cmdCommander.TabIndex = 9;
            this.cmdCommander.Text = "Commander";
            this.cmdCommander.UseVisualStyleBackColor = true;
            // 
            // txtCommande
            // 
            this.txtCommande.BackColor = System.Drawing.Color.Yellow;
            this.txtCommande.Location = new System.Drawing.Point(36, 348);
            this.txtCommande.Multiline = true;
            this.txtCommande.Name = "txtCommande";
            this.txtCommande.Size = new System.Drawing.Size(341, 88);
            this.txtCommande.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.txtCommande);
            this.Controls.Add(this.cmdCommander);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCâpres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.grpPâtes);
            this.Controls.Add(this.LbTable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.grpPâtes.ResumeLayout(false);
            this.grpPâtes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LbTable;
        private System.Windows.Forms.GroupBox grpPâtes;
        private System.Windows.Forms.RadioButton RcmdEpaisse;
        private System.Windows.Forms.RadioButton RcmdNormal;
        private System.Windows.Forms.RadioButton RcmdFine;
        private System.Windows.Forms.RadioButton RcmdExtra;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCâpres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Button cmdCommander;
        private System.Windows.Forms.TextBox txtCommande;
    }
}

