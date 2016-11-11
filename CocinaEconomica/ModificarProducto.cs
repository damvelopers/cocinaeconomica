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
        public ModificarProducto()
        {
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

            Producto p = new Producto();
            p.Alimento = Alimento.SelectWhereNombreIs(txtAlimento.Text);
            p.FechaEntrada = fechEntrada.Value;
            p.FechaCaducidad = fechCaducidad.Value;
            p.FechaConsumirPreferente = fechConsPref.Value;
            //p.Proveedor = cbOrigen.SelectedItem.ToString;
            if (p.Alimento != null)
            {
                bool ok = p.Update();
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
