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
    public partial class FOeuvre : Form
    {
        public FOeuvre()
        {
            InitializeComponent();
        }

        private void FOeuvre_Load(object sender, EventArgs e)
        {

            bsOeuvre.DataSource = Modele.listeoeuvre();
            dgvOeuvre.DataSource = bsOeuvre;

           
        }

        private void bsOeuvre_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNationalité_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
