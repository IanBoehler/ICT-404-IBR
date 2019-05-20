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
        public FenêtreBleuRouge()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue; 
        }

        private void BtnHDroite_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRouge_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
