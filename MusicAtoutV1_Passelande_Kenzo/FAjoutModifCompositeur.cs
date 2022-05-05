using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MusicAtoutV1_Passelande_Kenzo
{
    public partial class FAjoutModifCompositeur : Form
    {
        public FAjoutModifCompositeur()
        {
            InitializeComponent();
        }

        private void FAjoutModifCompositeur_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = Modele.listestyle();
            cboStyle.DataSource = bsStyle;

            cboNation.ValueMember = "idNation";//permet de stocker l'identifiant
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = Modele.listenationalite();
            cboNation.DataSource = bsNation;



            
            if (Modele.ActionChoisie == 2)

            {

                txtnom.Text = Modele.CompositeurChoisi.nomCompositeur.ToString();
                txtPrenom.Text = Modele.CompositeurChoisi.prenomCompositeur.ToString();
                txtRemarque.Text = Modele.CompositeurChoisi.remarque.ToString();
                txtNais.Text = Modele.CompositeurChoisi.anNais.ToString();
                txtMort.Text = Modele.CompositeurChoisi.anMort.ToString();
                cboNation.Text = Modele.CompositeurChoisi.NATIONALITE.libNation.ToString();
                cboStyle.Text = Modele.CompositeurChoisi.STYLE.libStyle.ToString();
            }



        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bsCompositeur_CurrentChanged(object sender, EventArgs e)
        {



        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!test()) return;

            if (Modele.ActionChoisie == 1)
            {
                Modele.AjoutCompositeur(txtnom.Text, txtPrenom.Text, txtRemarque.Text, Convert.ToInt32(txtMort.Text), Convert.ToInt32(txtNais.Text), cboNation.SelectedIndex + 1, cboStyle.SelectedIndex + 1);
                MessageBox.Show("Ajout réussi");
            }
            if (Modele.ActionChoisie == 2)
            {
                Modele.ModifCompositeur(txtnom.Text, txtPrenom.Text, txtRemarque.Text, Convert.ToInt32(txtMort.Text), Convert.ToInt32(txtNais.Text), cboNation.SelectedIndex + 1, cboStyle.SelectedIndex + 1);
                MessageBox.Show("Modification réussie");
            }
          

        }

        private bool test()
        {
            bool vretour = true;
            error1.Clear();
            if (String.IsNullOrEmpty(txtnom.Text))
            {
                error1.SetError(txtnom, "Nom compositeur nécessaire");
                vretour = false;
            }
            else
            {
                if (String.IsNullOrEmpty(txtPrenom.Text))
                {
                    error1.SetError(txtPrenom, "Prénom compositeur nécéssaire");
                    vretour = false;
                }
            }
            return vretour;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form monForm = new FCompositeurNation();
            //monForm.MdiParent = this;la
            monForm.Show();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






