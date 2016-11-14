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
    public partial class MDIAlimentos : Form
    {
        public MDIAlimentos()
        {
            InitializeComponent();
            cargarDataGridView();
        }

        private void cargarDataGridView()
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Nombre";
            col.Width = 300;
            col.ReadOnly = true;

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Familia";
            col1.Width = 200;
            col1.ReadOnly = true;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Descripción";
            col2.Width = 600;
            col2.ReadOnly = true;

            dataGridAlimentos.Columns.Add(col);
            dataGridAlimentos.Columns.Add(col1);
            dataGridAlimentos.Columns.Add(col2);

            ArrayList alimentos = Alimento.SelectAll();

            for (int i = 0; i < alimentos.Count; i++)
            {
                Alimento a = (Alimento)alimentos[i];
                dataGridAlimentos.Rows.Add(a.Nombre,a.Familia.Nombre,a.Descripcion);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearAlimento f = new CrearAlimento();
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Provisional, tiene que estar seleccionado un alimento 
            // y se tiene que generar el objeto para ser modificado
            Alimento a = new Alimento();
            ModificarAlimento f = new ModificarAlimento(a);
            f.ShowDialog();
        }

        private void MDIAlimentos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
