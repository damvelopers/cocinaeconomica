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
    public partial class CrearAlmacen : Form
    {
        public CrearAlmacen()
        {
            InitializeComponent();
        }

        private void CrearAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Almacen a = new Almacen();
            a.Nombre = txtNombre.Text;
            a.Descripcion = txtDescripcion.Text;
            if (a.Nombre != "")
            {
                bool ok = a.Insert();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error insertando el almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se añadido un nuevo almacén correctamente.", "Almacén añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
