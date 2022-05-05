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
    public partial class FSalle : Form
    {
        public FSalle()
        {
            InitializeComponent();
        }

        private void FSalles_Load(object sender, EventArgs e)
        {
            bsSalle.DataSource = Modele.listesalle();
            dgvSalle.DataSource = bsSalle;

            dgvSalle.Columns[0].Visible = false;
            dgvSalle.Columns[1].Visible = false;
            dgvSalle.Columns[5].Visible = false;
            dgvSalle.Columns[6].Visible = false;
        }

        private void dgvSalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
