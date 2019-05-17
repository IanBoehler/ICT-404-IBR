namespace Exo_DEDUCTIONS_FISCALES
{
    partial class Deduction
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
            this.label2 = new System.Windows.Forms.Label();
            this.BoxRAB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CocheJeune = new System.Windows.Forms.CheckBox();
            this.CocheTransport = new System.Windows.Forms.CheckBox();
            this.CocheRabais = new System.Windows.Forms.CheckBox();
            this.TextBas = new System.Windows.Forms.Label();
            this.BtnCalcul = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenu annuel brut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coefficient familial";
            // 
            // BoxRAB
            // 
            this.BoxRAB.Location = new System.Drawing.Point(392, 108);
            this.BoxRAB.Name = "BoxRAB";
            this.BoxRAB.Size = new System.Drawing.Size(63, 20);
            this.BoxRAB.TabIndex = 3;
            this.BoxRAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CocheJeune
            // 
            this.CocheJeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocheJeune.Location = new System.Drawing.Point(31, 178);
            this.CocheJeune.Name = "CocheJeune";
            this.CocheJeune.Size = new System.Drawing.Size(201, 33);
            this.CocheJeune.TabIndex = 5;
            this.CocheJeune.Text = "Déduction Jeune";
            this.CocheJeune.UseVisualStyleBackColor = true;
            this.CocheJeune.CheckedChanged += new System.EventHandler(this.CocheJeune_CheckedChanged);
            // 
            // CocheTransport
            // 
            this.CocheTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocheTransport.Location = new System.Drawing.Point(31, 209);
            this.CocheTransport.Name = "CocheTransport";
            this.CocheTransport.Size = new System.Drawing.Size(219, 32);
            this.CocheTransport.TabIndex = 6;
            this.CocheTransport.Text = "Déduction transport";
            this.CocheTransport.UseVisualStyleBackColor = true;
            // 
            // CocheRabais
            // 
            this.CocheRabais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocheRabais.Location = new System.Drawing.Point(31, 240);
            this.CocheRabais.Name = "CocheRabais";
            this.CocheRabais.Size = new System.Drawing.Size(113, 29);
            this.CocheRabais.TabIndex = 7;
            this.CocheRabais.Text = "Rabais fidélité (%)";
            this.CocheRabais.UseVisualStyleBackColor = true;
            // 
            // TextBas
            // 
            this.TextBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBas.Location = new System.Drawing.Point(32, 398);
            this.TextBas.Name = "TextBas";
            this.TextBas.Size = new System.Drawing.Size(423, 43);
            this.TextBas.TabIndex = 8;
            this.TextBas.Text = "Revenu imposable : fr.";
            this.TextBas.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnCalcul
            // 
            this.BtnCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcul.Location = new System.Drawing.Point(135, 313);
            this.BtnCalcul.Name = "BtnCalcul";
            this.BtnCalcul.Size = new System.Drawing.Size(167, 53);
            this.BtnCalcul.TabIndex = 9;
            this.BtnCalcul.Text = "Calcul";
            this.BtnCalcul.UseVisualStyleBackColor = true;
            this.BtnCalcul.Click += new System.EventHandler(this.BtnCalcul_Click);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(392, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "900";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(392, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "650";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(392, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "2.2";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Deduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnCalcul);
            this.Controls.Add(this.TextBas);
            this.Controls.Add(this.CocheRabais);
            this.Controls.Add(this.CocheTransport);
            this.Controls.Add(this.CocheJeune);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BoxRAB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deduction";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Deduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxRAB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CocheJeune;
        private System.Windows.Forms.CheckBox CocheTransport;
        private System.Windows.Forms.CheckBox CocheRabais;
        private System.Windows.Forms.Label TextBas;
        private System.Windows.Forms.Button BtnCalcul;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

