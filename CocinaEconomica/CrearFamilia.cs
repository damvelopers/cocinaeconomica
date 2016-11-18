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
    public partial class CrearFamilia : Form
    {
        private MDIFamilias fFamilias;

        public CrearFamilia(MDIFamilias fFamilias)
        {
            this.fFamilias = fFamilias;
            InitializeComponent();
        }

        public CrearFamilia()
        {
            InitializeComponent();
        }


        private void btn_elegirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";

            openFileDialog1.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fFamilias.cargarDataGridView();
            }catch(Exception ex) { }
            
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txtFamilia.Text == "")
            {
                MessageBox.Show(this, "El campo Nombre es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Familia f = new Familia();
            f.Nombre = txtFamilia.Text;
            if (f.Nombre != "")
            {
                bool ok = f.Insert();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error insertando la familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se añadido una nueva familia correctamente.", "Familia añadida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFamilia.Text = "";
                    try
                    {
                        this.fFamilias.cargarDataGridView();
                    }catch(Exception ex) { }
                }
            }
        }
    }
}
