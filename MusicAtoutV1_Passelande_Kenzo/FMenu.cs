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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvVille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void FMenu_Load(object sender, EventArgs e)
        {
            if (Modele.UtilisateurConnecte.droits >= 2)
            {
                UTILISATEURToolStripMenuItem.Visible = true;
                gestionToolStripMenuItem.Visible = true;
            }
        }

        private void cOMPOSITEURToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FAjoutModifCompositeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form monForm = new FAjoutModifCompositeur();
           monForm.MdiParent = this;
           monForm.Show();
        }

 

        private void gestionToolStripMenuItem_Click_1(object sender, EventArgs e)
        
            {
                Form maFormUser = new FGestionUser();
                maFormUser.MdiParent = this;
                maFormUser.Show();
            }

        private void vILLESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            {
                Form monForm = new FVille();
                monForm.MdiParent = this;
                monForm.Show();

            }
        }

        private void lISTEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void sALLESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form monForm = new FSalle();
            monForm.MdiParent = this;
            monForm.Show();
        }

        private void bATIMENTSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form monForm = new FBatiments();
            monForm.MdiParent = this;
            monForm.Show();
        }

        private void tYPESDOEUVREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form monForm = new FTypesd_oeuvre();
            monForm.MdiParent = this;
            monForm.Show();
        }

        private void nATIONALITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form monForm = new FCompositeurNation();
            monForm.MdiParent = this;
            monForm.Show();
        }

        private void sTYLEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form monForm = new FcompositeurStyle();
            monForm.MdiParent = this;
            monForm.Show();
        }
    }
}
