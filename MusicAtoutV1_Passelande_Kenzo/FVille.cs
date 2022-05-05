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
    public partial class FVille : Form
    {
        public FVille()
        {
            InitializeComponent();
        }

        private void FVille_Load(object sender, EventArgs e)
        {
            
            bsVille.DataSource = Modele.listeville();
            dgvVille.DataSource = bsVille;
            
            dgvVille.Columns[1].HeaderText = "Nom de la ville";
            dgvVille.Columns[2].HeaderText = "N°Département";

            
            dgvVille.Columns[0].Visible = false;
            dgvVille.Columns[3].Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
