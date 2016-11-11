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
    public partial class MDIFamilias : Form
    {
        public MDIFamilias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearFamilia f = new CrearFamilia();
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarFamilia f = new ModificarFamilia();
            f.ShowDialog();
        }
    }
}
