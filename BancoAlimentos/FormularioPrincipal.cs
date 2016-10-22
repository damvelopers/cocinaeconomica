using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoAlimentos
{
    public partial class FormularioPrincipal : Form
    {
        /// "Data Source='localhost';Initial Catalog='BancoAlimentos';User ID='sa';Password='elite'";
        /// <summary>
        /// En este formulario se muestran todos los nombres de productos distintos para que
        /// el usuario clique y acceda a otro formulario en el que salen todos los productos 
        /// con el mismo nombre
        /// </summary>
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoAlimentosDataSet.Imagen' Puede moverla o quitarla según sea necesario.
            //this.imagenTableAdapter.Fill(this.bancoAlimentosDataSet.Imagen);
            // TODO: esta línea de código carga datos en la tabla 'bancoAlimentosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.bancoAlimentosDataSet.Producto);

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
