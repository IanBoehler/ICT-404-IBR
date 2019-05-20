using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenêtreFond
{
    public partial class FenêtreBleuRouge : Form
    {
        int compteur = 0;
        int move = 0;
        public FenêtreBleuRouge()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SetBounds(1580, 580, 345, 510);
            move++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            compteur++;
        }

        private void BtnHDroite_Click(object sender, EventArgs e)
        {
            this.SetBounds(1580, 0, 345, 510);
            move++;

        }

        private void BtnRouge_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            compteur++;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds(55, 0, 345, 510);
            move++;
        }

        private void BtnBGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds(55, 580, 345, 510);
            move++;
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(move + " déplacement "+ compteur+ " changement de couleurs");
        }
    }
}
