// Programme : Exo-Deduction_Fiscales
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
            if 
            int Rannuel = int.Parse(textBox1.Text);
            float Coefficient = float.Parse(BoxRAB.Text);
            int Jeune = int.Parse(textBox1.Text);
            int transport = int.Parse(textBox3.Text);
            int Rabais = int.Parse(textBox4.Text);
            float Resultat;
            Resultat = Rannuel / Coefficient;

        }

    }
}
