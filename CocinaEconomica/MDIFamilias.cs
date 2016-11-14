using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CocinaEconomica
{
    public partial class MDIFamilias : Form
    {
        public MDIFamilias()
        {
            InitializeComponent();
            cargarDataGridView();
        }

        private void cargarDataGridView()
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Nombre";
            col.Width = 500;
            col.ReadOnly = true;

            dataGridFamilias.Columns.Add(col);

            ArrayList familias = Familia.SelectAll();

            for(int i = 0; i < familias.Count; i++)
            {
                Familia f = (Familia)familias[i];
                dataGridFamilias.Rows.Add(f.Nombre);
            }
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
            // Lo mismo xD
            Familia fa = new Familia();
            ModificarFamilia f = new ModificarFamilia(fa);
            f.ShowDialog();
        }

        private void MDIFamilias_Load(object sender, EventArgs e)
        {

        }
    }
}
