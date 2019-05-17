﻿// Programme : Exo-Deduction_Fiscales
// Auteur : Ian Boehler
// Date : 13.05.2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_DEDUCTIONS_FISCALES
{
    public partial class Deduction : Form
    {
        public Deduction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Deduction_Load(object sender, EventArgs e)
        {
            TextBas.Visible = false;
        }

        private void BtnCalcul_Click(object sender, EventArgs e)
        {
            
            int Rannuel = int.Parse(textBox1.Text);
            float Coefficient = float.Parse(BoxRAB.Text);
            int Jeune = int.Parse(textBox2.Text);
            int transport = int.Parse(textBox3.Text);
            float Rabais = float.Parse(textBox4.Text);
            float Resultat;
            Resultat = Rannuel / Coefficient;
                    
            if (CocheJeune.Checked == true)
            {
                textBox2.Enabled = true;
                Resultat = Resultat - (Jeune - Resultat);
                
            }
            else
            {
                textBox2.Enabled = false;
            





            }
            if (CocheRabais.Checked == true)
            {
                Resultat = Resultat - (Rabais / 100 * Resultat);
                
            }
            else
            {
                CocheRabais.Enabled = true;
            }
            TextBas.Visible = true;

            TextBas.Text = String.Format("Revenu imposable : {0:C2}", Resultat);
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CocheJeune_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
