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
    public partial class FcompositeurStyle : Form
    {
        public FcompositeurStyle()
        {
            InitializeComponent();
        }

        private void FcompositeurStyle_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = Modele.listestyle();
            cboStyle.DataSource = bsStyle;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            bsCompositeur.DataSource = ((STYLE)bsStyle.Current).COMPOSITEUR;

            txtSelectionné.Text = ((COMPOSITEUR)bsCompositeur.Current).nomCompositeur.ToString();
            txtDécès.Text = ((COMPOSITEUR)bsCompositeur.Current).anMort.ToString();
            txtNaissance.Text = ((COMPOSITEUR)bsCompositeur.Current).anNais.ToString();
            txtRemarque.Text = ((COMPOSITEUR)bsCompositeur.Current).remarque.ToString();

            bsOeuvre.DataSource = ((COMPOSITEUR)bsCompositeur.Current).OEUVRE.ToList();
            bsNation.DataSource = ((COMPOSITEUR)bsCompositeur.Current).NATIONALITE;
            txtNationalité.Text = ((NATIONALITE)bsNation.Current).libNation.ToString();
            dgvOeuvre.DataSource = bsOeuvre;
            dgvOeuvre.Columns[0].Visible = false;
            dgvOeuvre.Columns[1].Visible = false;
            dgvOeuvre.Columns[2].Visible = false;
            dgvOeuvre.Columns[5].Visible = false;
            dgvOeuvre.Columns[6].Visible = false;
            dgvOeuvre.Columns[7].Visible = false;
        }
      

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            bsCompositeur.DataSource = ((STYLE)bsStyle.Current).COMPOSITEUR.Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur })
                                           .OrderBy(x => x.nomCompositeur);
            dgvCompositeur.DataSource = bsCompositeur;
            dgvCompositeur.Columns[0].HeaderText = "NOM";
            dgvCompositeur.Columns[1].HeaderText = "PRENOM";
            dgvCompositeur.Columns[2].HeaderText = "STYLE";
            dgvCompositeur.Columns[3].HeaderText = "Né le";
            dgvCompositeur.Columns[4].HeaderText = "Mort le";
            dgvCompositeur.Columns[5].HeaderText = "Informations";
            dgvCompositeur.Columns[6].Visible = false;
            txtDebut.Text = ((STYLE)bsStyle.Current).dateDebut.ToString();
            txtFin.Text = ((STYLE)bsStyle.Current).dateFin.ToString();
            txtStyle.Text = ((STYLE)bsStyle.Current).libStyle.ToString();

        }

        private void txtDebut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvInfoCompo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bsOeuvre_CurrentChanged(object sender, EventArgs e)
        {
            bsCompositeur.DataSource = ((STYLE)bsStyle.Current).COMPOSITEUR;

      

        }

        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {
           


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtNaissance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
