// Projet : CommandeDePizza
// Auteur : Ian Boehler
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandeDePizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int Anchois;
            int Capres;
            int Jambon;
            int Crevette;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RcmdExtra_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void chkAnchois_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdCommander_Click(object sender, EventArgs e)
        {
            if (RcmdExtra.Checked == true)
            {
                txtCommande.Text = "Pour la " +LbTable.Text + " : pâte " +RcmdExtra.Text;
                
            }
            if (RcmdFine.Checked == true)
            {
                txtCommande.Text = "Pour la " + LbTable.Text + " : pâte " +RcmdFine.Text;
            }
            if (RcmdNormal.Checked == true)
            {
                txtCommande.Text = "Pour la " + LbTable.Text + " : pâte " + RcmdNormal.Text;
            }
            if (RcmdEpaisse.Checked == true)
            {
                txtCommande.Text = "Pour la " + LbTable.Text + " : pâte " + RcmdEpaisse.Text;
            }
            if (chkAnchois.Checked == true)
            {
                txtCommande.Text += " avec " + chkAnchois.Text;
            }
            if (chkCâpres.Checked == true)
            {
                txtCommande.Text += " avec " + chkCâpres.Text;
            }
            if (chkJambon.Checked == true)
            {
                txtCommande.Text += " avec " + chkJambon.Text;
            }
            if (chkCrevettes.Checked == true)
            {
                txtCommande.Text += " avec " + chkCrevettes.Text;
            }


        }

        private void txtCommande_TextChanged(object sender, EventArgs e)
        {

 

            

            
        }

        private void chkCâpres_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RcmdFine_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
