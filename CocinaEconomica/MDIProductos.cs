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
    public partial class MDIProductos : Form
    {
        public MDIProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearProducto f = new crearProducto();
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Provisional, tiene que haber un producto o más seleccionados y generar el objeto
            Producto p = new Producto();
            ModificarProducto f = new ModificarProducto(p);
            f.ShowDialog();
        }
    }
}
