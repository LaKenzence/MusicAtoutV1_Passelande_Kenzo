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
    public partial class FCompositeurNation : Form
    {
        public FCompositeurNation()
        {
            InitializeComponent();
        }

        private void Nationalité(object sender, EventArgs e)
        {

        }

        private void françaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";//permet de stocker l'identifiant
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = Modele.listenationalite();
            cboNation.DataSource = bsNation;
        }

        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {
                bsCompositeur.DataSource = ((NATIONALITE)bsNation.Current).COMPOSITEUR.Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur })
                                           .OrderBy(x => x.nomCompositeur);
                dgvCompositeur.DataSource = bsCompositeur;
                dgvCompositeur.Columns[0].HeaderText = "NOM";
                dgvCompositeur.Columns[1].HeaderText = "PRENOM";
                dgvCompositeur.Columns[2].HeaderText = "STYLE";
                dgvCompositeur.Columns[3].HeaderText = "Né le";
                dgvCompositeur.Columns[4].HeaderText = "Mort le";
                dgvCompositeur.Columns[5].HeaderText = "Informations";
                dgvCompositeur.Columns[6].Visible = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

                bsCompositeur.DataSource = Modele.listecompositeur();
                dgvCompositeur.DataSource = bsCompositeur;
            
                dgvCompositeur.Columns[0].HeaderText = "NOM";
                dgvCompositeur.Columns[1].HeaderText = "PRENOM";
                dgvCompositeur.Columns[2].HeaderText = "STYLE";
                dgvCompositeur.Columns[3].HeaderText = "Né le";
                dgvCompositeur.Columns[4].HeaderText = "Mort le";
                dgvCompositeur.Columns[5].HeaderText = "Informations";
                dgvCompositeur.Columns[6].Visible = false;
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
           
            Modele.ActionChoisie = 1;
            Form monForm = new FAjoutModifCompositeur();
            //monForm.MdiParent = this;la
            monForm.Show();
            bsCompositeur.DataSource = ((NATIONALITE)bsNation.Current).COMPOSITEUR.Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur })
                                           .OrderBy(x => x.nomCompositeur);
                dgvCompositeur.DataSource = bsCompositeur;
                dgvCompositeur.Columns[0].HeaderText = "NOM";
                dgvCompositeur.Columns[1].HeaderText = "PRENOM";
                dgvCompositeur.Columns[2].HeaderText = "STYLE";
                dgvCompositeur.Columns[3].HeaderText = "Né le";
                dgvCompositeur.Columns[4].HeaderText = "Mort le";
                dgvCompositeur.Columns[5].HeaderText = "Informations";
                dgvCompositeur.Columns[6].Visible = false;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modele.ActionChoisie = 2;
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);

            Modele.CompositeurChoisi = Modele.donneCompo(id);
            
            Form monForm = new FAjoutModifCompositeur();
            //monForm.MdiParent = this;la
            monForm.Show();

        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);

            Modele.CompositeurChoisi = Modele.donneCompo(id);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer le compositeur :" + Modele.CompositeurChoisi.prenomCompositeur.Trim() + " - " + Modele.CompositeurChoisi.nomCompositeur.Trim(), "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modele.SuppCompositeur();
                MessageBox.Show("Suppression réussie");
            }
        }

        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsCompositeur_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
