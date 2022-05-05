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
    public partial class FTypesd_oeuvre : Form
    {
        public FTypesd_oeuvre()
        {
            InitializeComponent();
        }

        private void FTypesdoeuvre_Load(object sender, EventArgs e)
        {
            bsTypedoeuvre.DataSource = Modele.listetypedoeuvre();
            dgvTypedoeuvre.DataSource = bsTypedoeuvre;

        }
    }
}
