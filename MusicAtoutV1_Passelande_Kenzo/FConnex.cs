using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Passelande_Kenzo
{
    public partial class FConnex : Form
    {
        public FConnex()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAncienMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Modele.userexists(txtIdentifiant.Text))
            {
                if (Modele.passexists(txtPasswd.Text))
                {
                    MessageBox.Show("Connexion réussie !");
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion refusée");
                }
            }
            else
            {
                MessageBox.Show("Connexion refusée");
            }

        }
     
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Modele.userexists(txtIdentifiant.Text))
            {
                if (Modele.passexists(txtAncienMDP.Text))
                {
                    Modele.changepass(txtnewmdp.Text);
                }
            }
        }

        private void btnModifMdp_Click_1(object sender, EventArgs e)
        {
            txtAncienMDP.Visible = true;
            label3.Visible = true;
            lblNewMDP.Visible = true;
            txtnewmdp.Visible = true;
            btnOk.Visible = true;
        }

        private void FConnex_Load_1(object sender, EventArgs e)
        {
            txtPasswd.PasswordChar = '*';
        }
    }
}

