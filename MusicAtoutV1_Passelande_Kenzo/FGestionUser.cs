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
    public partial class FGestionUser : Form
    {
        public FGestionUser()
        {
            InitializeComponent();
        }

        private void FGestionUser_Load(object sender, EventArgs e)
        {
            if (Modele.UtilisateurConnecte.droits <= 2)
            {
                bsUser.DataSource = Modele.listeonlyusers();
                dgvUser.DataSource = bsUser;
            }
            if (Modele.UtilisateurConnecte.droits > 2)
            {
                bsUser.DataSource = Modele.listeuseradmin();
                dgvUser.DataSource = bsUser;
                btnAdd.Visible = true;
                btnDesac.Visible = true;
                lblID.Visible = true;
                lblDroit.Visible = true;
                cboDroits.Visible = true;
                txtId.Visible = true;
                btnSuppr.Visible = true;
            }
            dgvUser.Columns[1].Visible = false;
        }

        private void btnReactiver_Click(object sender, EventArgs e)
        {
            System.Type type = bsUser.Current.GetType();
            string id = (string)type.GetProperty("idUtilisateur").GetValue(bsUser.Current, null);
            Modele.UtilisateurChoisi = Modele.trouveuserById(id);
            if (Modele.reactivateUser())
            {
                MessageBox.Show("Utilisateur réactivé avec succès !");
            }
            FGestionUser_Load(new object(), new EventArgs());
        }

        private void btnDesac_Click(object sender, EventArgs e)
        {
                System.Type type = bsUser.Current.GetType();
                string id = (string)type.GetProperty("idUtilisateur").GetValue(bsUser.Current, null);
                Modele.UtilisateurChoisi = Modele.trouveuserById(id);
                if (Modele.desactiverUser())
                {
                    MessageBox.Show("Utilisateur désactivé avec succès !");
                }
                FGestionUser_Load(new object(), new EventArgs());
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            System.Type type = bsUser.Current.GetType();
            string id = (string)type.GetProperty("idUtilisateur").GetValue(bsUser.Current, null);
            Modele.UtilisateurChoisi = Modele.trouveuserById(id);
            if (Modele.AddUser(txtId.Text, Convert.ToInt32(cboDroits.SelectedIndex + 1)))
            {
                MessageBox.Show("Ajout effectué avec succès !");

            }
            FGestionUser_Load(new object(), new EventArgs());
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            System.Type type = bsUser.Current.GetType();
            string id = (string)type.GetProperty("idUtilisateur").GetValue(bsUser.Current, null);
            Modele.UtilisateurChoisi = Modele.trouveuserById(id);
            if (Modele.DelUser())
            {
                MessageBox.Show("Suppression réussie!")
;
            }

            FGestionUser_Load(new object(), new EventArgs());
        }
    }
}
