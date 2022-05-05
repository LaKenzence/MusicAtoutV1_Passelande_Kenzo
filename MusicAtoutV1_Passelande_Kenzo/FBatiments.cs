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
    public partial class FBatiments : Form
    {
        public FBatiments()
        {
            InitializeComponent();
        }

        private void FBatiments_Load(object sender, EventArgs e)
        {
            bsBatiment.DataSource = Modele.listebatiment();
            dgvBatiment.DataSource = bsBatiment;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
