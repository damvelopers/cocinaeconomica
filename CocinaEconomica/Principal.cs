using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocinaEconomica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
                Form f = new MDIAlimentos();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
                
            }
        }
    }
}
