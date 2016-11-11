using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CocinaEconomica
{
    public partial class crearProducto : Form
    {
        public crearProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void crearProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CrearAlimento f = new CrearAlimento();
            f.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txtAlimento.Text == "")
            {
                MessageBox.Show(this, "El campo Alimento es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Producto p = new Producto();
            p.Alimento = Alimento.SelectWhereNombreIs(txtAlimento.Text);
            p.FechaEntrada = dateTimeFechaEn.Value;
            p.FechaCaducidad = dateTimeFechaCad.Value;
            p.FechaConsumirPreferente = dateTimeFechaPref.Value;
            //p.Proveedor = comboBoxOrigen.SelectedItem.ToString;
            int cant = Int32.Parse(txtCantidad.Text);
            for (int i = 0; i < cant; i++)
            {
                if (p.Alimento != null)
                {
                    bool ok = p.Insert();
                    // Feedback!
                    if (!ok)
                    {
                        MessageBox.Show(this, "Se ha producido un error insertando el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //MessageBox.Show(this, "Se añadido un nuevo producto correctamente.", "Producto añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
