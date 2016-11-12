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
    public partial class ModificarProducto : Form
    {
        private Producto producto;

        public ModificarProducto(Producto producto)
        {
            this.producto = producto;
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtAlimento.Text == "")
            {
                MessageBox.Show(this, "El campo Alimento es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            this.producto.Alimento = Alimento.SelectWhereNombreIs(txtAlimento.Text);
            this.producto.FechaEntrada = fechEntrada.Value;
            this.producto.FechaCaducidad = fechCaducidad.Value;
            this.producto.FechaConsumirPreferente = fechConsPref.Value;
            this.producto.Proveedor = cbOrigen.SelectedItem.ToString();

            if (producto.Alimento != null)
            {
                bool ok = producto.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado un producto correctamente.", "Producto modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
